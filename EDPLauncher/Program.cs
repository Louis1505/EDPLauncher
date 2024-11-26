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
            string downloadUrl = "https://raw.githubusercontent.com/Louis1505/EDPLauncher/refs/heads/master/EDPLauncher/Updates/UpdateExe/EDPLauncherSetup.exe";
            string downloadPath = "C:\\EDP\\EDPLauncher\\Updates\\EDPLauncherSetup.exe";
            string currentVersion = GetCurrentVersion();

            // Neue Version von GitHub abrufen
            string newVersion = GetNewVersionFromGitHub().Result;

            if (IsNewVersionAvailable(currentVersion, newVersion))
            {
                try
                {
                    // Neue Datei herunterladen
                    DownloadNewVersion(downloadUrl, downloadPath).Wait();

                    // Neue Datei ausführen
                    Process newVersionProcess = Process.Start(downloadPath);
                    newVersionProcess.WaitForExit(); // Warten, bis die neue Version abgeschlossen ist

                    // Anwendung ohne Meldung beenden
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Herunterladen oder Starten der neuen Version: {ex.Message}");
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

        private static async Task DownloadNewVersion(string url, string path)
        {
            using HttpClient client = new HttpClient();
            try
            {
                byte[] data = await client.GetByteArrayAsync(url);
                await File.WriteAllBytesAsync(path, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Herunterladen der neuen Version: {ex.Message}");
                throw;
            }
        }
    }
}
