using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Business.Models
{
    public class NhanVien
    {
        // Nhập dòng này xong và Encapsulate (Phím tắt CTR+R, CTR+E)
        private int _MaNV;

        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private string _MoTaThem;

        public string MoTaThem
        {
            get { return _MoTaThem; }
            set { _MoTaThem = value; }
        }

        private string _HoTen;

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }

        private DateTime _NgaySinh;

        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
    }
}
