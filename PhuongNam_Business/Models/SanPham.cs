using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Business.Models
{
    public class SanPham
    {
        private int _MaSP;
        private int _HangSX;
        private string _TenSP;
        private int _TGBaoHanh;
        private string _XuatXu;
        private string _HeDieuHanh;
        private string _KichThuoc;
        private string _MoTa;
        private int _TrongLuong;

        public int TrongLuong
        {
            get { return _TrongLuong; }
            set { _TrongLuong = value; }
        }

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }

        public string KichThuoc
        {
            get { return _KichThuoc; }
            set { _KichThuoc = value; }
        }

        public string HeDieuHanh
        {
            get { return _HeDieuHanh; }
            set { _HeDieuHanh = value; }
        }

        public string XuatXu
        {
            get { return _XuatXu; }
            set { _XuatXu = value; }
        }

        public int TGBaoHanh
        {
            get { return _TGBaoHanh; }
            set { _TGBaoHanh = value; }
        }

        public string TenSP
        {
            get { return _TenSP; }
            set { _TenSP = value; }
        }

        public int HangSX
        {
            get { return _HangSX; }
            set { _HangSX = value; }
        }

        public int MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }
    }
}
