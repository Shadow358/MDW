using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRouletteClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StartForm startForm = new StartForm();
            if (startForm.ShowDialog() == DialogResult.OK)
            {
                startForm._portalClient.Close();
                Application.Run(new PortalForm(startForm.currentUser));
            }
            else
            {
                Application.Exit();
            }
            //Application.Run(new PortalForm());
        }
    }
}
