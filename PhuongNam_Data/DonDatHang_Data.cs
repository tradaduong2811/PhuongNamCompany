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
            DataTable PurOrders = new DataTable();
            string strSQL;

            strSQL = "select ddh.MaDDH, ncc.TenCongTy, ncc.DiaChi, ddh.NgayGiao, ncc.NguoiDaiDien, ddh.TongTien, ddh.TongTienVAT, ddh.XacNhan, ncc.SDT " +
                        " from DonDatHang ddh, NhaCungCap ncc " +
                        " where ncc.MaNhaCungCap = ddh.NhaCungCap";
            

            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, dc.con);
            da_header.Fill(PurOrders);
            return PurOrders; // trả ra dữ liệu tương ứng với DataTable
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

        public int removePurchaseOrder(string id)
        {
            DataTable tbApprove = new DataTable();
            int OrderId;
            int.TryParse(id, out OrderId);

            // kiểm tra đơn đặt hàng đã được xác nhận chưa?
            string checkSQL = "SELECT XacNhan From DonDatHang WHERE MaDDH = " + OrderId + " and XacNhan = 'False'";
            SqlDataAdapter da_header = new SqlDataAdapter(checkSQL, dc.con);
            da_header.Fill(tbApprove);
            if (tbApprove.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                string strSQL = "DELELE From DonDatHang WHERE MaDDH = @IdDDH" +
                       " DELETE From ChiTietDonHang Where MaDDH = @IdDDH";
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
                    return 1;
                }
                catch (SqlException e)
                {
                    return -1;
                }
            }
        }



        public DataTable displayPurchaseOrder(string id)
        {
            int PurOrderId = int.Parse(id);
            DataTable PurOrders = new DataTable();
            string strSQL;

            strSQL = "select ddh.MaDDH, ncc.MaNhaCungCap, ncc.TenCongTy, ncc.DiaChi, ddh.NgayGiao, ncc.NguoiDaiDien, ddh.TongTien, ddh.TongTienVAT, ddh.XacNhan, ncc.SDT " +
                        " from DonDatHang ddh, NhaCungCap ncc " +
                        " where ncc.MaNhaCungCap = ddh.NhaCungCap and ddh.MaDDH = " + PurOrderId;


            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, dc.con);
            da_header.Fill(PurOrders);
            return PurOrders; // trả ra dữ liệu tương ứng với DataTab
        }
    }
}
