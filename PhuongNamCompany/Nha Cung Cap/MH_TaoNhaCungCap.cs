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
    public partial class MH_TaoNhaCungCap : Form
    {
        public MH_TaoNhaCungCap()
        {
            InitializeComponent();
        }

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

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
