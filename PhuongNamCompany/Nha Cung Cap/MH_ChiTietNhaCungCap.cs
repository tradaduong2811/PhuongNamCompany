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
using PhuongNam_Business.Controller;

namespace PhuongNamCompany
{
    public partial class MH_ChiTietNhaCungCap : Form
    {
        public MH_ChiTietNhaCungCap()
        {
            InitializeComponent();
        }

        MH_DanhSachNhaCungCap DanhSachNhaCungCap = new MH_DanhSachNhaCungCap();

        VendorsController VendorsController = new VendorsController();

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

        private void loadVendors(string id)
        {
            NhaCungCap vendor = new NhaCungCap();
            vendor = VendorsController.displayVendors(id);
            if (vendor != null)
            {
                txt_MaNhaCungCap.Text = vendor.MaNCC.ToString();
                txt_TenCongTy.Text = vendor.TenCongTy.ToString();
                txt_SDT.Text = vendor.SDT;
                txt_DiaChi.Text = vendor.DiaChi.ToString();
                txt_NguoiDaiDien.Text = vendor.NguoiDaiDien;
                txt_MaSoThue.Text = vendor.MaSoThue;
                txt_TaiKhoanNganHang.Text = vendor.TKNganHang;
            }
        }


        private void MH_ChiTietNhaCungCap_Load(object sender, EventArgs e)
        {
            if (MH_DanhSachNhaCungCap.OrderIdTransition == null)
            {
                MessageBox.Show("Lỗi lấy dữ liệu");
            }
            else
            {
                loadVendors(MH_DanhSachNhaCungCap.OrderIdTransition);
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
