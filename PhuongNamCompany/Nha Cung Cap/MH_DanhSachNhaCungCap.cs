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

        public static string VendorIdTransition = string.Empty;
        
        VendorsController VendorsController = new VendorsController();
        NhaCungCap_Data NCCdata = new NhaCungCap_Data();

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            MH_TaoNhaCungCap MH_TaoNhaCungCap = new MH_TaoNhaCungCap();
            MH_TaoNhaCungCap.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string VendorId = null;
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                VendorId = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();
            }
            if (VendorId == null)
            {
                MessageBox.Show("Xin chọn Nhà Cung Cấp.");
            }
            else
            {
                DialogResult dialogresult = MessageBox.Show("Bạn có muốn xóa nhà cung cấp " + VendorId + " không?",
                                               "Xóa?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                               MessageBoxDefaultButton.Button2);
                if (dialogresult == DialogResult.OK)
                {
                    int result = VendorsController.removeVendor(VendorId);
                    if (result == 0)
                    {
                        MessageBox.Show("Nhà cung cấp Mã số " + VendorId + " đã có đơn hàng. Không thể xóa.",
                        "Cảnh cáo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                    if (result == 1)
                    {
                        MessageBox.Show("Đã xóa Nhà Cung Cấp Mã số " + VendorId + ".");
                        // cập nhật lại danh sách nhà cung cấp
                        refreshVendors();
                        dataGridView1.Update();
                        dataGridView1.Refresh();
                    }
                }
            } 
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            MH_ChiTietNhaCungCap MH_ChinhSua = new MH_ChiTietNhaCungCap();
            MH_ChinhSua.Show();
        }

        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {
            string VendorId = null;
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                VendorId = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();
            }
            if (VendorId == null)
            {
                MessageBox.Show("Xin chọn Nhà Cung Cấp.");
            }
            else
            {
                MH_ChiTietNhaCungCap MH_XemChiTiet = new MH_ChiTietNhaCungCap();

                // Chuyển Id sang Màn hình Xem chi tiết
                VendorIdTransition = VendorId;
                MH_XemChiTiet.ShowDialog();
            }
        }

        private void btn_XemGia_Click(object sender, EventArgs e)
        {
            string VendorId = null;
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                VendorId = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();
            }
            if (VendorId == null)
            {
                MessageBox.Show("Xin chọn Nhà Cung Cấp.");
            }
            else
            {
                MH_XemSanPham MH_XemSanPham = new MH_XemSanPham();
                // Chuyển Id sang Màn hình Xem chi tiết
                VendorIdTransition = VendorId;
                MH_XemSanPham.ShowDialog();
            }

        }

        private void MH_DanhSachNhaCungCap_Load(object sender, EventArgs e)
        {
            NhaCungCap_Data nhacungcap = new NhaCungCap_Data();
            dataGridView1.DataSource = nhacungcap.displayVendor();
        }

        public void refreshVendors()
        {
            if (NCCdata.displayVendor() == null)
            {
                MessageBox.Show("Lỗi lấy dữ liệu từ hệ thống");
            }
            else
            {
                dataGridView1.DataSource = NCCdata.displayVendor();
                // Thay đổi header trên bảng
                dataGridView1.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Tên Công Ty";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].HeaderText = "Địa Chỉ";
                dataGridView1.Columns[2].Width = 180;
                dataGridView1.Columns[3].HeaderText = "Số Điện Thoại";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Người Đại Diện";
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[5].HeaderText = "Mã Số Thuế";
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[6].HeaderText = "Tài Khoản Ngân Hàng";
                dataGridView1.Columns[6].Width = 100;
                dataGridView1.Update();
                dataGridView1.Refresh();
            }

        }

        private void SBtnTaiLai_Click(object sender, EventArgs e)
        {
            refreshVendors();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }


    }
}
