using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhuongNam_Data;
using PhuongNam_Business.Controller;
using PhuongNam_Business.Models;

namespace PhuongNamCompany
{
    public partial class MH_XemSanPham : Form
    {
        public MH_XemSanPham()
        {
            InitializeComponent();
        }

        VendorsController VendorsController = new VendorsController();

        private void MH_XemSanPham_Load(object sender, EventArgs e)
        {
            if (MH_DanhSachNhaCungCap.OrderIdTransition == null)
            {
                MessageBox.Show("Lỗi lấy dữ liệu");
            }
            else
            {
                loadVendors(MH_DanhSachNhaCungCap.OrderIdTransition);
            }
            NhaCungCap_Data sanpham = new NhaCungCap_Data();
            dataGridView1.DataSource = sanpham.displayProduct(MH_DanhSachNhaCungCap.OrderIdTransition);
        }
        private void loadVendors(string id)
        {
            NhaCungCap vendor = new NhaCungCap();
            vendor = VendorsController.displayVendors(id);
            if (vendor != null)
            {
                txt_TenCongTy.Text = vendor.TenCongTy;
            }
        }

    }
}
