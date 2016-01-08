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

        public DataTable displayVendors(string id)
        {
            int VendorId = int.Parse(id);
            DataTable VendorLine = new DataTable();
            string strSQL;

            strSQL = "select * " +
                        " from NhaCungCap ncc " +
                        " where ncc.MaNhaCungCap = " + VendorId;


            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, dc.con);
            da_header.Fill(VendorLine);
            return VendorLine; // trả ra dữ liệu tương ứng với DataTabe
        
        }
        public int getLastVendorId()
        {

            string strSQL = "SELECT TOP 1 MaNhaCungCap FROM NhaCungCap " +
                            " order by MaNhaCungCap desc";
            DataTable vendor = new DataTable();
            int LastId = 0;
            SqlDataAdapter LastSQL = new SqlDataAdapter(strSQL, dc.con);
            LastSQL.Fill(vendor);
            foreach (DataRow dr in vendor.Rows)
            {
                LastId = (int)dr["MaNhaCungCap"];
            }
            return LastId;
        }
        public bool createVendor(string TenCongTy, string DiaChi, string SDT, string NguoiDaiDien, string MaSoThue, string TKNganHang)
        {
            bool result = false;
            if (dc.con.State == ConnectionState.Closed)
                dc.con.Open();
            string strSQL;
            strSQL = "Insert into NhaCungCap(TenCongTy,DiaChi,SDT,NguoiDaiDien,MaSoThue,TKNganHang) Values(@TenCongTy,@DiaChi,@SDT,@NguoiDaiDien,@MaSoThue,@TKNganHang) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.con;
            cmd.Parameters.Add(new SqlParameter("@TenCongTy", TenCongTy));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
            cmd.Parameters.Add(new SqlParameter("@SDT", SDT));
            cmd.Parameters.Add(new SqlParameter("@NguoiDaiDien", NguoiDaiDien));
            cmd.Parameters.Add(new SqlParameter("@MaSoThue", MaSoThue));
            cmd.Parameters.Add(new SqlParameter("@TKNganHang", TKNganHang));
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
        public int removeVendor(string id)
        {
            DataTable tbApprove = new DataTable();
            int VendorId;
            int.TryParse(id, out VendorId);
            // kiểm tra nhà cung cấp có đơn hàng không?
            string checkSQL = "SELECT XacNhan From DonDatHang WHERE NhaCungCap = " + VendorId + "";
            SqlDataAdapter da_header = new SqlDataAdapter(checkSQL, dc.con);
            da_header.Fill(tbApprove);
            if (tbApprove.Rows.Count != 0)
            {
                return 0;
            }
            else
            {
                string strSQL = "Delete From NhaCungCap WHERE MaNhaCungCap = @IdNCC ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = dc.con;
                if (dc.con.State == ConnectionState.Closed)
                    dc.con.Open(); // mở kết nối
                cmd.Parameters.AddWithValue("@IdNCC", VendorId);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();
                return 1;
            }
        }
                     
        public DataTable displayProduct(string id)
        {
            int VendorId = int.Parse(id);
            DataTable Product = new DataTable();
            string strSQL;

            strSQL = "Select GiaSanPham.MaSP,TenSP,HangSX,Gia,SoLuong,Ngay From SanPham,GiaSanPham,NhaCungCap Where NhaCungCap.MaNhaCungCap = GiaSanPham.NhaCungCap and NhaCungCap.MaNhaCungCap = " + VendorId + " and GiaSanPham.MaSP = SanPham.MaSP";

            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, dc.con);
            da_header.Fill(Product);
            return Product; // trả ra dữ liệu tương ứng với DataTabe
        }
       
    }
    
}

