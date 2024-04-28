using System;
using System.Windows.Forms;

namespace Calc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable visual styles for the application
            Application.EnableVisualStyles();
            // Set compatible text rendering mode
            Application.SetCompatibleTextRenderingDefault(false);
            // Run the application and start the main form
            Application.Run(new Form1());
        }
    }
}
