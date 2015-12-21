using BusinessSalesManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceSalesManagement
{
    public partial class SalesInvoiceLineCard : Form
    {
        // Create Delegate and event for update item pass forms
        public event EventCreateItem EventCreatingItem = null;
        public SalesInvoiceLineCard()
        {
            InitializeComponent();
        }


        ItemDAO Item = new ItemDAO();
        private void resetTextbox()
        {
            CBBItemNo.Text = "";
            TBDesc.Text = "";
            TBUnitPrice.Text = "0.00";
            LBStock.Text = "";
        }

        // 08-10-2015
        // --- LH ---
        // display item selections
        private void SalesInvoiceLineCard_Load(object sender, EventArgs e)
        {
            CBBItemNo.DataSource = Item.getItem().ToList();
            CBBItemNo.DisplayMember = "ItemNo";
            CBBItemNo.ValueMember = "ItemNo";
            resetTextbox(); // reset textbox Item No.
        }


        // 08-10-2015
        // --- LH ---
        // display Item No. and update Desc, Unit Price 
        private void CBBItemNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update description and Unit Price
            if (CBBItemNo.Text != "")
            {
                TBDesc.Text = Item.generateItemDesc(int.Parse(CBBItemNo.Text));
                TBUnitPrice.Text = Item.generateItemUnitPrice(int.Parse(CBBItemNo.Text)).ToString();
                LBStock.Text = Item.generateItemStock(int.Parse(CBBItemNo.Text)).ToString();
                
            }
        }



        private void BTNCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 9-10-2015
        // --NP--
        // Pass parameter to InvoiceCardForm
        private void BTOK_Click(object sender, EventArgs e)
        {
            // delegate
            if (TBQuantity.Text != "0")
            {
                if (EventCreatingItem != null)
                {
                    EventCreatingItem(this, new SalesInvoiceLineEventArgs
                    {
                        ItemNo = CBBItemNo.Text,
                        Desc = TBDesc.Text,
                        UnitPrice = TBUnitPrice.Text,
                        Amount = TBAmount.Text,
                        Quantity = TBQuantity.Text,
                        Stock = LBStock.Text,
                    });
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Quantity must has a value.");
            }
        }


        // 08-10-2015
        // --- LH ---
        // trigger Quantity to update Amount
        private void TBQuantity_Validated(object sender, EventArgs e)
        {
            try
            {
                if (Item.generateItemStock(int.Parse(CBBItemNo.Text)) < int.Parse(TBQuantity.Text))
                {
                    MessageBox.Show("Warehouse doesn't enough items.");
                    //Reset Quantity TextBox
                    TBQuantity.Text = "0"; 
                }
                else
                {
                    TBAmount.Text = (decimal.Parse(TBUnitPrice.Text) * decimal.Parse(TBQuantity.Text)).ToString();
                    LBStock.Text = (Item.generateItemStock(int.Parse(CBBItemNo.Text)) - int.Parse(TBQuantity.Text)).ToString();
                    BTOK.Enabled = true;
                }
            }
            catch (Exception)
            {
                if (CBBItemNo.Text == "")
                {
                    MessageBox.Show("Select an item.");
                }
                else
                {
                        MessageBox.Show("Quantity must has a value.");
                        TBQuantity.Text = "0";
                }     
            }
        }
    }
}
