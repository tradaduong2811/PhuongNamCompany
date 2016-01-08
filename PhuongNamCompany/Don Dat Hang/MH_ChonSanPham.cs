using PhuongNam_Business;
using PhuongNam_Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PhuongNamCompany
{
    public partial class MH_ChonSanPham : Form
    {

        public event EventCreateItem EventCreatingItem = null;

        public MH_ChonSanPham()
        {
            InitializeComponent();
            initProducts();
        }

        ProductsController ProductsController = new ProductsController();


        // khởi tạo tất cả sản phẩm tương ứng nhà cung cấp
        private void initProducts()
        {
            lbNhaCungCap.Text = MH_TaoDonDatHang.VendorNameTransition;
            CBBMaSanPham.DataSource = ProductsController.displayProduct(MH_TaoDonDatHang.VendorIdTransition).ToList();
            CBBMaSanPham.DisplayMember = "MoTaThem";
            CBBMaSanPham.ValueMember = "MaSP";
        }
        private void MH_ChonSanPham_Load(object sender, EventArgs e)
        {

        }


        // Chọn sản phẩm 
        private void CBBMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            SanPham product = new SanPham();
            int ProductId = int.Parse(CBBMaSanPham.SelectedValue.ToString());
            product = ProductsController.autoset(ProductId, MH_TaoDonDatHang.VendorIdTransition);

            TBTenSanPham.Text = product.TenSP;
            TBMoTa.Text = product.MoTa;
            TBGiaTien.Text = product.DonGia.ToString();
            resetMode(true);
        }

        private void resetMode(bool mode = true)
        {
            TBTongTien.Text = "";
            BtnChon.Enabled = mode;
            tbSoLuong.Value = 0;
        }


        private void TBTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (TBGiaTien.Text != "")
            {
                TBTongTien.Text = (decimal.Parse(TBGiaTien.Text) * tbSoLuong.Value).ToString();
            }
        }

        private void BtnChon_Click(object sender, EventArgs e)
        {

            // chuyển dữ liệu sang MH_TaoDonDatHang
            if (CBBMaSanPham.Text == "")
                MessageBox.Show("Xin chọn sản phẩm.");
            else
            {
                if (tbSoLuong.Value != 0)
                {
                    if (EventCreatingItem != null)
                    {
                        EventCreatingItem(this, new PurchaseLineLineEventArgs
                        {
                            MaSP = CBBMaSanPham.SelectedValue.ToString(),
                            MoTa = TBMoTa.Text,
                            GiaTien = TBGiaTien.Text,
                            SoLuong = tbSoLuong.Value.ToString(),
                            TenSP = TBTenSanPham.Text,
                            TongTien = TBTongTien.Text,
                        });
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xin nhập số lượng sản phẩm.");
                }
            }
            
        }
    }
}
