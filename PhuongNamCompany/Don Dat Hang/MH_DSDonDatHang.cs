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
    public partial class MH_DSDonDatHang : Form
    {
        public MH_DSDonDatHang()
        {
            InitializeComponent();
            initPurchaseOrders();
        }

        /// <summary>
        /// Khai báo sử dụng Tầng Nghiệp vụ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        PurchaseOrdersController PurchaseOrdersController = new PurchaseOrdersController();

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


        public void initPurchaseOrders()
        {
            // ganws
            if (PurchaseOrdersController.displayVendors() == null)
            {
                MessageBox.Show("Lỗi lấy dữ liệu từ hệ thống");
            }
            else
            {
                DGVDonHang.DataSource = PurchaseOrdersController.displayVendors();
                // Thay đổi header trên bảng
                DGVDonHang.Columns[0].HeaderText = "Mã";
                DGVDonHang.Columns[0].Width = 50;
                DGVDonHang.Columns[1].HeaderText = "Nhà cung cấp";
                DGVDonHang.Columns[1].Width = 150;
                DGVDonHang.Columns[2].HeaderText = "Địa chỉ";
                DGVDonHang.Columns[2].Width = 180;
                DGVDonHang.Columns[3].HeaderText = "Người đại diện";
                DGVDonHang.Columns[3].Width = 120;
                DGVDonHang.Columns[4].HeaderText = "Tổng tiền";
                DGVDonHang.Columns[4].Width = 100;
                DGVDonHang.Columns[5].HeaderText = "Tổng tiền VAT";
                DGVDonHang.Columns[5].Width = 100;
                DGVDonHang.Columns[6].HeaderText = "Mã Nhân viên";
                DGVDonHang.Columns[6].Width = 100;
                DGVDonHang.Columns[7].HeaderText = "Ngày giao";
                DGVDonHang.Columns[7].Width = 100;
                DGVDonHang.Columns[8].HeaderText = "Xác nhận";
                DGVDonHang.Columns[8].Width = 100;
                //DGVDonHang.EditMode = false;
            }

        }
        private void MH_DSDonDatHang_Load(object sender, EventArgs e)
        {
        }

        private void SBtnXacNhan_Click(object sender, EventArgs e)
        {
            string OrderId = null;
            for (int i = 0; i < DGVDonHang.SelectedRows.Count; i++)
            {
                OrderId = DGVDonHang.SelectedRows[i].Cells[0].Value.ToString();
            }
            DialogResult dialogresult = MessageBox.Show("Xác nhận đơn đặt hàng Mã số " + OrderId,
                                              "Xác nhận?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                              MessageBoxDefaultButton.Button2);
            if (dialogresult == DialogResult.OK)
            {
                PurchaseOrdersController.approvePurchaseOrder(OrderId);
                MessageBox.Show("Đã xác nhận đơn hàng Mã số " + OrderId + ".");
                // cập nhật lại đơn hàng
                initPurchaseOrders();
            }
        }
    }
}
