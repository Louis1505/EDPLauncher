using System.Diagnostics;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace EDPLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#2f2f2f");
            button_prod.BackColor = ColorTranslator.FromHtml("#8e2720");
            button_prod.ForeColor = ColorTranslator.FromHtml("#ffffff");
            button_test.BackColor = ColorTranslator.FromHtml("#535353");
            button_test.ForeColor = ColorTranslator.FromHtml("#ffffff");
            button_not.BackColor = ColorTranslator.FromHtml("#535353");
            button_not.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        string username = Environment.UserName;
        string ausgabe = @"C:\EDP\ELP\ELP.ini";
        string standard = @"C:\EDP\ELP\ELP_Backup.ini";
        string edpExe = @"C:\EDP\ELP\ELP.exe";

        private void button_prod_Click(object sender, EventArgs e)
        {
            // Pfade dynamisch definieren
            string user_ini = $@"C:\Users\{username}\OneDrive - Feuerwehr Stadt Bad Harzburg\Dokumente\EDP\login.txt";
            string system_ini = @"C:\EDP\EDPLauncher\Konfiguration\prod.ini";
            //Aufruf Ini Erstellen
            create_ini(user_ini, system_ini);
        }
        private void button_not_Click(object sender, EventArgs e)
        {
            // Pfade dynamisch definieren
            string user_ini = $@"C:\Users\{username}\OneDrive - Feuerwehr Stadt Bad Harzburg\Dokumente\EDP\login.txt";
            string system_ini = @"C:\EDP\EDPLauncher\Konfiguration\not.ini";
            //Aufruf Ini Erstellen
            create_ini(user_ini, system_ini);
        }
        private void button_test_Click(object sender, EventArgs e)
        {
            // Pfade dynamisch definieren
            string user_ini = $@"C:\Users\{username}\OneDrive - Feuerwehr Stadt Bad Harzburg\Dokumente\EDP\login.txt";
            string system_ini = @"C:\EDP\EDPLauncher\Konfiguration\test.ini";
            //Aufruf Ini Erstellen
            create_ini(user_ini, system_ini);
        }

        void create_ini(string user_ini, string system_ini)
        {
            try
            {
                // Überprüfen, ob die Dateien existieren
                if (!File.Exists(user_ini))
                {
                    Console.WriteLine($"Fehler: Datei \"{user_ini}\" nicht gefunden.");
                    return;
                }

                if (!File.Exists(system_ini))
                {
                    Console.WriteLine($"Fehler: Datei \"{system_ini}\" nicht gefunden.");
                    return;
                }

                // Inhalte zusammenführen
                Console.WriteLine("Inhalte werden zusammengeführt...");
                using (StreamWriter writer = new StreamWriter(ausgabe))
                {
                    writer.Write(File.ReadAllText(user_ini));
                    writer.WriteLine();
                    writer.Write(File.ReadAllText(system_ini));
                }

                // Erfolgsmeldung ausgeben
                if (File.Exists(ausgabe))
                {
                    Console.WriteLine($"Die Dateien wurden erfolgreich zusammengeführt in \"{ausgabe}\".");
                }
                else
                {
                    Console.WriteLine("Fehler: Die Ausgabedatei konnte nicht erstellt werden.");
                    return;
                }
                //Aufruf EDPStart, Ini auf Standard setzen
                Abschluss();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
            }
        }
        private void Abschluss()
        {
            // EDP starten
            if (File.Exists(edpExe))
            {
                Console.WriteLine("EDP wird gestartet...");
                Process.Start(edpExe);
            }
            else
            {
                Console.WriteLine($"Fehler: Die Anwendung \"{edpExe}\" wurde nicht gefunden.");
                return;
            }

            // STANDARD INI ERZEUGEN nach 25 Sekunden Wartezeit
            Thread.Sleep(25000);
            Console.WriteLine("Standard INI wird erstellt...");
            using (StreamWriter writer = new StreamWriter(ausgabe))
            {
                writer.Write(File.ReadAllText(standard));
            }

            this.Close();
        }

        private void button_test_Click_1(object sender, EventArgs e)
        {

        }
    }
}