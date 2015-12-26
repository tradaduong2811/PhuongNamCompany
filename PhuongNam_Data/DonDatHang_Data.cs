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

            strSQL = "select ddh.MaDDH, ncc.TenCongTy, ncc.DiaChi, ddh.NgayGiao, ncc.NguoiDaiDien, ddh.TongTien, ddh.TongTienVAT " +
                        " from DonDatHang ddh, NhaCungCap ncc " +
                        " where ncc.MaNhaCungCap = ddh.NhaCungCap";
            

            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, dc.con);
            da_header.Fill(Vendors);
            return Vendors; // trả ra dữ liệu tương ứng với DataTable
        }
    }
}
