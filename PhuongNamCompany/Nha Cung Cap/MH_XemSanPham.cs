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

namespace PhuongNamCompany
{
    public partial class MH_XemSanPham : Form
    {
        public MH_XemSanPham()
        {
            InitializeComponent();
        }

        private void MH_XemSanPham_Load(object sender, EventArgs e)
        {
            SanPham_Data sanpham = new SanPham_Data();
            dataGridView1.DataSource = sanpham.displayProduct();
        }

    }
}
