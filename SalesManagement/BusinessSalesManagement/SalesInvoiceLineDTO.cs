using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessSalesManagement
{
    public class SalesInvoiceLineDTO
    {
        private int _LineNo;
        public int LineNo
        {
            get { return _LineNo; }
            set { _LineNo = value; }
        }


        private int _InvoiceNo;

        public int InvoiceNo
        {
            get { return _InvoiceNo; }
            set { _InvoiceNo = value; }
        }

        private int _ItemNo;

        public int ItemNo
        {
            get { return _ItemNo; }
            set { _ItemNo = value; }
        }

        private int _Quantity;

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        private decimal _UnitPrice;

        public decimal UnitPrice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
        }

        private decimal _Amount;

        public decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
    }
}
