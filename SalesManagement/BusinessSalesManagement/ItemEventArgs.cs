using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessSalesManagement
{
    public class ItemEventArgs : System.EventArgs
    {
         private int _ItemNo;

        public int ItemNo
        {
            get { return _ItemNo; }
          
        }

        private string _Description;

        public string Description
        {
            get { return _Description; }
           
        }

        private string _Quantity;

        public string Quantity
        {
          get { return _Quantity; }
        
        }


        private decimal _UnitPrice;

        public decimal UnitPrice
        {
            get { return _UnitPrice; }
       
        }

        private decimal _Amount;

        public decimal Amount
        {
            get { return _Amount; }

        }

        public ItemEventArgs(int itemNo, string description, string quantity, decimal unitprice, decimal amount)
        {
            _ItemNo = itemNo;
            _Description = description;
            _Quantity = quantity;
            _UnitPrice = unitprice;
            _Amount = amount;
        }
    }
}
