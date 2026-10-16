using LoansApp.Core.Application.Interfaces.Repositories;
using LoansApp.Core.Domain.Entities;
using LoansApp.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LoansApp.Infrastructure.Persistence.Repositories
{
    public class LoanRepository : GenericRepository<Loan>, ILoanRepository
    {
        private readonly ApplicationContext _dbContext;

        public LoanRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<List<Loan>> GetAllAsync(Expression<Func<Loan, bool>> filter)
        {
            var query = _dbContext.Set<Loan>().AsQueryable();

            if (filter != null)
                query = query.Where(filter);

            return await query.ToListAsync();
        }
    }
}
