using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Data
{
    public class DonDatHang_Data
    {
        private DataConfig dc;
        public DonDatHang_Data()
        {
            dc = new DataConfig();
        }


        /// <summary>
        /// Danh sách đơn đặt hàng
        /// </summary>
        /// <returns></returns>
        public DataTable displayPurchaseOrders()
        {
            DataTable Vendors = new DataTable();
            string strSQL;

            strSQL = "select ddh.MaDDH, ncc.TenCongTy, ncc.DiaChi, ddh.NgayGiao, ncc.NguoiDaiDien, ddh.TongTien, ddh.TongTienVAT, ddh.XacNhan " +
                        " from DonDatHang ddh, NhaCungCap ncc " +
                        " where ncc.MaNhaCungCap = ddh.NhaCungCap";
            

            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, dc.con);
            da_header.Fill(Vendors);
            return Vendors; // trả ra dữ liệu tương ứng với DataTable
        }


        public bool approvePurchaseOrder(string id)
        {
            string strSQL;
            int OrderId;
            int.TryParse(id, out OrderId);

            strSQL = "UPDATE DonDatHang " +
                     "SET XacNhan = 'True' " +
                     "WHERE MaDDH = @IdDDH and XacNhan = 'False'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.con;
            if (dc.con.State == ConnectionState.Closed)
                dc.con.Open(); // mở kết nối
            cmd.Parameters.AddWithValue("@IdDDH", OrderId);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQL;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return false;
            }
            return true;
        }

        public int removePurchaseOrder(string id, string approve)
        {
            string strSQL;
            int OrderId;
            int.TryParse(id, out OrderId);
            bool checkApprove = bool.Parse(approve);

            strSQL = "UPDATE DonDatHang " +
                     "SET XacNhan = 'True' " +
                     "WHERE MaDDH = @IdDDH and XacNhan = 'False'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.con;
            if (dc.con.State == ConnectionState.Closed)
                dc.con.Open(); // mở kết nối
            cmd.Parameters.AddWithValue("@IdDDH", OrderId);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQL;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return 1;
            }
            return 2;
        }
    }
}
