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

            try
            {
                var parser = new FileIniDataParser();
                string exePath = AppDomain.CurrentDomain.BaseDirectory;
                string iniPath = Path.Combine(exePath, "EDPLauncher.ini");

                if (!File.Exists(iniPath))
                {
                    MessageBox.Show($"INI-Datei nicht gefunden: {iniPath}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                IniData data = parser.ReadFile(iniPath);

                if (!data.Sections.ContainsSection("Settings") || !data["Settings"].ContainsKey("PC"))
                {
                    MessageBox.Show("Ungültige INI-Datei: Sektion [Settings] oder Schlüssel 'PC' fehlt.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string PC = data["Settings"]["PC"];
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1(PC));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Lesen der INI-Datei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            

        }

    }  
}
