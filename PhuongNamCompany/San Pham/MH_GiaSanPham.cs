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
    public partial class MH_GiaSanPham : Form
    {
        public MH_GiaSanPham()
        {
            InitializeComponent();
            //dgvGia.BackgroundColor = System.Drawing.SystemColors.Control;
            //dgvGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvGia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGia.BackgroundColor = SystemColors.ControlLightLight;
            dgvGia.BorderStyle = BorderStyle.None;
            dgvGia.Rows[0].Cells[0].Value = "Viettel";
            dgvGia.Rows[0].Cells[1].Value = "4590000";
            

            //dgvGia.Rows[1].Cells[0].Value = "FPT";
            //dgvGia.Rows[1].Cells[1].Value = "4600000";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
