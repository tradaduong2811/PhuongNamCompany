using PhuongNam_Business.Models;
using PhuongNam_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Business
{
    public class ProductsController
    {
        public SanPham_Data data = new SanPham_Data();
        public List<SanPham> displayProduct()
        {
            List<SanPham> listProducts = new List<SanPham>();
            DataTable dt = new DataTable();
            dt = data.displayProduct();
            foreach (DataRow dr in dt.Rows)
            {
                SanPham product = new SanPham();
                product.MaSP = (int)dr["MaSP"];
                product.TenSP = (string)dr["TenSP"];
                product.XuatXu = (string)dr["XuatXu"];
            }
            return listProducts;
        }
    }
}
