using DataAccessSalesManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessSalesManagement
{
    public class ItemDAO
    {
        public DataAccess dataaccess = new DataAccess();

        public List<ItemDTO> getItem()
        {
            List<ItemDTO> ListItem = new List<ItemDTO>();
            DataTable ItemTable = new DataTable();
            ItemTable = dataaccess.displayItem(); // take all items from database
            foreach (DataRow dr in ItemTable.Rows)
            {
                ItemDTO item = new ItemDTO();
                item.ItemNo =(int)(dr["ItemNo"]);
                item.Description = dr["Description"].ToString();
                item.UnitPrice = decimal.Parse(dr["UnitPrice"].ToString());
                item.Stock = int.Parse(dr["Stock"].ToString());
                ListItem.Add(item);

            }
            return ListItem.ToList();
        }

        public string generateItemDesc(int ItemNo)
        {
            ItemDAO item = new ItemDAO();
            string Desc = (from t in item.getItem()
                           where t.ItemNo == ItemNo
                           select t).FirstOrDefault().Description;
            return Desc;
        }
        public decimal generateItemUnitPrice(int ItemNo)
        {
            ItemDAO item = new ItemDAO();
            decimal Price = (from t in item.getItem()
                           where t.ItemNo == ItemNo
                           select t).FirstOrDefault().UnitPrice;
            return Price;
        }

        public int generateItemStock(int ItemNo)
        {
            ItemDAO item = new ItemDAO();
            int stock = (from t in item.getItem()
                             where t.ItemNo == ItemNo
                             select t).FirstOrDefault().Stock;
            return stock;
        }

        public void updateItemStock(string No, string Stock)
        {
            ItemDTO item = new ItemDTO();
            item.ItemNo = int.Parse(No);
            item.Stock = int.Parse(Stock);
            dataaccess.updateItemStock(item.ItemNo, item.Stock);
        }
    }
}
