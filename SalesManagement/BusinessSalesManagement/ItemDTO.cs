using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessSalesManagement
{
    public class ItemDTO
    {
        private int _ItemNo;

        public int ItemNo
        {
            get { return _ItemNo; }
            set { _ItemNo = value; }
        }

        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        private decimal _UnitPrice;

        public decimal UnitPrice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
        }

        private int _Stock;

        public int Stock
        {
            get { return _Stock; }
            set { _Stock = value; }
        }

       
    }
}
