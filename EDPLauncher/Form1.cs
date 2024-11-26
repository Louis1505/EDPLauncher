using System.Diagnostics;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Security.Principal;
using Microsoft.VisualBasic.ApplicationServices;
using System.DirectoryServices.AccountManagement;
using Outlook = Microsoft.Office.Interop.Outlook;

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

            string fullName = Environment.UserName;
            username = FormatUsername(fullName);
            label_user.Text = "Es wird eingeloggt: " + username;

        }

        string ausgabe = @"C:\EDP\ELP\ELP.ini";
        string standard = @"C:\EDP\EDPLauncher\Konfiguration\ELP_Backup.ini";
        string edpExe = @"C:\EDP\ELP\ELP.exe";
        string username;
        string fullName;


        static string FormatUsername(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                throw new ArgumentException("Der Name darf nicht leer sein.");
            }

            // Den ersten Groﬂbuchstaben nach dem Vornamen finden
            int splitIndex = -1;
            for (int i = 1; i < fullName.Length; i++)
            {
                if (char.IsUpper(fullName[i]))
                {
                    splitIndex = i;
                    break;
                }
            }

            if (splitIndex == -1)
            {
                return "Kein passender Benutzer gefunden!";
            }

            // Vorname und Nachname trennen
            string firstName = fullName.Substring(0, splitIndex);
            string lastName = fullName.Substring(splitIndex);

            // Erster Buchstabe des Vornamens + Nachname
            return char.ToLower(firstName[0]) + lastName.ToLower();
        }

        private void button_prod_Click(object sender, EventArgs e)
        {
            string system_ini = @"C:\EDP\EDPLauncher\Konfiguration\prod.ini";
            create_ini(system_ini);
        }
        private void button_not_Click(object sender, EventArgs e)
        {
            string system_ini = @"C:\EDP\EDPLauncher\Konfiguration\not.ini";
            create_ini(system_ini);
        }
        private void button_test_Click(object sender, EventArgs e)
        {
            string system_ini = @"C:\EDP\EDPLauncher\Konfiguration\test.ini";
            create_ini(system_ini);
        }

        void create_ini(string system_ini)
        {
            try
            {
                // ‹berpr¸fen, ob die Dateien existieren


                if (!File.Exists(system_ini))
                {
                    Console.WriteLine($"Fehler: Datei \"{system_ini}\" nicht gefunden.");
                    return;
                }

                // Inhalte zusammenf¸hren
                Console.WriteLine("Inhalte werden zusammengef¸hrt...");
                using (StreamWriter writer = new StreamWriter(ausgabe))
                {
                    writer.WriteLine("[Autologon]");
                    writer.WriteLine("Benutzer=" + username);
                    writer.WriteLine("Passwort=7b3XshGnPqhCxg89EiCE");
                    writer.Write(File.ReadAllText(system_ini));
                }

                // Erfolgsmeldung ausgeben
                if (File.Exists(ausgabe))
                {
                    Console.WriteLine($"Die Dateien wurden erfolgreich zusammengef¸hrt in \"{ausgabe}\".");
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

            Environment.Exit(0);
        }

        private void button_test_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}