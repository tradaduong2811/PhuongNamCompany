using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Data
{    
    public class DataConfig
    {
        public SqlConnection con; //khai báo biến connect
        /// <summary>
        /// Dữ liệu trong thư mục bin\Debug
        /// </summary>
        static string strConnect = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|PhuongNamDB.mdf; Integrated Security=True";
        //khởi tạo mặc định
        public DataConfig()
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
    }
}
