using PhuongNam_Business.Models;
using PhuongNam_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Business.Controller
{
    public class VendorsController
    {
        public NhaCungCap_Data data = new NhaCungCap_Data();
        public List<NhaCungCap> displayVendors()
        {
            List<NhaCungCap> listVendors = new List<NhaCungCap>();
            DataTable dt = new DataTable();
            dt = data.displayVendor();
            foreach (DataRow dr in dt.Rows)
            {
                NhaCungCap vendor = new NhaCungCap();
                vendor.MaNCC = (int)dr["MaNhaCungCap"];
                vendor.TenCongTy = (string)dr["TenCongTy"];
                vendor.DiaChi = (string)dr["DiaChi"];
                vendor.SDT = (string)dr["SDT"];
                vendor.MoTaThem = vendor.MaNCC + " | " + vendor.TenCongTy + " | " + vendor.DiaChi;
                listVendors.Add(vendor);
            }
            return listVendors;
        }


        // Tự động tạo dữ liệu ở fields
        public NhaCungCap autoset(int VendorId)
        {
            NhaCungCap vendor = new NhaCungCap();
            vendor = displayVendors().SingleOrDefault(s => s.MaNCC == VendorId);
            return vendor;
        }

        public NhaCungCap displayVendors(string id)
        {
            NhaCungCap vendor = new NhaCungCap();
            DataTable dt = new DataTable();
            dt = data.displayVendors(id);
            foreach (DataRow dr in dt.Rows)
            {
                vendor.TenCongTy = (string)dr["TenCongTy"];
                vendor.DiaChi = (string)dr["DiaChi"];
                vendor.NguoiDaiDien = (string)dr["NguoiDaiDien"];
                vendor.SDT = (string)dr["SDT"];
                vendor.MaNCC = (int)dr["MaNhaCungCap"];
                vendor.MaSoThue = (string)dr["MaSoThue"];
                vendor.TKNganHang = (string)dr["TKNganHang"];
            }
            return vendor;
        }
        public int generateVendorId()
        {
            return data.getLastVendorId() + 1;
        }
        public bool insertVendor(NhaCungCap vendor)
        {
           return data.createVendor(vendor.MaNCC, vendor.TenCongTy, vendor.DiaChi, vendor.SDT, vendor.NguoiDaiDien, vendor.MaSoThue, vendor.TKNganHang);
        }
        public int removeVendor(string id)
        {
            int result = data.removeVendor(id);
            return result;
        }

    }
}
