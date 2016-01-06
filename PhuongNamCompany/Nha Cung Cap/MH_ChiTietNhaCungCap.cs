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
    public partial class MH_ChiTietNhaCungCap : Form
    {
        public MH_ChiTietNhaCungCap()
        {
            InitializeComponent();
        }

        private void btn_XemSanPham_Click(object sender, EventArgs e)
        {
            MH_XemSanPham MH_XemSanPham = new MH_XemSanPham();
            MH_XemSanPham.Show();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            MH_TaoNhaCungCap MH_TaoNhaCungCap = new MH_TaoNhaCungCap();
            MH_TaoNhaCungCap.Show();
        }

        private void SBtnChinhSua_Click(object sender, EventArgs e)
        {
            txt_MaNhaCungCap.ReadOnly = false;
            txt_DiaChi.ReadOnly = false;
            txt_MaSoThue.ReadOnly = false;
            txt_NguoiDaiDien.ReadOnly = false;
            txt_SDT.ReadOnly = false;
            txt_TaiKhoanNganHang.ReadOnly = false;
            txt_TenCongTy.ReadOnly = false;

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
