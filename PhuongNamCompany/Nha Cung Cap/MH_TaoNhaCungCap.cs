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
    public partial class MH_TaoNhaCungCap : Form
    {
        public MH_TaoNhaCungCap()
        {
            InitializeComponent();
        }
        public static string VendorIdTransition = string.Empty;
        public static string VendorNameTransition = string.Empty;

        VendorsController VendorsController = new VendorsController();

        private void SBtnLamMoi_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn có muốn tạo lại nhà cung cấp không?",
                                              "Tạo lại?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                              MessageBoxDefaultButton.Button2);
            if (dialogresult == DialogResult.OK)
            {
                MH_TaoNhaCungCap NewTaoNhaCungCap = new MH_TaoNhaCungCap();
                this.Hide();
                NewTaoNhaCungCap.Show();
                this.Close();
                // tạo lại nhà cung cấp
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            {
                if (checkVendor() == true)
                {
                    if (createVendor() == true)
                    {
                        MessageBox.Show("Tạo nhà cung cấp thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tạo nhà cung cấp không thành công. Xin thử lại!",
                             "Cảnh báo",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning);                        
                    }
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_MaNhaCungCap.Text = VendorsController.generateVendorId().ToString();
        }

        private bool createVendor()
        {
            NhaCungCap vendor = new NhaCungCap();
            vendor.MaNCC = int.Parse(txt_MaNhaCungCap.Text);
            vendor.TenCongTy = txt_TenCongTy.Text;
            vendor.DiaChi = txt_DiaChi.Text;
            vendor.SDT = txt_SDT.Text;
            vendor.NguoiDaiDien = txt_NguoiDaiDien.Text;
            vendor.MaSoThue = txt_MaSoThue.Text;
            vendor.TKNganHang = txt_TaiKhoanNganHang.Text;
            return VendorsController.insertVendor(vendor);
        }
        private bool checkVendor()
        {
            if (txt_MaNhaCungCap.Text == "" || txt_TenCongTy.Text == "" || txt_DiaChi.Text == "" || txt_SDT.Text == "" || txt_NguoiDaiDien.Text == "" || txt_MaSoThue.Text == "" || txt_TaiKhoanNganHang.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cho Nhà Cung Cấp",
                     "Cảnh báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
