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
using PhuongNam_Business;

namespace PhuongNamCompany
{
    public partial class MH_DanhSachSanPham : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        ProductsController proController = new ProductsController();
        public static string idProduct = string.Empty;
        public MH_DanhSachSanPham()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            //dgv_DSSP.CurrentCell = null ;
            dgv_DSSP.AllowUserToAddRows = false;
            //try
            //{
                //// Set up the DataGridView.
                dgv_DSSP.Dock = DockStyle.Fill;

                //// Automatically generate the DataGridView columns.
                //dgv_DSSP.AutoGenerateColumns = true;


                //// Automatically resize the visible rows.
                dgv_DSSP.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                //// Set the DataGridView control's border.
                dgv_DSSP.BorderStyle = BorderStyle.Fixed3D;

                //// Put the cells in edit mode when user enters them.
            
               // dgv_DSSP.DataSource = proController.getProducts();
                bindingSource1.DataSource = proController.getProducts();
                dgv_DSSP.DataSource = bindingSource1.DataSource;
                dgv_DSSP.Columns[0].Visible = false;
                dgv_DSSP.Columns[12].Visible = false;
                dgv_DSSP.Columns[13].Visible = false;

                dgv_DSSP.Columns[1].HeaderText = "Mã Sản Phẩm";
                //dgv_DSSP.Columns[1].Width = 50;
                dgv_DSSP.Columns[2].HeaderText = "Tên Sản Phẩm";
                //dgv_DSSP.Columns[2].Width = 150;
                dgv_DSSP.Columns[3].HeaderText = "Hãng Sản Xuất";
                //dgv_DSSP.Columns[2].Width = 180;
                dgv_DSSP.Columns[3].HeaderText = "Loại";
               // dgv_DSSP.Columns[3].Width = 100;
                dgv_DSSP.Columns[4].HeaderText = "Đơn Giá";
                //dgv_DSSP.Columns[4].Width = 120;
                dgv_DSSP.Columns[5].HeaderText = "Mô Tả";
                //dgv_DSSP.Columns[5].Width = 100;
                dgv_DSSP.Columns[6].HeaderText = "Hệ Điều Hành";
               // dgv_DSSP.Columns[6].Width = 100;
                dgv_DSSP.Columns[7].HeaderText = "Trọng Lượng";
               // dgv_DSSP.Columns[7].Width = 100;
                dgv_DSSP.Columns[8].HeaderText = "Thời Gian Bảo Hành";
               // dgv_DSSP.Columns[8].Width = 100;
                dgv_DSSP.Columns[9].HeaderText = "Kích Thước";
               // dgv_DSSP.Columns[9].Width = 100;
                dgv_DSSP.Columns[10].HeaderText = "Xuất Xứ";
             
        }


        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            MH_TaoSanPham mh_tsp = new MH_TaoSanPham();
            mh_tsp.ShowDialog();
        }

        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {
            string idPro = "";
        
            for (int i = 0; i < dgv_DSSP.SelectedRows.Count; i++)
            {
                idPro = dgv_DSSP.SelectedRows[i].Cells[1].Value.ToString();
            }
            if (string.IsNullOrEmpty(idPro))
            {
                MessageBox.Show("Bạn Hãy Chọn Sản Phẩm Để Xem.");
            }
            else
            {
                MH_ChiTietSanPham MH_XemChiTiet = new MH_ChiTietSanPham();

                // Chuyển Id sang Màn hình Xem chi tiết
                idProduct = idPro;
                MH_XemChiTiet.ShowDialog();
            }
        }

        private void btn_XemGia_Click(object sender, EventArgs e)
        {
            string idPro = null;

            for (int i = 0; i < dgv_DSSP.SelectedRows.Count; i++)
            {
                idPro = dgv_DSSP.SelectedRows[i].ToString();
            }
            if (idPro == null)
            {
                MessageBox.Show("Bạn Hãy Chọn Sản Phẩm Để Xem.");
            }
            else
            {
                MH_GiaSanPham mh_gsp = new MH_GiaSanPham();

                // Chuyển Id sang Màn hình Xem chi tiết
                idProduct = idPro;
                mh_gsp.ShowDialog();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string idPro = null;
            string namePro = null;
            //idPro = dgv_DSSP.CurrentCell.RowIndex.ToString();
            for (int i = 0; i < dgv_DSSP.SelectedRows.Count; i++)
            {
                idPro = dgv_DSSP.SelectedRows[i].Cells[1].Value.ToString();
                namePro = dgv_DSSP.SelectedRows[i].Cells[2].Value.ToString();
            }
            if (string.IsNullOrEmpty(idPro))
            {
                MessageBox.Show("Bạn Hãy Chọn Sản Phẩm Để Xóa.");
            }
            else
            {
                DialogResult dialogresult = MessageBox.Show("Bạn có muốn xóa sản phẩm " + idPro + " - " + namePro + " không?",
                                                   "Xóa?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                                   MessageBoxDefaultButton.Button2);
                if (dialogresult == DialogResult.OK)
                {
                    int result = proController.removeProduct(idPro);
                    
                    if (result == 1)
                    {
                        MessageBox.Show("Đã xóa sản phẩm " + idPro + " - " + namePro +".");
                        // cập nhật lại danh sach san pham                       
                        InitializeDataGridView();
                        dgv_DSSP.Update();
                        dgv_DSSP.Refresh();
                    }
                    if (result == 0)
                    {
                        MessageBox.Show("Xảy ra lỗi trong quá trình xóa sản phẩm.");
                    }
                }
            }
        }
    }
}
