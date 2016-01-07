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
        public MH_DanhSachSanPham()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            //try
            //{
                //// Set up the DataGridView.
                //dgv_DSSP.Dock = DockStyle.Fill;

                //// Automatically generate the DataGridView columns.
                //dgv_DSSP.AutoGenerateColumns = true;

                //// Set up the data source.
                //bindingSource1.DataSource = proController.getProducts(); ;
                //dgv_DSSP.DataSource = bindingSource1;

                //// Automatically resize the visible rows.
                //dgv_DSSP.AutoSizeRowsMode =
                //    DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                //// Set the DataGridView control's border.
                //dgv_DSSP.BorderStyle = BorderStyle.Fixed3D;

                //// Put the cells in edit mode when user enters them.
            
                dgv_DSSP.DataSource = proController.getProducts();
            //}
            //catch (SqlException)
            //{
            //    MessageBox.Show("To run this sample replace connection.ConnectionString" +
            //        " with a valid connection string to a Northwind" +
            //        " database accessible to your system.", "ERROR",
            //        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    System.Threading.Thread.CurrentThread.Abort();
            //}
        }

        //private static DataTable GetData(string sqlCommand)
        //{
        //    string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|PhuongNamDB.mdf; Integrated Security=True";

        //    SqlConnection northwindConnection = new SqlConnection(connectionString);

        //    SqlCommand command = new SqlCommand(sqlCommand, northwindConnection);
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    adapter.SelectCommand = command;

        //    DataTable table = new DataTable();
        //    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
        //    adapter.Fill(table);

        //    return table;
        //}


        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            MH_TaoSanPham mh_tsp = new MH_TaoSanPham();
            mh_tsp.ShowDialog();
        }

        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {
            MH_ChiTietSanPham mh_ctsp = new MH_ChiTietSanPham();
            mh_ctsp.ShowDialog();
        }

        private void btn_XemGia_Click(object sender, EventArgs e)
        {
            MH_GiaSanPham mh_gsp = new MH_GiaSanPham();
            mh_gsp.ShowDialog();
        }
    }
}
