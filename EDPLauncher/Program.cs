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
            string downloadUrl = "https://raw.githubusercontent.com/Louis1505/EDPLauncher/refs/heads/master/EDPLauncher/Updates/UpdateExe/EDPLauncherSetup.exe";
            string downloadPath = "C:\\EDP\\EDPLauncher\\Updates\\EDPLauncherSetup.exe";
            string currentVersion = GetCurrentVersion();
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(@"C:\EDP\EDPLauncher\EDPLauncher.ini");

            // Wert auslesen
            string PC = data["Settings"]["PC"];
            // Neue Version von GitHub abrufen
            string newVersion = GetNewVersionFromGitHub().Result;

            if (IsNewVersionAvailable(currentVersion, newVersion))
            {
                try
                {
                    AutoClosingMessageBox.Show("EDPLauncher führt ein Update durch....", "Update", 5000);

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
                Application.Run(new Form1(PC));
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

    public class AutoClosingMessageBox
    {
        private System.Threading.Timer _timeoutTimer;
        private string _caption;
        private AutoClosingMessageBox(string text, string caption, int timeout)
        {
            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed, null, timeout, System.Threading.Timeout.Infinite);
            MessageBox.Show(text, caption);
        }

        public static void Show(string text, string caption, int timeout)
        {
            new AutoClosingMessageBox(text, caption, timeout);
        }

        private void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow(null, _caption);
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }

        private const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
    }
}
