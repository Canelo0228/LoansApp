using LoansApp.Core.Domain.Entities;
using System.Linq.Expressions;

namespace LoansApp.Core.Application.Interfaces.Repositories
{
    public interface ILoanRepository : IGenericRepository<Loan>
    {
        Task<List<Loan>> GetAllAsync(Expression<Func<Loan, bool>> filter);
    }
}
