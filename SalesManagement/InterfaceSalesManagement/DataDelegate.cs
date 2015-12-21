using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSalesManagement
{
    public delegate void EventCreateItem(object sender, SalesInvoiceLineEventArgs e);

    public delegate void EventDisplayInvoice(object sender, SalesInvoice e);
    public class SalesInvoiceLineEventArgs : EventArgs
    {
        public string ItemNo { get; set; }
        public string Desc { get; set; }
        public string Quantity { get; set; }
        public string UnitPrice { get; set; }
        public string Amount { get; set; }
        public string Stock { get; set; }
    }

    public class SalesInvoice : EventArgs
    {
        public string InvoiceNo { get; set; }
    }
}
