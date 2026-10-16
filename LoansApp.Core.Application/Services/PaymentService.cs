using AutoMapper;
using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.DTOs.Payment;
using LoansApp.Core.Application.DTOs.Record;
using LoansApp.Core.Application.Interfaces.Repositories;
using LoansApp.Core.Application.Interfaces.Services;
using LoansApp.Core.Domain.Entities;

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
            await _loanService.UpdateAsync(saveLoan, entity.LoanId);
        }

        public async Task<List<ViewPayment>> GetByLoanIdAsync(int loanId)
        {
            var paymentList = await _paymentRepository.GetByLoanIdAsync(loanId);
            return _mapper.Map<List<ViewPayment>>(paymentList);
        }

        public async Task<bool> ApplyPaymentAsync(SavePayment saveEntity)
        {
            var loan = await _loanService.GetByIdAsync(saveEntity.LoanId);

            if (loan == null)
                throw new InvalidOperationException("Loan not found.");

            if (loan.OutstandingBalance <= 0 ||
                loan.RemainingInstallments <= 0)
            {
                throw new InvalidOperationException(
                    "This loan cannot receive payments.");
            }

            if (saveEntity.Amount != loan.MonthlyPayment)
            {
                throw new ArgumentException(
                    "The payment must correspond to the full monthly installment.");
            }

            decimal newBalance = Math.Max(
                0m,
                loan.OutstandingBalance - loan.MonthlyPrincipal);

            int newRemainingInstallments =
                loan.RemainingInstallments - 1;

            bool isFinalPayment =
                newRemainingInstallments == 0 || newBalance == 0;

            saveEntity.Date = DateOnly.FromDateTime(DateTime.UtcNow);

            await _paymentRepository.AddAsync(
                _mapper.Map<Payment>(saveEntity));

            var updatedLoan = _mapper.Map<SaveLoan>(loan);

            updatedLoan.OutstandingBalance = newBalance;
            updatedLoan.RemainingInstallments =
                newRemainingInstallments;

            await _loanService.UpdateAsync(updatedLoan, loan.Id);

            if (isFinalPayment)
            {
                var existingPayments =
                    await _paymentRepository.GetByLoanIdAsync(loan.Id);

                var record = new SaveRecord
                {
                    CustomerName = loan.CustomerName,
                    EndDate = saveEntity.Date,
                    MonthlyPayment = loan.MonthlyPayment,
                    MonthlyInterest = loan.MonthlyInterest,
                    MonthlyPrincipal = loan.MonthlyPrincipal,
                    OriginalLoanAmount = loan.OriginalLoanAmount,
                    TotalInterestIncome =
                        loan.MonthlyInterest * existingPayments.Count
                };

                await _recordService.AddAsync(record);
                await _loanService.DeleteAsync(loan.Id);
            }

            return isFinalPayment;
        }
    }
}