using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessSalesManagement;
using System.Data;

namespace BusinessSalesManagement
{
    public class InvoiceSalesHeaderDAO
    {
        public DataAccess dataaccess = new DataAccess();
        public List<InvoiceSalesHeaderDTO> displayListInvoice()
        {
            List<InvoiceSalesHeaderDTO> ListInvoice = new List<InvoiceSalesHeaderDTO>();
            DataTable dt = new DataTable();
            dt = dataaccess.displayListOfInvoiceHeader();
            foreach (DataRow dr in dt.Rows)
            {
                InvoiceSalesHeaderDTO header = new InvoiceSalesHeaderDTO();
                header.CustNo = (int)dr["CustNo"];
                header.InvoiceNo = (int)dr["InvoiceNo"];
                header.CustId = (string)dr["CustId"];
                header.TotalAmount = (decimal)dr["TotalAmount"];
                header.TotalAmountVAT = (decimal)dr["TotalAmountVAT"];
                ListInvoice.Add(header);
            }
            return ListInvoice;
        }


        // --- LH ---
        // 04-10-2015
        // search Invoice and display to Datagridview
        public List<InvoiceSalesHeaderDTO> searchInvoice(string CustIdCard)
        {
            List<InvoiceSalesHeaderDTO> ListInvoice = new List<InvoiceSalesHeaderDTO>();
            DataTable dt = new DataTable();
            dt = dataaccess.searchInvoice(CustIdCard);
            foreach (DataRow dr in dt.Rows)
            {
                InvoiceSalesHeaderDTO header = new InvoiceSalesHeaderDTO();
                header.CustNo = (int)dr["CustNo"];
                header.InvoiceNo = (int)dr["InvoiceNo"];
                header.CustId = (string)dr["CustId"];
                header.TotalAmount = (decimal)dr["TotalAmount"];
                header.TotalAmountVAT = (decimal)dr["TotalAmountVAT"];
                ListInvoice.Add(header);
            }
            return ListInvoice;
        }

        // --- LH ---
        // 04-10-2015
        // delete invoice        
        public bool deleteInvoice(int InvoiceNo)
        {
            if (dataaccess.deleteInvoice(InvoiceNo) == true)
                return true;
            return false;
        }

        public int getInvoiceNo()
        {
            int InvoiceNo = (from t in displayListInvoice()
                             orderby t.InvoiceNo descending
                             select t.InvoiceNo).First();
            return InvoiceNo;
        }

        public int generateInvoiceNo()
        {
            int InvoiceNo = (from t in displayListInvoice()
                      orderby t.InvoiceNo descending
                      select t.InvoiceNo).First();
            if (InvoiceNo != null)
            {
                InvoiceNo = InvoiceNo + 10;
            }
            return InvoiceNo;
        }

        public string generateName(int CustomerNo)
        {
            CustomerDAO cust = new CustomerDAO();
            string name = (from t in cust.getListCustomer()
                           where t.No == CustomerNo
                           select t).FirstOrDefault().Name;
            return name;    
        }
        public string generateIdCard(int CustomerNo)
        {
            CustomerDAO cust = new CustomerDAO();
            string IdCard = (from t in cust.getListCustomer()
                           where t.No == CustomerNo
                           select t).FirstOrDefault().IDCard;
            return IdCard;
        }

        public void insertSalesHeader(string CustNo, string CustId, string Amount, string AmountVAT)
        {
            InvoiceSalesHeaderDTO header = new InvoiceSalesHeaderDTO();
            header.CustNo = int.Parse(CustNo);
            header.CustId = CustId;
            //header.InvoiceNo = int.Parse(TBNo.Text);
            header.TotalAmount = decimal.Parse(Amount);
            header.TotalAmountVAT = decimal.Parse(AmountVAT);
            dataaccess.createInvoiceHeader(header.InvoiceNo, header.CustNo, header.CustId, 
                                     header.TotalAmount, header.TotalAmountVAT);
        }

        public DataTable displaySalesHeader(string InvoiceNo)
        {
            InvoiceSalesHeaderDTO header = new InvoiceSalesHeaderDTO();
            DataTable dt = new DataTable();
            dt = dataaccess.displayInvoiceWithInvoiceNo(int.Parse(InvoiceNo));
            return dt;
        }
    }
}
