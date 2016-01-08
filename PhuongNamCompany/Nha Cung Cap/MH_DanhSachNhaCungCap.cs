using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhuongNam_Data;
using PhuongNam_Business.Controller;

namespace PhuongNamCompany
{
    public partial class MH_DanhSachNhaCungCap : Form
    {

        public MH_DanhSachNhaCungCap()
        {
            InitializeComponent();
            refreshVendors();
        }

        public static string OrderIdTransition = string.Empty;
        
        VendorsController VendorsController = new VendorsController();

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            MH_TaoNhaCungCap MH_TaoNhaCungCap = new MH_TaoNhaCungCap();
            MH_TaoNhaCungCap.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn có muốn xóa nhà cung cấp " + "Mã nhà cung cấp " + "không?",
                                               "Xóa?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                               MessageBoxDefaultButton.Button2);
            if (dialogresult == DialogResult.OK)
            {
                MessageBox.Show("Đã xóa.");
                // cập nhật lại danh sách nhà cung cấp
            }
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            MH_ChiTietNhaCungCap MH_ChinhSua = new MH_ChiTietNhaCungCap();
            MH_ChinhSua.Show();
        }

        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {
            string OrderId = null;
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                OrderId = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();
            }
            if (OrderId == null)
            {
                MessageBox.Show("Xin chọn Nhà Cung Cấp.");
            }
            else
            {
                MH_ChiTietNhaCungCap MH_XemChiTiet = new MH_ChiTietNhaCungCap();

                // Chuyển Id sang Màn hình Xem chi tiết
                OrderIdTransition = OrderId;
                MH_XemChiTiet.ShowDialog();
            }
        }

        private void btn_XemGia_Click(object sender, EventArgs e)
        {
            MH_XemSanPham MH_XemSanPham = new MH_XemSanPham();
            MH_XemSanPham.Show();
        }

        private void MH_DanhSachNhaCungCap_Load(object sender, EventArgs e)
        {
            NhaCungCap_Data nhacungcap = new NhaCungCap_Data();
            dataGridView1.DataSource = nhacungcap.displayVendor();
        }

        public void refreshVendors()
        {
            if (VendorsController.displayVendors() == null)
            {
                MessageBox.Show("Lỗi lấy dữ liệu từ hệ thống");
            }
            else
            {
                dataGridView1.DataSource = VendorsController.displayVendors();
                // Thay đổi header trên bảng
                dataGridView1.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Tài Khoản Ngân Hàng";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].HeaderText = "Mã Số Thuế";
                dataGridView1.Columns[2].Width = 180;
                dataGridView1.Columns[3].HeaderText = "Người Đại Diện";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Số Điện Thoại";
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[5].HeaderText = "Địa Chỉ";
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[6].HeaderText = "Tên Công Ty";
                dataGridView1.Columns[6].Width = 100;
            }

        }


    }
}
