using PhuongNam_Business;
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
    public partial class MH_ChonSanPham : Form
    {
        public MH_ChonSanPham()
        {
            InitializeComponent();
        }

        ProductsController ProductsController = new ProductsController();

        private void MH_ChonSanPham_Load(object sender, EventArgs e)
        {
            CBBMaSanPham.DataSource = ProductsController.displayProduct(MH_TaoDonDatHang.VendorIdTransition).ToList();
            CBBMaSanPham.DisplayMember = "MoTaThem";
            CBBMaSanPham.ValueMember = "MaSP";
        }
    }
}
