using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhuongNam_Business.Models;
using PhuongNam_Data;

namespace PhuongNam_Business.Controller
{
    public class PurchaseOrdersController
    {
        public DonDatHang_Data data = new DonDatHang_Data();
        public List<DonDatHang> displayVendors()
        {
            List<DonDatHang> listOrders = new List<DonDatHang>();
            DataTable dt = new DataTable();
            dt = data.displayPurchaseOrders();
            foreach (DataRow dr in dt.Rows)
            {
                DonDatHang order = new DonDatHang();
                order.MaDDH = (int)dr["MaDDH"];
                order.NhaCungCap = (string)dr["TenCongTy"];
                order.DiaChi = (string)dr["DiaChi"];
                order.NguoiDaiDien = (string)dr["NguoiDaiDien"];
                order.NgayGiao = (DateTime)dr["NgayGiao"];
                order.NgayGiao.ToString("dd/MM/yyyy");
                order.TongTien = (decimal)dr["TongTien"];
                order.TongTienVAT = (decimal)dr["TongTienVAT"];
                order.XacNhan = dr["XacNhan"].ToString();
                if (order.XacNhan == "True")
                    order.XacNhan = "Đã xác nhận";
                else
                    order.XacNhan = "Chưa xác nhận";
                listOrders.Add(order);
            }
            return listOrders;
        }

        public bool approvePurchaseOrder(string id)
        {
            return data.approvePurchaseOrder(id);
        }
    }
}
