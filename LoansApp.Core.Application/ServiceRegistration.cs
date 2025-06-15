using LoansApp.Core.Application.Interfaces.Services;
using LoansApp.Core.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace LoansApp.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            #region Services
            services.AddScoped<ILoanService, LoanService>();
            services.AddScoped<IRecordService, RecordService>();
            services.AddScoped<IPaymentService, PaymentService>();
            #endregion
        }
    }
}
