using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessSalesManagement
{
    public class CustomerDTO
    {
        private int _No;

        public int No
        {
            get { return _No; }
            set { _No = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        private DateTime _BirthDate;

        public DateTime BirthDate
        {
            get { return _BirthDate; }
            set { _BirthDate = value; }
        }

        private string _IDCard;

        public string IDCard
        {
            get { return _IDCard; }
            set { _IDCard = value; }
        }

        private string _PhoneNo;

        public string PhoneNo
        {
            get { return _PhoneNo; }
            set { _PhoneNo = value; }
        }

    }
}
