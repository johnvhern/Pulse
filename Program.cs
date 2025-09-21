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

                services.AddSingleton<IUserRepository, UserRepository>();
                services.AddSingleton<IDoctorRepository, DoctorRepository>();
                services.AddSingleton<IPatientRepository, PatientRepository>();
                services.AddSingleton<IAppointmentRepository, AppointmentRepository>();
                services.AddSingleton<frmLogin>();
                services.AddSingleton<frmRegister>();
                services.AddSingleton<OnLoadFormDirect>();
            }).Build();

            var helper = new OnLoadFormDirect();
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

            //var form = ServiceProviderServiceExtensions.GetService<frmLogin>(host.Services);
            //Application.Run(form);
        }
    }
}