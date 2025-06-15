using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.DTOs.Payment;
using LoansApp.Core.Application.Interfaces.Repositories;
using LoansApp.Core.Application.Interfaces.Services;
using LoansApp.Core.Domain.Entities;
using System.Data;

namespace LoansApp.Core.Application.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly ILoanService _loanService;

        public PaymentService(IPaymentRepository paymentRepository, ILoanService loanService)
        {
            _paymentRepository = paymentRepository;
            _loanService = loanService;
        }

        public async Task AddAsync(SavePayment saveEntity, SaveLoan saveLoan)
        {
            Payment entity = new()
            {
                Amount = saveEntity.Amount,
                Day = saveEntity.Day,
                ID = saveEntity.ID,
                Month = saveEntity.Month,
                Year = saveEntity.Year,
                MonthDay = saveEntity.MonthDay,
                LoanID = saveEntity.Loan.ID
            };

            await _paymentRepository.AddAsync(entity);

            await _loanService.UpdateAsync(saveLoan, entity.LoanID);

        }

        public async Task<List<ViewPayment>> GetAllAsync()
        {
            var entityList = await _paymentRepository.GetAllAsync();

            return entityList.Select(entity => new ViewPayment
            {
                Amount = entity.Amount,
                Day = entity.Day,
                ID = entity.ID,
                Month = entity.Month,
                Year = entity.Year,
                MonthDay = entity.MonthDay,
                LoanID = entity.Loan.ID
            }).ToList();
        }

        public async Task<ViewPayment> GetByIdAsync(int id)
        {
            Payment entity = await _paymentRepository.GetByIdAsync(id);

            ViewPayment viewPayment = new()
            {
                Amount = entity.Amount,
                Day = entity.Day,
                ID = entity.ID,
                Month = entity.Month,
                Year = entity.Year,
                MonthDay = entity.MonthDay,
                LoanID = entity.Loan.ID
            };

            return viewPayment;
        }

        public async Task<List<ViewPayment>> GetByLoanIdAsync(int loanId)
        {
            var paymentList = await _paymentRepository.GetByLoanIdAsync(loanId);
            return paymentList.Select( entity => new ViewPayment
            {
                Amount = entity.Amount,
                Day = entity.Day,
                ID = entity.ID,
                Month = entity.Month,
                Year = entity.Year,
                MonthDay = entity.MonthDay,
                LoanID = entity.Loan.ID
            }).ToList();
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
