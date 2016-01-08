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

            strSQL = "select ddh.MaDDH, ncc.TenCongTy, ncc.DiaChi, ddh.NgayGiao, ncc.NguoiDaiDien, ddh.TongTien, ddh.MaNV, ddh.TongTienVAT, ddh.XacNhan, ncc.SDT " +
                        " from DonDatHang ddh, NhaCungCap ncc " +
                        " where ncc.MaNhaCungCap = ddh.NhaCungCap";
            

            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, dc.con);
            da_header.Fill(PurOrders);
            return PurOrders; // trả ra dữ liệu tương ứng với DataTable
        }


        public bool approvePurchaseOrder(string id, bool open)
        {
            string strSQL;
            int OrderId;
            int.TryParse(id, out OrderId);
            strSQL = "UPDATE DonDatHang " +
                     "SET XacNhan = @Open " + 
                     " WHERE MaDDH = @IdDDH";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.con;
            if (dc.con.State == ConnectionState.Closed)
                dc.con.Open(); // mở kết nối
            cmd.Parameters.AddWithValue("@Open", open);
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
                string strSQL = "Delete From DonDatHang WHERE MaDDH = @IdDDH " +
                                "Delete From ChiTietDonHang WHERE MaDonDatHang = @IdDDH"; 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = dc.con;
                if (dc.con.State == ConnectionState.Closed)
                    dc.con.Open(); // mở kết nối
                cmd.Parameters.AddWithValue("@IdDDH", OrderId);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();
                return 1;
            }
        }



        public DataTable displayPurchaseOrder(string id)
        {
            int PurOrderId = int.Parse(id);
            DataTable PurOrders = new DataTable();
            string strSQL;

            strSQL = "select ddh.MaDDH, ncc.MaNhaCungCap, ncc.TenCongTy, ncc.DiaChi, ddh.NgayGiao, ncc.NguoiDaiDien, ddh.TongTien, ddh.TongTienVAT, ddh.XacNhan, ncc.SDT, ddh.MaNV " +
                        " from DonDatHang ddh, NhaCungCap ncc " +
                        " where ncc.MaNhaCungCap = ddh.NhaCungCap and ddh.MaDDH = " + PurOrderId;


            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, dc.con);
            da_header.Fill(PurOrders);
            return PurOrders; // trả ra dữ liệu tương ứng với DataTab
        }

        public DataTable displayOrderLines(string id)
        {
            int PurOrderId = int.Parse(id);
            DataTable PurOrderLines = new DataTable();
            string strSQL;

            strSQL =    "select * " +
                        " from DonDatHang ddh, ChiTietDonHang ct, SanPham sp " +
                        " where ddh.MaDDH = ct.MaDonDatHang " +
                        " and sp.MaSP = ct.MaSP " +
                        " and ct.MaDonDatHang = " + PurOrderId;


            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, dc.con);
            da_header.Fill(PurOrderLines);
            return PurOrderLines; // trả ra dữ liệu tương ứng với DataTabe
        }

        public int getLastPurchaseOrderId()
        {

            string strSQL = "SELECT TOP 1 MaDDH FROM DonDatHang " + 
                            " order by MaDDH desc";
            DataTable PurOrders = new DataTable();
            int LastId = 0;
            SqlDataAdapter LastSQL = new SqlDataAdapter(strSQL, dc.con);
            LastSQL.Fill(PurOrders);
            foreach (DataRow dr in PurOrders.Rows)
            {
                LastId = (int)dr["MaDDH"];
            }
            return LastId;
        }


        public bool createPurchaseOrder(int _MaNV, int _MaNCC, DateTime _NgayGiao, decimal _TongTien, decimal _TongTienVAT)
        {
            bool result = false;
            if (dc.con.State == ConnectionState.Closed)
                dc.con.Open(); // mở kết nối
            string strSQL;
            strSQL = "Insert into DonDatHang(NhaCungCap, NgayGiao, MaNV, TongTien, TongTienVAT, XacNhan) Values(@NhaNCC, @NgayGiao, @MaNV, @TongTien, @TongTienVAT, 'False')";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.con;
            cmd.Parameters.Add(new SqlParameter("@NhaNCC", _MaNCC));
            cmd.Parameters.Add(new SqlParameter("@NgayGiao", _NgayGiao));
            cmd.Parameters.Add(new SqlParameter("@MaNV", _MaNV));
            cmd.Parameters.Add(new SqlParameter("@TongTien", _TongTien));
            cmd.Parameters.Add(new SqlParameter("@TongTienVAT", _TongTienVAT));
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQL;
            try
            {
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
                return result;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool createPurchaseLines(int _MaDDH, int _MaSP, decimal _Gia, int _SoLuongDat, decimal _ThanhTien)
        {
            bool result = false;
            if (dc.con.State == ConnectionState.Closed)
                dc.con.Open(); // mở kết nối
            string strSQL;
            strSQL = "Insert into ChiTietDonHang(MaDonDatHang, MaSP, Gia, SoLuongDat, ThanhTien) Values(@MaDDH, @MaSP, @Gia, @SoLuongDat, @ThanhTien)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.con;
            cmd.Parameters.Add(new SqlParameter("@MaDDH", _MaDDH));
            cmd.Parameters.Add(new SqlParameter("@MaSP", _MaSP));
            cmd.Parameters.Add(new SqlParameter("@Gia", _Gia));
            cmd.Parameters.Add(new SqlParameter("@ThanhTien", _ThanhTien));
            cmd.Parameters.Add(new SqlParameter("@SoLuongDat", _SoLuongDat));
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQL;
            try
            {
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
                return result;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
