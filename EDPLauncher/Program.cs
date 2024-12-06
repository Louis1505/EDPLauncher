using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using System.Windows.Forms;


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

                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            

            

        }

    }  
}
