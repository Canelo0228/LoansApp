using LoansApp.Core.Application.Interfaces.Repositories;
using LoansApp.Infrastructure.Persistence.Contexts;
using LoansApp.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LoansApp.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            var folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "CaneloSoftware",
                "LoansApp"
            );
            Directory.CreateDirectory(folder);
            var dbPath = Path.Combine(folder, "app.db");

            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlite($"Data Source={dbPath}"));


            #region Repositories
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ILoanRepository, LoanRepository>();
            services.AddScoped<IRecordRepository, RecordRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            #endregion
        }
    }
}
