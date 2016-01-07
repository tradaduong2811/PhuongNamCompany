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

        public NhaCungCap autosetCompanyName(int VendorId)
        {
            NhaCungCap vendor = new NhaCungCap();
            vendor = displayVendors().SingleOrDefault(s => s.MaNCC == VendorId);
            return vendor;
        }
    }
}
