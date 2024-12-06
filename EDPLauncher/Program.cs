using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace EDPLauncher
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(@"C:\EDP\EDPLauncher\EDPLauncher.ini");

            // Wert auslesen
            string PC = data["Settings"]["PC"];

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(PC));

        }

    }  
}
