using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessSalesManagement;
using System.Data;

namespace BusinessSalesManagement
{
    public class SalesInvoiceLineDAO
    {
        DataAccess dataacess = new DataAccess();

        public void insertSalesLine(string ItemNo, string InvoiceNo, string qty, string price, string amount)
        {
            SalesInvoiceLineDTO line = new SalesInvoiceLineDTO();
            line.InvoiceNo = int.Parse(InvoiceNo);
            line.ItemNo = int.Parse(ItemNo);
            line.Quantity = int.Parse(qty);
            line.UnitPrice = decimal.Parse(price);
            line.Amount = decimal.Parse(amount);
            dataacess.createInvoiceLines(line.InvoiceNo, line.ItemNo,
                                        line.Quantity, line.UnitPrice, line.Amount);
        }

        public DataTable displaySalesLineWithInvoiceNo(string invoiceno)
        {
            DataTable SalesLines = new DataTable();
            SalesLines = dataacess.displayInvoiceLinesWithInvoiceNo(int.Parse(invoiceno));
            return SalesLines;
        }
    }
}
