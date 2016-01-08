using System.Data;
using System.Data.SqlClient;

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
            strSQL = "Select GiaSanPham.MaSP,TenSP,HangSX,Gia,SoLuong,Ngay From SanPham,GiaSanPham,NhaCungCap Where NhaCungCap.MaNhaCungCap = GiaSanPham.NhaCungCap and NhaCungCap.MaNhaCungCap = 1 and GiaSanPham.MaSP = SanPham.MaSP"; // Chuỗi SQL
            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, dc.con);
            da_header.Fill(Product);
            return Product; // trả ra dữ liệu tương ứng với DataTable
        }

        // NAM
        public DataTable getProducts()
        {
            DataTable dtProducts = new DataTable();
            string strSQL;
            strSQL = " SELECT sp.MaSP, sp.TenSP, hsx.TenHSX, lsp.Ten, sp.DonGia, sp.MoTa, hdh.HeDieuHanh, sp.TrongLuong,  sp.TGBaoHanh, sp.KichThuoc, sp.XuatXu " +
                " FROM SanPham sp, LoaiSanPham lsp, HangSanXuat hsx, HeDieuHanh hdh " +
                " WHERE sp.HangSX = hsx.MaHSX AND sp.LoaiSP = lsp.MaLoaiSP AND sp.HeDieuHanh = hdh.MaHDH";

            SqlDataAdapter adapter = new SqlDataAdapter(strSQL, dc.con);
            adapter.Fill(dtProducts);
            return dtProducts;
        }
        public DataTable displayProduct(string VendorId)
        {
            int Id = int.Parse(VendorId);
            DataTable Product = new DataTable();
            string strSQL;
            strSQL = "Select GiaSanPham.MaSP,TenSP,HangSX,Gia,Ngay, MoTa From SanPham,GiaSanPham " +
                     "Where GiaSanPham.MaSP = SanPham.MaSP " +
                     "and GiaSanPham.NhaCungCap = " + Id;// Chuỗi SQL
            SqlDataAdapter da_header = new SqlDataAdapter(strSQL, dc.con);
            da_header.Fill(Product);
            return Product;

        }
    }
}
