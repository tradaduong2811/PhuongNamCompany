using PhuongNam_Business;
using PhuongNam_Business.Controller;
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


        PurchaseOrdersController PurchaseOrdersConroller = new PurchaseOrdersController();
        VendorsController VendorsController = new VendorsController();        

        private void MH_TaoDonDatHang_Load(object sender, EventArgs e)
        {
            CbbMaNhaCungCap.DataSource = VendorsController.displayVendors().ToList();
            CbbMaNhaCungCap.DisplayMember = "MaNCC";
            CbbMaNhaCungCap.ValueMember = "TenCongTy";
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

        private void CbbMaNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TBTenCongTy.Text = PurchaseOrdersConroller.generateName(int.Parse(CBCustomerNo.Text));
            

            //if (CBCustomerNo.Text != "" && CheckReset == true && TBNo.Text != "")
            //{
                //BTCreateSalesLine.Enabled = true;
            //}
        }
    }
}
