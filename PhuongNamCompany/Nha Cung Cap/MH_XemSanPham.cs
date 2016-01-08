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
            if (MH_DanhSachNhaCungCap.VendorIdTransition == null)
            {
                MessageBox.Show("Lỗi lấy dữ liệu");
            }
            else
            {
                loadVendors(MH_DanhSachNhaCungCap.VendorIdTransition);
            }
            NhaCungCap_Data sanpham = new NhaCungCap_Data();
            dataGridView1.DataSource = sanpham.displayProduct(MH_DanhSachNhaCungCap.VendorIdTransition);
            dataGridView1.Columns[0].HeaderText = "Mã Sản Phẩm";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Tên Sản Phẩm";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Hãng Sản Xuất";
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].HeaderText = "Giá";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].HeaderText = "Số Lượng";
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].HeaderText = "Ngày";
            dataGridView1.Columns[5].Width = 100;
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
