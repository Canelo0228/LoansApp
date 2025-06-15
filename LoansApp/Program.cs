using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using LoansApp.Infrastructure.Persistence;
using LoansApp.Core.Application;

namespace LoansApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();

            ApplicationConfiguration.Initialize();
            
            var form = host.Services.GetRequiredService<LoansForm>();
            
            Application.Run(form);
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddPersistenceInfraestructure(context.Configuration);
                    services.AddApplicationLayer(context.Configuration);
                    services.AddScoped<LoansForm>();
                });
        }
    }
}
