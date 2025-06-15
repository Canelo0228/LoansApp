using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.DTOs.Payment;
using System.Data;

namespace LoansApp.Core.Application.Interfaces.Services
{
    public interface IPaymentService
    {
        Task AddAsync(SavePayment saveEntity, SaveLoan saveLoan);
        Task<List<ViewPayment>> GetAllAsync();
        Task<ViewPayment> GetByIdAsync(int id);
        Task<List<ViewPayment>> GetByLoanIdAsync(int loanId);
        DataTable MapPaymentsToDataTable(List<ViewPayment> payments);
    }
}
