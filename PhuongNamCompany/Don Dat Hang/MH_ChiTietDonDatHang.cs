﻿using PhuongNam_Business.Controller;
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
            BtnXacNhan.Enabled = mode;
            TBTongTien.ReadOnly = mode;
            TBTongTienVAT.ReadOnly = mode;
            DGVPSanPham.ReadOnly = mode;
            SBtnSanPham.Enabled = !mode;

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
            
            //DGVPSanPham.DataSource = PurchaseOrdersController.displayPurchaseOrder(id);
        }

        private void SBtnChinhSua_Click(object sender, EventArgs e)
        {
            toggleEditMode(false);
        }
    }
}
