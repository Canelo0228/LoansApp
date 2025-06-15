using LoansApp.Core.Application.Interfaces.Repositories;
using LoansApp.Core.Domain.Entities;
using LoansApp.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LoansApp.Infrastructure.Persistence.Repositories
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        private readonly ApplicationContext _dbContext;

        Dictionary<string, int> monthlyOrder = new Dictionary<string, int>
        {
            ["January"] = 1,
            ["February"] = 2,
            ["March"] = 3,
            ["April"] = 4,
            ["May"] = 5,
            ["June"] = 6,
            ["July"] = 7,
            ["August"] = 8,
            ["September"] = 9,
            ["October"] = 10,
            ["November"] = 11,
            ["December"] = 12
        };

        public PaymentRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<List<Payment>> GetByLoanIdAsync(int loanId)
        {
            var payments =  await _dbContext.Set<Payment>()
                .Where(l => l.LoanID == loanId)
                .ToListAsync();

            var order = payments
                .OrderByDescending(l => l.Year)
                .ThenByDescending(l => monthlyOrder[l.Month])
                .ThenBy(l => l.Day)
                .ToList();

            return order;
        }
    }
}
