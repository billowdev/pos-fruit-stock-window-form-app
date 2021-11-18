using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruit_Stock
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
            //Application.Run(new FrmLogin());
            //Application.Run(new FrmProfile());
            //Application.Run(new FrmInvoice());
            //Application.Run(new FrmHistoryInvoice());
            //Application.Run(new FrmStock());
            //Application.Run(new FrmHelp());
            Application.Run(new FrmMain());
        }
    }
}
