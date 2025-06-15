using LoansApp.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LoansApp.Infrastructure.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Record> Records { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }
    }
}
