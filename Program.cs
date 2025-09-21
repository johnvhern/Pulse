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
using Pulse.Forms.LoginFRM;
using Pulse.Repository.UserRepo;
using Pulse.Forms.RegisterFRM;
using Pulse.Helper;

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
                var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PulseDB.db");
                services.AddDbContext<PulseDbContext>(options =>
                {
                    options.UseSqlite($"Data Source={dbPath}");
                }, ServiceLifetime.Scoped);

                services.AddScoped<IDoctorRepository, DoctorRepository>();
                services.AddScoped<IPatientRepository, PatientRepository>();
                services.AddScoped<IAppointmentRepository, AppointmentRepository>();
                services.AddScoped<IUserRepository, UserRepository>();

                services.AddScoped<frmLogin>();
                services.AddScoped<frmRegister>();
                services.AddScoped<OnLoadFormDirect>();
            }).Build();

            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            var helper = ServiceProviderServiceExtensions.GetService<OnLoadFormDirect>(host.Services);
            var whichForm = helper.whichForm();

            if (whichForm == "login")
            {
                var loginForm = ServiceProviderServiceExtensions.GetRequiredService<frmLogin>(host.Services);
                Application.Run(loginForm);
            }
            else
            {
                var registerForm = ServiceProviderServiceExtensions.GetRequiredService<frmRegister>(host.Services);
                Application.Run(registerForm);
            }

            //var form = ServiceProviderServiceExtensions.GetRequiredService<frmLogin>(host.Services);
            //Application.Run(form);
        }
    }
}