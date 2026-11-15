using ClinicSystem.GUI;
using System.Runtime.Intrinsics.X86;

namespace bt_15_11_6._7
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmClinic());
        }
    }
}