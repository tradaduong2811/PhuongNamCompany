﻿using PhuongNam_Business.Models;
using PhuongNam_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNam_Business
{
    public class ProductsController
    {
        public SanPham_Data data = new SanPham_Data();
        public List<SanPham> displayProduct()
        {
            List<SanPham> listProducts = new List<SanPham>();
            DataTable dt = new DataTable();
            dt = data.displayProduct();
            foreach (DataRow dr in dt.Rows)
            {
                SanPham product = new SanPham();
                product.MaSP = (int)dr["MaSP"];
                product.TenSP = (string)dr["TenSP"];
                product.XuatXu = (string)dr["XuatXu"];
            }
            return listProducts;
        }


        //NAM
        public List<SanPham> getProducts()
        {
            List<SanPham> listProducts = new List<SanPham>();
            DataTable dtProducts = new DataTable();
            dtProducts = data.getProducts();
            foreach (DataRow dtrow in dtProducts.Rows)
            {
                SanPham sp = new SanPham();
                sp.MaSP = (int)dtrow["MaSP"];
                sp.TenSP = (string)dtrow["TenSP"];
                sp.HangSX = (string)dtrow["TenHSX"];
                sp.LoaiSP = (string)dtrow["Ten"];
                sp.DonGia = (decimal)dtrow["DonGia"];

                sp.MoTa = (string)dtrow["MoTa"];
                //sp.MoTa =
                //(dtrow["MoTa"] == DBNull.Value) ? string.Empty : (string)dtrow["MoTa"].ToString();

                sp.HeDieuHanh = (string)dtrow["HeDieuHanh"];
            

                sp.TrongLuong = (int)dtrow["TrongLuong"];
                //int? a = sp.TrongLuong;
                //if (!a.HasValue)
                //{
                //    sp.TrongLuong = 0;
                //}
                sp.TGBaoHanh = (int)dtrow["TGBaoHanh"];
                sp.KichThuoc = (string)dtrow["KichThuoc"];
              //  sp.KichThuoc =
              //(dtrow["KichThuoc"] == DBNull.Value) ? string.Empty : (string)dtrow["KichThuoc"].ToString();
                sp.XuatXu = (string)dtrow["XuatXu"];
                sp.Xoa = dtrow["Xoa"].ToString();
                //if (sp.Xoa == "true")
                //{
                //    sp.Xoa = "a";
                //}
                //else
                //{
                //    sp.Xoa = "b";
                //}
                listProducts.Add(sp);
            }
            return listProducts;
        }

        public SanPham getProduct(string id)
        {

            SanPham sp = new SanPham();
            DataTable dtProducts = new DataTable();
            dtProducts = data.getProduct(id);
            foreach (DataRow dtrow in dtProducts.Rows)
            {
               
                sp.MaSP = (int)dtrow["MaSP"];
                sp.TenSP = (string)dtrow["TenSP"];
                sp.HangSX = (string)dtrow["TenHSX"];
                sp.LoaiSP = (string)dtrow["Ten"];
                sp.DonGia = (decimal)dtrow["DonGia"];

                sp.MoTa = (string)dtrow["MoTa"];
                //sp.MoTa =
                //(dtrow["MoTa"] == DBNull.Value) ? string.Empty : (string)dtrow["MoTa"].ToString();

                sp.HeDieuHanh = (string)dtrow["HeDieuHanh"];


                sp.TrongLuong = (int)dtrow["TrongLuong"];
                //int? a = sp.TrongLuong;
                //if (!a.HasValue)
                //{
                //    sp.TrongLuong = 0;
                //}
                sp.TGBaoHanh = (int)dtrow["TGBaoHanh"];
                sp.KichThuoc = (string)dtrow["KichThuoc"];
                //  sp.KichThuoc =
                //(dtrow["KichThuoc"] == DBNull.Value) ? string.Empty : (string)dtrow["KichThuoc"].ToString();
                sp.XuatXu = (string)dtrow["XuatXu"];
                sp.Xoa = dtrow["Xoa"].ToString();   
            }
            return sp;
        }

        //NAM
        public int removeProduct(string id)
        {
            int result = data.removeProduct(id);
            return result;
        }

        //NAM
        public SanPham pushSanPhamToXemChiTiet(SanPham spp)
        {
            SanPham sp = new SanPham();
            sp.MaSP = spp.MaSP;
            sp.LoaiSP = spp.LoaiSP;
            sp.TenSP = spp.TenSP;
            sp.HangSX = spp.HangSX;
            sp.HeDieuHanh = spp.HeDieuHanh;
            sp.MoTa = spp.MoTa;
            sp.TGBaoHanh = spp.TGBaoHanh;
            sp.KichThuoc = spp.KichThuoc;
            sp.XuatXu = spp.XuatXu;
            sp.DonGia = spp.DonGia;
            return sp;
        }

        public List<SanPham> displayProduct(string VendorId)
        {
            List<SanPham> listProducts = new List<SanPham>();
            DataTable dt = new DataTable();
            dt = data.displayProduct(VendorId);
            foreach (DataRow dr in dt.Rows)
            {
                SanPham product = new SanPham();
                product.MaSP = (int)dr["MaSP"];
                product.MoTaThem = product.MaSP + " | " + (string)dr["TenSP"];
                product.TenSP = (string)dr["TenSP"];
                product.MoTa = dr["MoTa"] == DBNull.Value ? "Không có" : ((string)dr["MoTa"]);

                product.DonGia = (decimal)dr["Gia"];
                listProducts.Add(product);
            }
            return listProducts;
        }


        public SanPham autoset(int ProductId, string VendorId)
        {
            SanPham product = new SanPham();
            product = displayProduct(VendorId).SingleOrDefault(s => s.MaSP == ProductId);
            if (product == null)
                return null;
            return product;
        }
    }
}
