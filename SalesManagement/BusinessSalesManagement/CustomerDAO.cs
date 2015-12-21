using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessSalesManagement;
using System.Data;

namespace BusinessSalesManagement
{
    public class CustomerDAO
    {
        public DataAccess dtaccess = new DataAccess();

        public List<CustomerDTO> getListCustomer()
        {
            List<CustomerDTO> ListCustomer = new List<CustomerDTO>();
            DataTable CustomerTable = new DataTable();
            CustomerTable = dtaccess.displayCustomer(); // lấy customer từ database
            foreach (DataRow dr in CustomerTable.Rows)
            {
                CustomerDTO cust = new CustomerDTO();
                cust.No = (int)dr["No"];
                cust.Name = dr["Name"].ToString();
                cust.IDCard = dr["IDCard"].ToString();
                ListCustomer.Add(cust);
            }
            return ListCustomer.ToList();
        }        
        
    }
}
