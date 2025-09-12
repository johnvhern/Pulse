using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pulse.Data;
using Pulse.Forms.MainFRM;
using Pulse.Repository;
using Syncfusion.Windows.Forms;
using System.Reflection;

namespace Pulse
{
    internal static class Program
    {
       
        [STAThread]
        static void Main(string[] args)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;

            IConfiguration config = new ConfigurationBuilder()
             .AddJsonFile("secrets.json", optional: true)
             .AddUserSecrets(Assembly.GetExecutingAssembly()) 
             .Build();

            string secretValue = config["SyncfusionLicense"];


            ApplicationConfiguration.Initialize();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(secretValue);

            IHost host = Host.CreateDefaultBuilder(args).ConfigureServices((context, services) =>
            {
                const string connectionString = "PatientDB";
                services.AddDbContext<PulseDbContext>(options =>
                {
                    options.UseSqlite(context.Configuration.GetConnectionString(connectionString));
                }, ServiceLifetime.Singleton);

                services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
                services.AddSingleton<frmMain>();
            }).Build();


            var form = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetService<frmMain>(host.Services);
            Application.Run(form);

        }
    }
}