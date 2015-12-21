using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceSalesManagement;
using DataAccessSalesManagement;

namespace BusinessSalesManagement
{
    public class CustomerBUS
    {
        private DataAccess customerDAO;

        public CustomerBUS()
        {
            customerDAO = new DataAccess();
        }

    }
}
