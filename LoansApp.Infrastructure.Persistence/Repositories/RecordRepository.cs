using LoansApp.Core.Application.Interfaces.Repositories;
using LoansApp.Core.Domain.Entities;
using LoansApp.Infrastructure.Persistence.Contexts;

namespace LoansApp.Infrastructure.Persistence.Repositories
{
    public class RecordRepository : GenericRepository<Record>, IRecordRepository
    {
        private readonly ApplicationContext _dbContext;
        public RecordRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
