using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            QuocGia_Data qg = new QuocGia_Data();

            DonDatHang_Data ddh = new DonDatHang_Data();
            
            DataTable dt = qg.displayCountry();

            DataTable tbDDH = ddh.displayPurchaseOrders();
            foreach (DataRow item in tbDDH.Rows)
	        {
                Console.WriteLine(item["TenCongTy"]);
	        }
        }
    }
}
