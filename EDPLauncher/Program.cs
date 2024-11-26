using System.Diagnostics;

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
            string updaterPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EDPLauncherUpdate.exe");

            // Prüfen, ob die Updater-Exe existiert
            if (File.Exists(updaterPath))
            {
                try
                {
                    // Starten der Updater-Exe mit optionalen Argumenten
                    Process updaterProcess = Process.Start(updaterPath, "/checknow /silent");
                    updaterProcess.WaitForExit(); // Warten, bis der Updater abgeschlossen ist

                    // Optional: Überprüfen des Exit-Codes des Updaters
                    if (updaterProcess.ExitCode == 0)
                    {
                        MessageBox.Show("Updates erfolgreich überprüft oder installiert.");
                    }
                    else
                    {
                        
                    }
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


        }
    }
}