﻿using System;
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

namespace PhuongNamCompany
{
    public partial class MH_DanhSachNhaCungCap : Form
    {

        public MH_DanhSachNhaCungCap()
        {
            InitializeComponent();
        }

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
            MH_ChiTietNhaCungCap MH_XemChiTiet = new MH_ChiTietNhaCungCap();
            MH_XemChiTiet.Show();
            // disable tất cả các fields
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


    }
}
