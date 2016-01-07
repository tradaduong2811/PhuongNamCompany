using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Business.Models
{
    public class NhaCungCap
    {
        private int _MaNCC;
        private string _TenCongTy;
        private string _DiaChi;
        private string _SDT;
        private string _NguoiDaiDien;
        private string _MaSoThue;
        private string _TKNganHang;
        private string _MoTaThem;

        public string MoTaThem
        {
            get { return _MoTaThem; }
            set { _MoTaThem = value; }
        }
        public string TKNganHang
        {
            get { return _TKNganHang; }
            set { _TKNganHang = value; }
        }

        public string MaSoThue
        {
            get { return _MaSoThue; }
            set { _MaSoThue = value; }
        }

        public string NguoiDaiDien
        {
            get { return _NguoiDaiDien; }
            set { _NguoiDaiDien = value; }
        }

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        public string TenCongTy
        {
            get { return _TenCongTy; }
            set { _TenCongTy = value; }
        }
        public int MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }
    }
}
