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
        private string _SDT;
        private string _NguoiDaiDien;
        private int _MaNCC;

        public int MaDDH
        {
            get { return _MaDDH; }
            set { _MaDDH = value; }
        }
        public string NhaCungCap
        {
            get { return _NhaCungCap; }
            set { _NhaCungCap = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        public string NguoiDaiDien
        {
            get { return _NguoiDaiDien; }
            set { _NguoiDaiDien = value; }
        }
       
        private DateTime _NgayGiao;
        private int _MaNV;
        private decimal _TongTien;
        private decimal _TongTienVAT;
        private string _XacNhan;

        public decimal TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }
        public decimal TongTienVAT
        {
            get { return _TongTienVAT; }
            set { _TongTienVAT = value; }
        }



        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        public DateTime NgayGiao
        {
            get { return _NgayGiao; }
            set { _NgayGiao = value; }
        }

        public string XacNhan
        {
            get { return _XacNhan; }
            set { _XacNhan = value; }
        }

        public int MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }
    }
}
