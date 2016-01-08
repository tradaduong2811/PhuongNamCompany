using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNamCompany
{
        public delegate void EventCreateItem(object sender, PurchaseLineLineEventArgs e);

        public delegate void EventDisplayPurchaseLine(object sender, PurchaseLine e);
        public class PurchaseLineLineEventArgs : EventArgs
        {
            public string MaSP { get; set; }
            public string TenSP { get; set; }
            public string MoTa { get; set; }
            public string SoLuong { get; set; }
            public string GiaTien { get; set; }
            public string TongTien { get; set; }
        }

        public class PurchaseLine : EventArgs
        {
            public string InvoiceNo { get; set; }
        }
}
