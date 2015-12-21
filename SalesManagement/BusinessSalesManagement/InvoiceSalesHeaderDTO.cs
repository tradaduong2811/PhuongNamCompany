using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessSalesManagement
{
    public class InvoiceSalesHeaderDTO
    {
        private int _InvoiceNo;

        public int InvoiceNo
        {
            get { return _InvoiceNo; }
            set { _InvoiceNo = value; }
        }

        private int _CustNo;
        public int CustNo
        {
            get { return _CustNo; }
            set { _CustNo = value; }
        }

        private string _CustId;
        public string CustId
        {
            get { return _CustId; }
            set { _CustId = value; }
        }

        private decimal _TotalAmount;
        public decimal TotalAmount
        {
            get { return _TotalAmount; }
            set { _TotalAmount = value; }
        }

        private decimal _TotalAmountVAT;

        public decimal TotalAmountVAT
        {
            get { return _TotalAmountVAT; }
            set { _TotalAmountVAT = value; }
        }

        
    }
}
