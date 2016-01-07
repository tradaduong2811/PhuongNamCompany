using PhuongNam_Business.Models;
using PhuongNam_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Business.Controller
{
    public class EmployeesController
    {
        public NhanVien_Data data = new NhanVien_Data();

        public List<NhanVien> displayEmployees()
        {
            List<NhanVien> listEmployees = new List<NhanVien>();
            DataTable dt = new DataTable();
            dt = data.displayEmployees();
            foreach (DataRow dr in dt.Rows)
            {
                NhanVien emp = new NhanVien();
                emp.MaNV = (int)dr["MaNV"];
                emp.HoTen = dr["HoTen"].ToString();

                emp.MoTaThem = emp.MaNV + " | " + emp.HoTen;
                listEmployees.Add(emp);
            }
            return listEmployees;
        }
    }
}
