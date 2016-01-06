using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataAccessSalesManagement
{
    public class DataAccess
    {
        private SqlConnection con; //khai báo biến connect
        public string strConnect = @"Data Source=.\ ;Initial Catalog=SALES_MANAGEMENT;Integrated Security=True;Database=SALE_MANAGEMENT"; //chuỗi kết nối

        //khởi tạo mặc định
        public DataAccess()
        {
            Connect();
        }

        //hàm kết nối csdl
        private void Connect()
        {
            con = new SqlConnection(strConnect); //khởi tạo connect
            con.Open(); //mở kết nối
            if (con.State == ConnectionState.Open) //nếu kết nối đang mở thì đóng lại
                con.Close(); //đóng kết nối
        }
        //hàm displayInvoiceHeader
        public DataTable displayListOfInvoiceHeader()
        {
            DataTable InvoiceHeader = new DataTable();
            string strSQL;
            strSQL = "Select * From SalesInvoiceHeader";
            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, con);
            da_header.Fill(InvoiceHeader);
            return InvoiceHeader;
        }

        //hàm displayInvoiceLines
        // --- LH ---
        // hàm này sai vì không biết display InvoiceLines của SalesHeader nào
        // ==> link SalesInvoiceHeader với SalesInvoiceLines
        public DataTable displayInvoiceLines(int InvoiceNo, int CustNo)
        {
            DataTable InvoiceLines = new DataTable();
            string strSQL;
            strSQL = "select * from SalesInvoiceHeader,SalesInvoiceLine where SalesInvoiceLine.InvoiceNo = SalesInvoiceHeader.InvoiceNo and SalesInvoiceLine.InvoiceNo = '" + InvoiceNo + "' and CustNo = '" + CustNo + "' ";
            SqlDataAdapter da_lines = new SqlDataAdapter(strSQL, con);
            da_lines.Fill(InvoiceLines);
            return InvoiceLines;
        }

        public DataTable displayInvoiceLinesWithInvoiceNo(int InvoiceNo)
        {
            DataTable InvoiceLines = new DataTable();
            string strSQL;
            strSQL = "SELECT Item.ItemNo, Quantity, Item.UnitPrice, Amount, Description " +
                     "FROM SalesInvoiceLine, Item " +
                     "WHERE SalesInvoiceLine.InvoiceNo = " + InvoiceNo +
                     " and SalesInvoiceLine.ItemNo = Item.ItemNo";
            SqlDataAdapter da_lines = new SqlDataAdapter(strSQL, con);
            da_lines.Fill(InvoiceLines);
            return InvoiceLines;
        }

    

        //hàm displayInvoice
        // --- LH ---
        // hàm này bị sai. Vì chưa link đến Customer nào.
        // ==> link Customer với SalesInvoiceHeader
        public DataTable displayInvoiceWithIdCard()
        {
            DataTable Invoice = new DataTable();
            string strSQL;
            strSQL = "Select InvoiceNo,Name,CustId,TotalAmount, TotalAmountVAT From SalesInvoiceHeader,Customer Where CustId = IDCard";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
            da.Fill(Invoice);
            return Invoice;
        }

        //hàm displayCustomer
        public DataTable displayCustomer()
        {
            DataTable Customer = new DataTable();
            string strSQL;
            strSQL = "Select * From Customer";
            SqlDataAdapter da_cust = new SqlDataAdapter(strSQL, con);
            da_cust.Fill(Customer);
            return Customer;
        }

        // --- LH ---
        // 04-10-2015
        // display Customer theo Tên và CMND

        //hàm displayItemDesc
        public DataTable displayItemDesc()
        {
            DataTable InvoiceLines = new DataTable();
            string strSQL;
            strSQL = "Select Description From Item";
            SqlDataAdapter da_lines = new SqlDataAdapter(strSQL, con);
            da_lines.Fill(InvoiceLines);
            return InvoiceLines;
        }

        //hàm createInvoiceHeader
        // --- LH ---
        // chỉnh lại parameter
        public bool createInvoiceHeader(int InvoiceNo, int CustNo, string CustId, decimal TotalAmount, decimal TotalAmountVAT)
        {
            bool result = false;
            if (con.State == ConnectionState.Closed)
                con.Open(); // mở kết nối
            string strSQL;
            strSQL = "Insert into SalesInvoiceHeader(CustNo,CustId,TotalAmount,TotalAmountVAT) Values(@CustNo, @CustId, @TotalAmount, @TotalAmountVAT) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@CustNo", CustNo));
            cmd.Parameters.Add(new SqlParameter("@CustId", CustId));
            cmd.Parameters.Add(new SqlParameter("@TotalAmount", TotalAmount));
            cmd.Parameters.Add(new SqlParameter("@TotalAmountVAT", TotalAmountVAT));
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQL;
            result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            return result;
        }
        public DataTable displayInvoiceWithInvoiceNo(int No)
        {
            DataTable Invoice = new DataTable();
            string strSQL;
            strSQL = "SELECT InvoiceNo, CustNo, CustId, Name, TotalAmount, TotalAmountVAT " +
                     "from SalesInvoiceHeader, Customer " +
                     "where SalesInvoiceHeader.InvoiceNo = " + No +
                     " and Customer.No = SalesInvoiceHeader.CustNo";
            SqlDataAdapter da_lines = new SqlDataAdapter(strSQL, con);
            da_lines.Fill(Invoice);
            return Invoice;
        }
        //hàm createInvoiceLine
        // --- LH ---
        // chỉnh lại parameter khi insert
        public bool createInvoiceLines(int InvoiceNo, int ItemNo, int Quantity, decimal Price, decimal Amount)
        {
            bool result = false;
            if (con.State == ConnectionState.Closed)
                con.Open(); // mở kết nối
            string strSQL;
            strSQL = "Insert into SalesInvoiceLine(InvoiceNo,ItemNo,Quantity,UnitPrice,Amount) Values(@InvoiceNo, @ItemNo, @Quantity, @UnitPrice, @Amount) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@InvoiceNo", InvoiceNo));
            cmd.Parameters.Add(new SqlParameter("@ItemNo", ItemNo));
            cmd.Parameters.Add(new SqlParameter("@Quantity", Quantity));
            cmd.Parameters.Add(new SqlParameter("@UnitPrice", Price));
            cmd.Parameters.Add(new SqlParameter("@Amount", Amount));
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQL;
            result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            return result;
        }

        //hàm createItem
        // --- LH ---
        // chỉnh lại dùng Parameter khi create
        public bool createItem(string Desc, double Price)
        {
            bool result = false;
            if (con.State == ConnectionState.Closed)
                con.Open(); // mở kết nối
            string strSQL;
            strSQL = "Insert into Item(Description,UnitPrice) Values(@Desc, @Price) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Desc", Desc));
            cmd.Parameters.Add(new SqlParameter("@Price", Price));
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQL;
            result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            return result;
        }

        //hàm createCustomer
        
        // --- LH ---
        // hàm này chỉnh lại dùng parameter khi create
        public bool createCustomer(int CustNo, string Name, string Address, DateTime Birthdate, string IDCard, string Phone)
        {
            bool result = false;
            if (con.State == ConnectionState.Closed)
                con.Open(); // mở kết nối
            string strSQL;
            strSQL = "Insert into Customer(No,Name,Address,BirthDate,IDCard,PhoneNo) Values(@No, @Name, @Address, @BirthDate, @IDCard, @PhoneNo)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@No", CustNo));
            cmd.Parameters.Add(new SqlParameter("@Name", Name));
            cmd.Parameters.Add(new SqlParameter("@Address", Address));
            cmd.Parameters.Add(new SqlParameter("@BrithDate", Birthdate));
            cmd.Parameters.Add(new SqlParameter("@IDCard", IDCard));
            cmd.Parameters.Add(new SqlParameter("@PhoneNo", Phone));
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQL;
            result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            return result;
        }

        //hàm deleteInvoice
        // --- LH ---
        // 1. Khi muốn xóa một Invoice thì phải xóa tất cả InvoiceSalesLines 
        //tương ứng với SalesInvoiceHeader trước rồi mới xóa InvoiceSalesHeader.
        // 2. Chỉnh lại add parameter khi xóa.
        // 3. Hàm xóa này bị sai logic, vì trong Customer không có InvoiceNo
        public bool deleteInvoice(int InvoiceNo)
        {
            bool result = false;
            if (con.State == ConnectionState.Closed)
                con.Open(); // mở kết nối
            string strSQL;
            strSQL = "Delete From SalesInvoiceLine Where InvoiceNo = @InvoiceNo " + 
                     "Delete From SalesInvoiceHeader Where InvoiceNo = @InvoiceNo";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@InvoiceNo", InvoiceNo));
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQL;
            result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            return result;
        }

        //hàm searchInvoice
        public DataTable searchInvoice(string CustIDCard)
        {
            DataTable InvoiceLines = new DataTable();
            string strSQL;

            strSQL = "Select InvoiceNo, CustNo, CustId, TotalAmount, TotalAmountVAT "+ 
                     "from SalesInvoiceHeader, Customer " +
                     "where SalesInvoiceHeader.CustNo = Customer.No " +
                     "and   Customer.IDCard LIKE '" + CustIDCard + "%'";
            SqlDataAdapter da_lines = new SqlDataAdapter(strSQL, con);
            da_lines.Fill(InvoiceLines);
            return InvoiceLines;
        }


        //hàm displayItemDesc

        //Display all items
        // --- NP ---
        public DataTable displayItem()
        {
            DataTable Item = new DataTable();
            string strSQL;
            strSQL = "Select * From Item";
            SqlDataAdapter da_lines = new SqlDataAdapter(strSQL, con);
            da_lines.Fill(Item);
            return Item;
        }

        public void updateItemStock(int ItemNo, int ItemStock)
        {
            if (con.State == ConnectionState.Closed)
                con.Open(); // mở kết nối
            string strSQL;
            strSQL = "Update Item Set Stock = @ItemStock Where ItemNo = @ItemNo";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@ItemStock", ItemStock));
            cmd.Parameters.Add(new SqlParameter("@ItemNo", ItemNo));
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();
        }
    }
}
