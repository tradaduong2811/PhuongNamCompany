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
    public partial class MH_ChiTietDonDatHang : Form
    {
        public MH_ChiTietDonDatHang()
        {
            InitializeComponent();
        }

        private void toggleEditMode(bool mode = false)
        {
            TBMaDonHang.ReadOnly = mode;
            button1.Enabled = !mode;
            tbTenCongTy.ReadOnly = mode;
            TBDiaChi.ReadOnly = mode;
            TBMaDonHang.ReadOnly = mode;
            CbbMaNhaCungCap.Enabled = !mode;
            TBSoDienThoai.ReadOnly = mode;
            CBBNhanVien.Enabled = !mode;
            CBBTinhTrang.Enabled = !mode;
            dtNgayGiaoHang.Enabled = !mode;
            BtnXacNhan.Enabled = !mode;
            BtnXacNhan.Enabled = mode;
            if (CBBTinhTrang.Text == "Đã xác nhận")
            {
                SBtnChinhSua.Enabled = !mode;
                SBtnXoa.Enabled = !mode;
            }
            TBTongTien.ReadOnly = mode;
            TBTongTienVAT.ReadOnly = mode;
            DGVPSanPham.ReadOnly = mode;
            SBtnSanPham.Enabled = !mode;
            BtnXacNhan.Enabled = !mode;

        }

        MH_DSDonDatHang DSDonDatHang = new MH_DSDonDatHang();

        PurchaseOrdersController PurchaseOrdersController = new PurchaseOrdersController();
        private void SBtnThemMoi_Click(object sender, EventArgs e)
        {
            MH_TaoDonDatHang MH_TaoDonDatHang = new MH_TaoDonDatHang();
            MH_TaoDonDatHang.ShowDialog();
        }

        private void SBtnInBaoCao_Click(object sender, EventArgs e)
        {
            if (MH_DSDonDatHang.OrderIdTransition == null)
            {
                MessageBox.Show("Xin chọn Đơn đặt hàng.");
            }
            else
            {
                DialogResult dialogresult = MessageBox.Show("In đơn đặt hàng Mã số " + MH_DSDonDatHang.OrderIdTransition,
                                         "In báo cáo?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                         MessageBoxDefaultButton.Button2);
                if (dialogresult == DialogResult.OK)
                {
                    MessageBox.Show("Đã in đơn hàng Mã số " + MH_DSDonDatHang.OrderIdTransition + ".");
                }
            }
        }

        private void MH_ChiTietDonDatHang_Load(object sender, EventArgs e)
        {
            if (MH_DSDonDatHang.OrderIdTransition == null)
            {
                MessageBox.Show("Lỗi lấy dữ liệu");
            }
            else
            {
                loadPurchaseOrder(MH_DSDonDatHang.OrderIdTransition);
            }
        }

        private void loadPurchaseOrder(string id)
        {
            DonDatHang PurOrder = new DonDatHang();
            PurOrder = PurchaseOrdersController.displayPurchaseOrder(id);
            if (PurOrder != null)
            {
                TBMaDonHang.Text = PurOrder.MaDDH.ToString();
                CbbMaNhaCungCap.Text = PurOrder.MaNCC.ToString();
                TBSoDienThoai.Text = PurOrder.SDT;
                dtNgayGiaoHang.Text = PurOrder.NgayGiao.ToString();
                tbTenCongTy.Text = PurOrder.NhaCungCap;
                CBBTinhTrang.Text = PurOrder.XacNhan;
                CBBNhanVien.Text = PurOrder.MaNV.ToString();
                TBDiaChi.Text = PurOrder.DiaChi;
                TBTongTien.Text = PurOrder.TongTien.ToString();
                TBTongTienVAT.Text = PurOrder.TongTienVAT.ToString();
                lbMaDon.Text = "Mã số " + PurOrder.MaDDH;
                toggleEditMode(true);
            }

            List<ChiTietDonDatHang> tbOrderLines = new List<ChiTietDonDatHang>();
            tbOrderLines = PurchaseOrdersController.displayOrderLines(id);
            DGVPSanPham.DataSource = tbOrderLines;
            DGVPSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            DGVPSanPham.Columns[0].Width = 100;
            DGVPSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            DGVPSanPham.Columns[2].HeaderText = "Số lượng";
            DGVPSanPham.Columns[3].HeaderText = "Đơn giá";
            DGVPSanPham.Columns[4].HeaderText = "Thành tiền";
            DGVPSanPham.Columns[5].Visible = false;
            
            //DGVPSanPham.DataSource = PurchaseOrdersController.displayPurchaseOrder(id);
        }

        private void SBtnChinhSua_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn muốn chỉnh sửa đơn hàng Mã số " + MH_DSDonDatHang.OrderIdTransition + " không?",
                                                   "Chỉnh sửa?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                                   MessageBoxDefaultButton.Button2);
            if (dialogresult == DialogResult.OK)
            {
                toggleEditMode(false);
            }
            
        }

        private void SBtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn có muốn xóa đơn hàng Mã số " + MH_DSDonDatHang.OrderIdTransition + " không?",
                                                   "Xóa?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                                   MessageBoxDefaultButton.Button2);
            if (dialogresult == DialogResult.OK)
            {
                int result = PurchaseOrdersController.removePurchaseOrder(MH_DSDonDatHang.OrderIdTransition);
                if (result == 0)
                    MessageBox.Show("Đơn hàng Mã số " + MH_DSDonDatHang.OrderIdTransition + " đã được xác nhận. Không thể xóa.",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                if (result == 1)
                {
                    MessageBox.Show("Đã xóa đơn hàng Mã số " + MH_DSDonDatHang.OrderIdTransition + ".",
                   "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // cập nhật lại đơn hàng
                    this.Close();
                }
                if (result == -1)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình xóa đơn hàng",
                    "Lỗi",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                }
            }
        }
    }
}
