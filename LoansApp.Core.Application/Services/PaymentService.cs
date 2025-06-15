using AutoMapper;
using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.DTOs.Payment;
using LoansApp.Core.Application.DTOs.Record;
using LoansApp.Core.Application.Interfaces.Repositories;
using LoansApp.Core.Application.Interfaces.Services;
using LoansApp.Core.Domain.Entities;
using System.Data;

namespace LoansApp.Core.Application.Services
{
    public class PaymentService : GenericService<SavePayment, ViewPayment, Payment>, IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly ILoanService _loanService;
        private readonly IRecordService _recordService;
        private readonly IMapper _mapper;

        public PaymentService(IPaymentRepository paymentRepository, ILoanService loanService, IMapper mapper, IRecordService recordService) : base(paymentRepository, mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
            _loanService = loanService;
            _recordService = recordService;
        }

        public async Task AddAsync(SavePayment saveEntity, SaveLoan saveLoan)
        {
            Payment entity = _mapper.Map<Payment>(saveEntity);
            await base.AddAsync(saveEntity);
            await _loanService.UpdateAsync(saveLoan, entity.LoanID);
        }

        public async Task<List<ViewPayment>> GetByLoanIdAsync(int loanId)
        {
            var paymentList = await _paymentRepository.GetByLoanIdAsync(loanId);
            return _mapper.Map<List<ViewPayment>>(paymentList);
        }

        public async Task<bool> ApplyPaymentAsync(SavePayment saveEntity)
        {
            var loan = await _loanService.GetByIdAsync(saveEntity.LoanID);
            if (loan == null)
            {
                throw new Exception("Loan not found");
            }

            int loanBalance = int.Parse(loan.LoanBalance);
            int capital = int.Parse(loan.Capital);
            int remainingFees = int.Parse(loan.RemainingFees);
            int interest = int.Parse(loan.Interest);

            var updatedLoan = _mapper.Map<SaveLoan>(loan);
            updatedLoan.LoanBalance = (loanBalance - capital).ToString();
            updatedLoan.RemainingFees = (remainingFees - 1).ToString();

            saveEntity.MonthDay = $"{saveEntity.Day} / {saveEntity.Month}";

            var existingPayments = await _paymentRepository.GetByLoanIdAsync(saveEntity.LoanID);

            var record = new SaveRecord
            {
                Name = loan.Name,
                loanNumber = loan.Number,
                EndDate = DateTime.Now.ToShortDateString(),
                MonthlyIncome = loan.TotalIncome,
                MonthlyInterest = loan.Interest,
                MonthlyCapital = loan.Capital,
                LoanValue = loan.Value,
                TotalInterestIncomes = (interest * (existingPayments.Count + 1)).ToString()
            };

            await _paymentRepository.AddAsync(_mapper.Map<Payment>(saveEntity));
            await _loanService.UpdateAsync(updatedLoan, loan.ID);

            bool isFinalPayment = int.Parse(updatedLoan.RemainingFees) <= 0 &&
                           int.Parse(updatedLoan.LoanBalance) <= capital;

            if (isFinalPayment)
            {
                await _recordService.AddAsync(record);
                await _loanService.DeleteAsync(loan.ID);
                return true;
            }
            return false;
        }

        public DataTable MapPaymentsToDataTable(List<ViewPayment> payments)
        {
            DataTable table = new();
            table.Columns.Add("Day", typeof(string));
            table.Columns.Add("Month", typeof(string));
            table.Columns.Add("Year", typeof(string));
            table.Columns.Add("Amount", typeof(string));

            foreach (var payment in payments)
            {
                table.Rows.Add(
                    payment.Day,
                    payment.Month,
                    payment.Year,
                    payment.Amount
                );
            }

            return table;
        }
    }
}
