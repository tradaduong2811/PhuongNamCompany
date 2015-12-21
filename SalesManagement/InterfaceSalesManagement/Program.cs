using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceSalesManagement
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
            Application.Run(new InvoiceForm()); // run Invoice Form
            //Application.Run(new InvoiceCard()); // run Invoice Card form
            //Application.Run(new SalesInvoiceLineCard()); // run sales Invoice Line Form
            
            
        }
    }
}
