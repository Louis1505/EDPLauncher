using System.Diagnostics;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Security.Principal;
using Microsoft.VisualBasic.ApplicationServices;
using System.DirectoryServices.AccountManagement;

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
            using (var context = new PrincipalContext(ContextType.Domain))
            {
                UserPrincipal user = UserPrincipal.Current;
                string email = user.EmailAddress;
            }
            username = FormatUsername(email);
            label_user.Text = "Es meldet sich an: " + username;
        }
        
        string ausgabe = @"C:\EDP\ELP\ELP.ini";
        string standard = @"C:\EDP\EDPLauncher\Konfiguration\ELP_Backup.ini";
        string edpExe = @"C:\EDP\ELP\ELP.exe";
        string email;
        string username;

    static string FormatUsername(string email)
        {
            // E-Mail Adresse in den Teil vor @ trennen
            string localPart = email.Split('@')[0];

            // Benutzername in Vorname und Nachname aufteilen
            string[] parts = localPart.Split('.');
            if (parts.Length != 2)
            {
                throw new ArgumentException("Der Benutzername muss im Format 'vorname.nachname' sein.");
            }

            string firstName = parts[0];
            string lastName = parts[1];

            // Erster Buchstabe des Vornamens + Nachname
            string newUsername = firstName[0] + lastName;

            return newUsername;
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
                // Überprüfen, ob die Dateien existieren
                

                if (!File.Exists(system_ini))
                {
                    Console.WriteLine($"Fehler: Datei \"{system_ini}\" nicht gefunden.");
                    return;
                }

                // Inhalte zusammenführen
                Console.WriteLine("Inhalte werden zusammengeführt...");
                using (StreamWriter writer = new StreamWriter(ausgabe))
                {
                    writer.WriteLine("[Autologon]");
                    writer.WriteLine("Benutzer="+username);
                    writer.WriteLine("Passwort=7b3XshGnPqhCxg89EiCE");
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