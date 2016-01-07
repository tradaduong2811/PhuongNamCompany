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
        public List<DonDatHang> displayPurchaseOrders()
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
                order.MaNV = (int)dr["MaNV"];
                order.SDT = (string)dr["SDT"];
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

        public int removePurchaseOrder(string id)
        {
            int result = data.removePurchaseOrder(id);
            return result;
        }

        public DonDatHang displayPurchaseOrder(string id)
        {
            DonDatHang PurOrder = new DonDatHang();
            DataTable dt = new DataTable();
            dt = data.displayPurchaseOrder(id);
            foreach (DataRow dr in dt.Rows)
            {
                PurOrder.MaDDH = (int)dr["MaDDH"];
                PurOrder.NhaCungCap = (string)dr["TenCongTy"];
                PurOrder.DiaChi = (string)dr["DiaChi"];
                PurOrder.NguoiDaiDien = (string)dr["NguoiDaiDien"];
                PurOrder.NgayGiao = (DateTime)dr["NgayGiao"];
                PurOrder.NgayGiao.ToString("dd/MM/yyyy");
                PurOrder.TongTien = (decimal)dr["TongTien"];
                PurOrder.SDT = (string)dr["SDT"];
                PurOrder.TongTienVAT = (decimal)dr["TongTienVAT"];
                PurOrder.XacNhan = dr["XacNhan"].ToString();
                if (PurOrder.XacNhan == "True")
                    PurOrder.XacNhan = "Đã xác nhận";
                else
                    PurOrder.XacNhan = "Chưa xác nhận";
                PurOrder.MaNCC = (int)dr["MaNhaCungCap"];
            }
            return PurOrder;
        }

        public List<ChiTietDonDatHang> displayOrderLines(string id)
        {
            List<ChiTietDonDatHang> listOrderLines = new List<ChiTietDonDatHang>();
            DataTable tbOrderLines = new DataTable();
            tbOrderLines = data.displayOrderLines(id);
            foreach (DataRow dr in tbOrderLines.Rows)
            {
                ChiTietDonDatHang OrderLine = new ChiTietDonDatHang();
                OrderLine.MaSP = (int)dr["MaSP"];
                OrderLine.TenSP = (string)dr["TenSP"];
                OrderLine.DonGia = (decimal)dr["DonGia"];
                OrderLine.SoLuong = (int)dr["SoLuongDat"];
                OrderLine.ThanhTien = OrderLine.DonGia * OrderLine.SoLuong;
                
                listOrderLines.Add(OrderLine);
            }
            return listOrderLines;
        }

    }
}
