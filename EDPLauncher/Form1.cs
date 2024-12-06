using System.Diagnostics;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Security.Principal;
using Microsoft.VisualBasic.ApplicationServices;
using System.DirectoryServices.AccountManagement;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Text;
using System.Runtime.InteropServices;

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
            comboBox1.BackColor = ColorTranslator.FromHtml("#535353");
            comboBox1.ForeColor = ColorTranslator.FromHtml("#ffffff");
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.DrawItem += new DrawItemEventHandler(comboBox1_DrawItem);
            comboBox1.DropDown += new EventHandler(comboBox1_DropDown);
            button_not.BackColor = ColorTranslator.FromHtml("#535353");
            button_not.ForeColor = ColorTranslator.FromHtml("#ffffff");
            comboBox1.Text = "Lokale Lage";

            string fullName = Environment.UserName;
            username = FormatUsername(fullName);

            label_user.Text = "Es wird eingeloggt: " + username;

        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Konstanten für die Nachrichten
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;



        string ausgabe = @"C:\EDP\ELP\ELP.ini";
        // string standard = @"C:\EDP\EDPLauncher\Konfiguration\ELP_Backup.ini";
        string edpExe = @"C:\EDP\ELP\ELP.exe";

        // Choose right path for PCName

        string username;
        string fullName;
        string lageini = @"C:\EDP\EDPLauncher\Konfiguration\lage.ini";
        string lokalini = @"C:\EDP\EDPLauncher\Konfiguration\lokal.ini";

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ComboBox comboBox = (ComboBox)sender;
            string text = comboBox.Items[e.Index].ToString();
            e.DrawBackground();

            using (SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#535353")))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            using (SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#ffffff")))
            {
                e.Graphics.DrawString(text, e.Font, brush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            comboBox.BackColor = ColorTranslator.FromHtml("#535353");
            comboBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        static string FormatUsername(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                throw new ArgumentException("Der Name darf nicht leer sein.");
            }

            fullName = ReplaceUmlauts(fullName);
            // Den ersten Großbuchstaben nach dem Vornamen finden
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
            return char.ToLower(firstName[0]) + lastName.ToLower() + "*";
        }

        static string ReplaceUmlauts(string input)
        {
            return input.Replace("ä", "ae")
                        .Replace("ö", "oe")
                        .Replace("ü", "ue")
                        .Replace("Ä", "Ae")
                        .Replace("Ö", "Oe")
                        .Replace("Ü", "Ue");
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
            string anordnung = comboBox1.Text;
            if (comboBox1.Text == "Lokale Lage")
            {
                anordnung = lokalini;
            }
            else
            {
                anordnung = lageini;
            }
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
                using (StreamWriter writer = new StreamWriter(ausgabe, false, new UTF8Encoding(false)))
                {
                    writer.WriteLine("[Autologon]");
                    writer.WriteLine("Benutzer=" + username);
                    writer.WriteLine("Passwort=7b3XshGnPqhCxg89EiCE");
                    writer.Write(File.ReadAllText(anordnung));
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

            /* STANDARD INI ERZEUGEN nach 25 Sekunden Wartezeit
            Thread.Sleep(25000);
            Console.WriteLine("Standard INI wird erstellt...");
            using (StreamWriter writer = new StreamWriter(ausgabe))
            {
                writer.Write(File.ReadAllText(standard));
            }*/

            Environment.Exit(0);
        }

        private void button_test_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}