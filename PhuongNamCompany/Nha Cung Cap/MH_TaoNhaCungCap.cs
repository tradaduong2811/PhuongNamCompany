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
            try
            {
                VendorsController.insertVendor(txt_MaNhaCungCap.Text, txt_TenCongTy.Text, txt_DiaChi.Text, txt_SDT.Text, txt_NguoiDaiDien.Text, txt_MaSoThue.Text, txt_TaiKhoanNganHang.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin cần nhập.");
            }
            MessageBox.Show("Tạo Nhà Cung Cấp thành công.");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_MaNhaCungCap.Text = VendorsController.generateVendorId().ToString();
        }

    }
}
