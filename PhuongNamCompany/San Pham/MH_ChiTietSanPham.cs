using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhuongNam_Business.Models;

namespace PhuongNamCompany
{
    public partial class MH_ChiTietSanPham : Form
    {
        
        public MH_ChiTietSanPham()
        {
            InitializeComponent();
            loadFromMHDS();
            toggleEditMode(false);
        }

        private void loadFromMHDS()
        {
            txt_MaSanPham.Text = MH_DanhSachSanPham.stProduct.MaSP.ToString();
            txt_TenSanPham.Text = MH_DanhSachSanPham.stProduct.TenSP.ToString();
            txt_MoTa.Text = MH_DanhSachSanPham.stProduct.MoTa.ToString();
            txt_TrongLuong.Text = MH_DanhSachSanPham.stProduct.TrongLuong.ToString();
            txt_DonGia.Text = MH_DanhSachSanPham.stProduct.DonGia.ToString();
            cbb_LoaiHang.Text = MH_DanhSachSanPham.stProduct.LoaiSP.ToString();
            cbb_HangSX.Text = MH_DanhSachSanPham.stProduct.HangSX.ToString();
            cbb_HeDieuHanh.Text = MH_DanhSachSanPham.stProduct.HeDieuHanh.ToString();
            cbb_XuatXu.Text = MH_DanhSachSanPham.stProduct.XuatXu.ToString();

        }

        private void toggleEditMode(bool mode = false)
        {
            
            txt_MaSanPham.ReadOnly = !mode;
            txt_TenSanPham.ReadOnly = !mode;
            txt_MoTa.ReadOnly = !mode;
            txt_TrongLuong.ReadOnly = !mode;
            txt_DonGia.ReadOnly = !mode;
            cbb_LoaiHang.Enabled = mode;
            cbb_HangSX.Enabled = mode;
            cbb_HeDieuHanh.Enabled = mode;
            cbb_XuatXu.Enabled = mode;
            btn_CapNhat.Enabled = mode;

        }

        private void SBtnChinhSua_Click(object sender, EventArgs e)
        {
            toggleEditMode(true);  
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

        }

    }
}
