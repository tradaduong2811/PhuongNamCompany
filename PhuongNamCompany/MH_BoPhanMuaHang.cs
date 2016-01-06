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
    public partial class MH_BoPhanMuaHang : Form
    {
        public MH_BoPhanMuaHang()
        {
            InitializeComponent();
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            MH_DSDonDatHang MH_DSDonDatHang = new MH_DSDonDatHang();
            MH_DSDonDatHang.Show();
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            MH_DanhSachNhaCungCap MH_DanhSachNhaCungCap = new MH_DanhSachNhaCungCap();
            MH_DanhSachNhaCungCap.Show();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            MH_DanhSachSanPham MH_DanhSachSanPham = new MH_DanhSachSanPham();
            MH_DanhSachSanPham.Show();
        }
    }
}
