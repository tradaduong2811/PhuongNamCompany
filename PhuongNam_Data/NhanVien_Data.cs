using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Data
{
    public class NhanVien_Data
    {
        private DataConfig dc;
        public NhanVien_Data()
        {
            dc = new DataConfig();
        }


        /// <summary>
        /// Danh sách nhà cung cấp
        /// </summary>
        /// <returns></returns>
        public DataTable displayEmployees()
        {
            DataTable Employees = new DataTable();
            string strSQL;
            strSQL = "Select * From NhanVien"; // Chuỗi SQL
            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, dc.con);
            da_header.Fill(Employees);
            return Employees; // trả ra dữ liệu tương ứng với DataTable
        }
    }
}
