using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Data
{
    public class NhaCungCap_Data
    {
        private DataConfig dc;
        public NhaCungCap_Data()
        {
            dc = new DataConfig();
        }


        /// <summary>
        /// Danh sách nhà cung cấp
        /// </summary>
        /// <returns></returns>
        public DataTable displayVendor()
        {
            DataTable Vendors = new DataTable();
            string strSQL;
            strSQL = "Select * From NhaCungCap"; // Chuỗi SQL
            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, dc.con);
            da_header.Fill(Vendors);
            return Vendors; // trả ra dữ liệu tương ứng với DataTable
        }
    }
}
