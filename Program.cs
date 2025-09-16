using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pulse.Data;
using Pulse.Forms.MainFRM;
using Syncfusion.Windows.Forms;
using System.Reflection;
using Pulse.Repository.DoctorRepo;
using Pulse.Repository.PatientRepo;
using Pulse.Repository.AppointmentRepo;

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
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(secretValue);

            IHost host = Host.CreateDefaultBuilder(args).ConfigureServices((context, services) =>
            {
                const string connectionString = "PulseDB";
                services.AddDbContext<PulseDbContext>(options =>
                {
                    options.UseSqlite(context.Configuration.GetConnectionString(connectionString));
                }, ServiceLifetime.Singleton);

                services.AddSingleton<IDoctorRepository, DoctorRepository>();
                services.AddSingleton<IPatientRepository, PatientRepository>();
                services.AddSingleton<IAppointmentRepository, AppointmentRepository>();
                services.AddSingleton<frmMain>();
            }).Build();


            var form = ServiceProviderServiceExtensions.GetService<frmMain>(host.Services);
            Application.Run(form);

        }
    }
}