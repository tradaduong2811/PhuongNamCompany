using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Business
{
    public class NhanVien
    {
        // Nhập dòng này xong và Encapsulate (Phím tắt CTR+R, CTR+E)
        private int _HoTen;

        public int HoTen
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
