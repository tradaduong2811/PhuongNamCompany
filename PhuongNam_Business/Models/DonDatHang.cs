using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Business.Models
{
    public class DonDatHang
    {
        private int _MaDDH;
        private string _NhaCungCap;
        private string _DiaChi;
        private string _NguoiDaiDien;

        public string NguoiDaiDien
        {
            get { return _NguoiDaiDien; }
            set { _NguoiDaiDien = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _NgayGiao;
        private int _MaNV;
        private decimal _TongTien;
        private decimal _TongTienVAT;

        public decimal TongTienVAT
        {
            get { return _TongTienVAT; }
            set { _TongTienVAT = value; }
        }

        public decimal TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }

        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        public string NgayGiao
        {
            get { return _NgayGiao; }
            set { _NgayGiao = value; }
        }

        public string NhaCungCap
        {
            get { return _NhaCungCap; }
            set { _NhaCungCap = value; }
        }

        public int MaDDH
        {
            get { return _MaDDH; }
            set { _MaDDH = value; }
        }
    }
}
