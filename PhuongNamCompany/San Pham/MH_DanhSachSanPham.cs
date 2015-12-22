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
    public partial class MH_DanhSachSanPham : Form
    {
        public MH_DanhSachSanPham()
        {
            InitializeComponent();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            MH_TaoSanPham mh_tsp = new MH_TaoSanPham();
            mh_tsp.ShowDialog();
        }

        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {
            MH_ChiTietSanPham mh_ctsp = new MH_ChiTietSanPham();
            mh_ctsp.ShowDialog();
        }

        private void btn_XemGia_Click(object sender, EventArgs e)
        {
            MH_GiaSanPham mh_gsp = new MH_GiaSanPham();
            mh_gsp.ShowDialog();
        }
    }
}
