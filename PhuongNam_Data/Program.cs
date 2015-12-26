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

            DataTable dt = qg.displayCountry();
            foreach (DataRow item in dt.Rows)
	        {
                Console.WriteLine(item["maDDH"]);
	        }
        }
    }
}
