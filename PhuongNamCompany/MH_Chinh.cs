﻿using System;
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
    public partial class MH_Chinh : Form
    {
        public MH_Chinh()
        {
            InitializeComponent();
        }

        private void btn_BoPhanBanHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm đang trong quá trình hoàn thiện, vui lòng quay lại sau.");
        }

        private void btn_BoPhanKho_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm đang trong quá trình hoàn thiện, vui lòng quay lại sau.");
        }

        private void btn_Marketing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm đang trong quá trình hoàn thiện, vui lòng quay lại sau.");
        }

        private void btn_BoPhanMuaHang_Click(object sender, EventArgs e)
        {
            MH_BoPhanMuaHang MH_BoPhanMuaHang = new MH_BoPhanMuaHang();
            MH_BoPhanMuaHang.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
