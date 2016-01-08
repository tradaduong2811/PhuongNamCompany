
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhuongNamCompany
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MH_DSDonDatHang());

<<<<<<< HEAD
            //Application.Run(new MH_DanhSachNhaCungCap());
=======
            //Application.Run(new MH_DanhSachSanPham());

<<<<<<< HEAD
            //Application.Run(new MH_DanhSachSanPham());
=======
            Application.Run(new MH_BoPhanMuaHang());
>>>>>>> 4243887705a74dcd11cd2cf7b0665675bccdf4b4
>>>>>>> origin/master

            Application.Run(new MH_ChiTietSanPham());
        }
    }
}

