using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Business.Models
{
    public class ChiTietDonDatHang
    {
        private int _MaDDH;
        private int _MaSP;
        private decimal _DonGia;
        private int _SoLuong;
        private string _TenSP;
        private decimal _ThanhTien;




        public int MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }

        public string TenSP
        {
            get { return _TenSP; }
            set { _TenSP = value; }
        }

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        public decimal DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }


        public decimal ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }

        public int MaDDH
        {
            get { return _MaDDH; }
            set { _MaDDH = value; }
        }
    }
}
