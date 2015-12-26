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
    public partial class MH_DSDonDatHang : Form
    {
        public MH_DSDonDatHang()
        {
            InitializeComponent();
        }

        private void SBtnThemMoi_Click(object sender, EventArgs e)
        {
            MH_TaoDonDatHang MH_TaoDonDatHang = new MH_TaoDonDatHang();
            MH_TaoDonDatHang.Show();
        }

        private void SBtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn có muốn xóa đơn hàng " + "Mã đơn hàng" + "không?",
                                               "Xóa?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                               MessageBoxDefaultButton.Button2);
            if (dialogresult == DialogResult.OK)
            {
                MessageBox.Show("Đã xóa.");
                // cập nhật lại đơn hàng
            }
        }

        private void SBtnChinhSua_Click(object sender, EventArgs e)
        {
            MH_ChiTietDonDatHang MH_ChinhSua = new MH_ChiTietDonDatHang();
            MH_ChinhSua.Show();
        }

        private void SBtnXemChiTiet_Click(object sender, EventArgs e)
        {
            MH_ChiTietDonDatHang MH_XemChiTiet = new MH_ChiTietDonDatHang();
            MH_XemChiTiet.Show();
            // disable tất cả các fields
        }
    }
}
