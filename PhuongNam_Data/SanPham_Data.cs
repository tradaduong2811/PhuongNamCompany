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
            strSQL = " SELECT sp.MaSP, sp.TenSP, hsx.TenHSX, lsp.Ten, sp.DonGia, ISNULL(sp.MoTa, 'Không') as [MoTa], hdh.HeDieuHanh, ISNULL (sp.TrongLuong, '0') as [TrongLuong], sp.TGBaoHanh, ISNULL(sp.KichThuoc, 'Không') as [KichThuoc], sp.XuatXu, sp.Xoa " +
                " FROM SanPham sp, LoaiSanPham lsp, HangSanXuat hsx, HeDieuHanh hdh " +
                " WHERE sp.HangSX = hsx.MaHSX AND sp.LoaiSP = lsp.MaLoaiSP AND sp.HeDieuHanh = hdh.MaHDH AND sp.Xoa = 'False' ";

            SqlDataAdapter adapter = new SqlDataAdapter(strSQL, dc.con);
            adapter.Fill(dtProducts);
            return dtProducts;
        }
<<<<<<< HEAD
        public int removeProduct(string id)
        {
            int OrderId = 0;
            int.TryParse(id, out OrderId);
            string strSQL = "UPDATE SanPham " +
                    " SET Xoa = 'True' " +
                    " WHERE MaSP = @IDSP";
           // OrderId = 10;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.con;
            if (dc.con.State == ConnectionState.Closed)
                dc.con.Open(); // mở kết nối
            cmd.Parameters.AddWithValue("@IDSP", OrderId);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQL;
            try
            {
                cmd.ExecuteNonQuery();
           
            }
            catch (SqlException)
            {
                return 0;
            }
            return 1;
        }
=======
>>>>>>> origin/master
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
