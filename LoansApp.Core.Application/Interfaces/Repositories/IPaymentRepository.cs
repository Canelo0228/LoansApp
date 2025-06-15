using LoansApp.Core.Domain.Entities;

namespace LoansApp.Core.Application.Interfaces.Repositories
{
    public interface IPaymentRepository : IGenericRepository<Payment>
    {
        Task<List<Payment>> GetByLoanIdAsync(int loanId);
    }
}
