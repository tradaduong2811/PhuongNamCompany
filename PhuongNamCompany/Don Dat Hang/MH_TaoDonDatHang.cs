using PhuongNam_Business;
using PhuongNam_Business.Controller;
using PhuongNam_Business.Models;
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
            initPurchaseOrder();
        }
        public static string VendorIdTransition = string.Empty;


        /// <summary>
        /// Controller
        /// </summary>
        PurchaseOrdersController PurchaseOrdersConroller = new PurchaseOrdersController();
        VendorsController VendorsController = new VendorsController();
        EmployeesController EmployeesController = new EmployeesController();

        private void resetMode(bool mode = true)
        {
            CbbMaNhaCungCap.Text = "";
            CBBNhanVien.Text = "";
        }

        private void MH_TaoDonDatHang_Load(object sender, EventArgs e)
        {
            resetMode();
        }

        private void initPurchaseOrder()
        {
            CbbMaNhaCungCap.DataSource = VendorsController.displayVendors().ToList();
            CbbMaNhaCungCap.DisplayMember = "MoTaThem";
            CbbMaNhaCungCap.ValueMember = "MaNCC";

            CBBNhanVien.DataSource = EmployeesController.displayEmployees();
            CBBNhanVien.DisplayMember = "MoTaThem";
            CBBNhanVien.ValueMember = "MaNV";

            
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
            NhaCungCap vendor = new NhaCungCap();
            vendor = VendorsController.autosetCompanyName(int.Parse(CbbMaNhaCungCap.SelectedValue.ToString()));
            VendorIdTransition = CbbMaNhaCungCap.SelectedValue.ToString();
            TBTenCongTy.Text = vendor.TenCongTy;
            TBDiaChi.Text = vendor.DiaChi;
            TBSoDienThoai.Text = vendor.SDT;
        }

        private void CBBNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
