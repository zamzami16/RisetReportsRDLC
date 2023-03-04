using System;
using System.Windows.Forms;

namespace RisetReportsRDLC {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var frm = new MainForm();
            Application.Run(frm);
        }
    }
}
