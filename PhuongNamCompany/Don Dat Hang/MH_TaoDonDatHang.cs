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
        public static string VendorNameTransition = string.Empty;


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
            SBtnSanPham.Enabled = false;
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
            MH_ChonSanPham.EventCreatingItem += MH_ChonSanPham_EventCreatingItem;
            MH_ChonSanPham.ShowDialog();
        }

        void MH_ChonSanPham_EventCreatingItem(object sender, PurchaseLineLineEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.MaSP))
            {
                DataGridViewRow row = (DataGridViewRow)DGVSanPham.Rows[0].Clone();
                row.Cells[0].Value = e.MaSP;
                row.Cells[1].Value = e.TenSP;
                row.Cells[2].Value = e.MoTa;
                row.Cells[3].Value = e.SoLuong;
                row.Cells[4].Value = e.GiaTien;
                row.Cells[5].Value = e.TongTien;
                DGVSanPham.Rows.Add(row);
                calculateTotalAmount();
            }
        }

        private void CbbMaNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            NhaCungCap vendor = new NhaCungCap();
            vendor = VendorsController.autoset(int.Parse(CbbMaNhaCungCap.SelectedValue.ToString()));
            VendorIdTransition = CbbMaNhaCungCap.SelectedValue.ToString();
            VendorNameTransition = vendor.TenCongTy;
            TBTenCongTy.Text = vendor.TenCongTy;
            TBDiaChi.Text = vendor.DiaChi;
            TBSoDienThoai.Text = vendor.SDT;
            
            // enable nút sản phẩm.
            SBtnSanPham.Enabled = true;
        }

        private void CBBNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnMaDonHang_Click(object sender, EventArgs e)
        {
            TBMaDonDatHang.Text = PurchaseOrdersConroller.generatePurchaseId().ToString();
        }



        // Tinh toan
        private void calculateTotalAmount()
        {
            decimal TotalAmount = 0;
            for (int i = 0; i < DGVSanPham.Rows.Count - 1; i++)
            {
                TotalAmount = TotalAmount + decimal.Parse(DGVSanPham.Rows[i].Cells[5].Value.ToString());
            }
            TBTongDonHangVAT.Text = (TotalAmount + TotalAmount * 10 / 100).ToString();
            TBTongDonHang.Text = TotalAmount.ToString();
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            if (checkOrder() == true)
            {
                if (createOrder() == true)
                {
                    if (createPurchaseLine() == true)
                    {
                        MessageBox.Show("Tạo đơn hàng thành công!");
                        this.Close();
                    }
                }
            }
        }

        private bool createPurchaseLine()
        {
            List<ChiTietDonDatHang> PurchaseLines = new List<ChiTietDonDatHang>();
            for (int i = 0; i < DGVSanPham.Rows.Count - 1; i++)
            {

                ChiTietDonDatHang Line = new ChiTietDonDatHang();
                Line.MaDDH = PurchaseOrdersConroller.generatePurchaseId() - 10;
                Line.MaSP = int.Parse(DGVSanPham.Rows[i].Cells[0].Value.ToString());
                Line.SoLuong = int.Parse(DGVSanPham.Rows[i].Cells[3].Value.ToString());
                Line.DonGia = decimal.Parse(DGVSanPham.Rows[i].Cells[4].Value.ToString());
                Line.ThanhTien = decimal.Parse(DGVSanPham.Rows[i].Cells[5].Value.ToString());
                PurchaseLines.Add(Line);
            }
            PurchaseOrdersConroller.createPurchaseLines(PurchaseLines);
            return true;
        }

        private bool checkOrder()
        {
            if (CBBNhanVien.Text == "" || TBNgayGiao.Value == null || CbbMaNhaCungCap.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin của đơn hàng này",
                     "Cảnh báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                return false;
            }
            if (CBBNhanVien.Text == "")
            {
                MessageBox.Show("Xin chọn nhân viên tạo đơn hàng này.",
                     "Cảnh báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                return false;
            }
            if (DGVSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Hãy tạo sản phẩm cho đơn hàng này.",
                     "Cảnh báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }



        private bool createOrder()
        {
            DonDatHang Order = new DonDatHang();
            Order.MaNCC = int.Parse(VendorIdTransition);
            Order.MaNV = int.Parse(CBBNhanVien.SelectedValue.ToString());
            Order.NgayGiao = TBNgayGiao.Value;
            Order.TongTien = decimal.Parse(TBTongDonHang.Text);
            Order.TongTienVAT = decimal.Parse(TBTongDonHangVAT.Text);
            return PurchaseOrdersConroller.createPurchaseOrder(Order);
        }
    }
}
