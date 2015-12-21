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
    public partial class MH_TaoDonDatHang : Form
    {
        public MH_TaoDonDatHang()
        {
            InitializeComponent();
        }

        private void MH_TaoDonDatHang_Load(object sender, EventArgs e)
        {

        }

        private void SBtnLamMoi_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn có muốn tạo lại đơn hàng không?",
                                              "Tạo lại?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                              MessageBoxDefaultButton.Button2);
            if (dialogresult == DialogResult.OK)
            {
                MH_TaoDonDatHang NewTaoDonHang = new MH_TaoDonDatHang();
                this.Hide();
                NewTaoDonHang.Show();
                this.Close();
                // tạo lại đơn hàng
            }
        }

        private void SBtnSanPham_Click(object sender, EventArgs e)
        {
            MH_ChonSanPham MH_ChonSanPham = new MH_ChonSanPham();
            MH_ChonSanPham.ShowDialog();
        }
    }
}
