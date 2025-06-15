using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.DTOs.Payment;
using LoansApp.Core.Domain.Entities;
using System.Data;

namespace LoansApp.Core.Application.Interfaces.Services
{
    public interface IPaymentService : IGenericService<SavePayment, ViewPayment, Payment>
    {
        Task AddAsync(SavePayment saveEntity, SaveLoan saveLoan);
        Task<bool> ApplyPaymentAsync(SavePayment saveEntity);
        Task<List<ViewPayment>> GetByLoanIdAsync(int loanId);
        DataTable MapPaymentsToDataTable(List<ViewPayment> payments);
    }
}
