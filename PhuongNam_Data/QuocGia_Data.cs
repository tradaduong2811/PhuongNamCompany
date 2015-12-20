using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Data
{
    public class QuocGia_Data
    {
        private DataConfig dc;
        public QuocGia_Data ()
        {
            dc = new DataConfig();
        }

        public DataTable displayCountry()
        {
            DataTable Countries = new DataTable();
            string strSQL;
            strSQL = "Select * From QuocGia"; // Chuỗi SQL
            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, dc.con);
            da_header.Fill(Countries);
            return Countries; // trả ra dữ liệu tương ứng với DataTable
        }
    }
}
