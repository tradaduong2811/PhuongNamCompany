using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Data
{
    public class SanPham_Data
    {
        private DataConfig dc;
        public SanPham_Data()
        {
            dc = new DataConfig();
        }

        /// Danh sách sản phẩm

        public DataTable displayProduct()
        {
            DataTable Product = new DataTable();
            string strSQL;
            strSQL = "Select * From SanPham"; // Chuỗi SQL
            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, dc.con);
            da_header.Fill(Product);
            return Product; // trả ra dữ liệu tương ứng với DataTable
        }
    }
}
