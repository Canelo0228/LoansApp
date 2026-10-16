using LoansApp.Core.Application.Interfaces.Repositories;
using LoansApp.Core.Domain.Entities;
using LoansApp.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LoansApp.Infrastructure.Persistence.Repositories
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        private readonly ApplicationContext _dbContext;

        public PaymentRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<List<Payment>> GetByLoanIdAsync(int loanId)
        {
            var payments =  await _dbContext.Set<Payment>()
                .Where(l => l.LoanId == loanId)
                .ToListAsync();

            var order = payments
                .OrderByDescending(l => l.Date)
                .ToList();

            return order;
        }
    }
}
