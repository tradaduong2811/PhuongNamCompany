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
            button1.Enabled = true;
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
            string VendorId = null;
            VendorId = txt_MaNhaCungCap.Text;
            DialogResult dialogresult = MessageBox.Show("Bạn có muốn xóa nhà cung cấp " + VendorId + " không?",
                                            "Xóa?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);
            if (dialogresult == DialogResult.OK)
            {
                int result = VendorsController.removeVendor(VendorId);
                if (result == 0)
                {
                    MessageBox.Show("Nhà cung cấp Mã số " + VendorId + " đã có đơn hàng. Không thể xóa.",
                    "Cảnh cáo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                if (result == 1)
                {
                    MessageBox.Show("Đã xóa Nhà Cung Cấp Mã số " + VendorId + ".");
                }
            }
            this.Close();
            
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
            if (MH_DanhSachNhaCungCap.VenderIdTransition == null)
            {
                MessageBox.Show("Lỗi lấy dữ liệu");
            }
            else
            {
                loadVendors(MH_DanhSachNhaCungCap.VenderIdTransition);
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            //DialogResult dialogresult = MessageBox.Show("Bạn muốn chỉnh sửa nhà cung cấp Mã số " + MH_DanhSachNhaCungCap.VenderIdTransition + " không?",
            //                                      "Chỉnh sửa?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
            //                                      MessageBoxDefaultButton.Button2);
            NhaCungCap nhacungcap = new NhaCungCap();
            nhacungcap.MaNCC = int.Parse(txt_MaNhaCungCap.Text);
            nhacungcap.TenCongTy = txt_TenCongTy.Text;
            nhacungcap.DiaChi = txt_DiaChi.Text;
            nhacungcap.SDT = txt_SDT.Text;
            nhacungcap.NguoiDaiDien = txt_NguoiDaiDien.Text;
            nhacungcap.MaSoThue = txt_MaSoThue.Text;
            nhacungcap.TKNganHang = txt_TaiKhoanNganHang.Text;
            string VendorId = null;
            VendorId = txt_MaNhaCungCap.Text;
            int result = VendorsController.removeVendor(VendorId);
            if (result == 0)
            {
                MessageBox.Show("Nhà cung cấp Mã số " + VendorId + " không thể chỉnh sửa.",
                "Cảnh cáo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    VendorsController.insertVendor(nhacungcap);
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại các thông tin cần nhập.");
                }
                MessageBox.Show("Chỉnh Sửa Nhà Cung Cấp thành công.");
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_MaNhaCungCap.Text = VendorsController.generateVendorId().ToString();
        }
    }
}
