using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Pulse.Forms.MainFRM;
using Syncfusion.Windows.Forms;
using System.Reflection;

namespace Pulse
{
    public class SecretsMarker { }
    internal static class Program
    {
       
        [STAThread]
        static void Main(string[] args)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;

            IConfiguration config = new ConfigurationBuilder()
             .AddJsonFile("secrets.json", optional: true)
             .AddUserSecrets(Assembly.GetExecutingAssembly()) // Pass any class from your assembly
             .Build();

            string secretValue = config["SyncfusionLicense"];


            ApplicationConfiguration.Initialize();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(secretValue);

            Application.Run(new frmMain());
        }
    }
}