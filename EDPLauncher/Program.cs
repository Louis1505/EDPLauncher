using System.Diagnostics;
using System.Net.Http;
using System.Reflection;

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
            string updaterPath = "C:\\EDP\\EDPLauncher\\EDPLauncherUpdate.exe";
            string currentVersion = GetCurrentVersion();

            // Neue Version von GitHub abrufen
            string newVersion = GetNewVersionFromGitHub().Result;

            if (IsNewVersionAvailable(currentVersion, newVersion))
            {
                // Prüfen, ob die Updater-Exe existiert
                if (File.Exists(updaterPath))
                {
                    try
                    {
                        // Starten der Updater-Exe mit optionalen Argumenten
                        Process updaterProcess = Process.Start(updaterPath, "/checknow /silent");
                        updaterProcess.WaitForExit(); // Warten, bis der Updater abgeschlossen ist

                        // Anwendung ohne Meldung beenden
                        Environment.Exit(0);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Fehler beim Starten des Updaters: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Die Datei 'updater.exe' wurde nicht gefunden.");
                }
            }
            else
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
        }

        private static string GetCurrentVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private static async Task<string> GetNewVersionFromGitHub()
        {
            string url = "https://raw.githubusercontent.com/Louis1505/EDPLauncher/refs/heads/master/EDPLauncher/Updates/update.txt"; // URL zur Textdatei auf GitHub
            using HttpClient client = new HttpClient();
            try
            {
                string content = await client.GetStringAsync(url);
                return ParseLatestVersion(content);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Abrufen der neuen Version: {ex.Message}");
                return ""; // Rückgabe der aktuellen Version im Fehlerfall
            }
        }

        private static string ParseLatestVersion(string content)
        {
            var lines = content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                if (line.StartsWith("[") && line.EndsWith("]"))
                {
                    return line.Trim('[', ']');
                }
            }
            return "";
        }

        private static bool IsNewVersionAvailable(string currentVersion, string newVersion)
        {
            return string.Compare(currentVersion, newVersion, StringComparison.Ordinal) < 0;
        }
    }
}
