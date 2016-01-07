using BusinessSalesManagement;
using System;
using System.Collections;
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
    public partial class InvoiceCard : Form
    {
        public InvoiceCard()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Business Layer
        /// </summary>
        CustomerDAO cust = new CustomerDAO();
        InvoiceSalesHeaderDAO SIHeader = new InvoiceSalesHeaderDAO();
        ItemDAO Item = new ItemDAO();
        SalesInvoiceLineDAO SILine = new SalesInvoiceLineDAO();
        InvoiceForm InvoiceForm = new InvoiceForm();
        bool CheckReset = false;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetTextbox()
        {
            CBCustomerNo.Text = "";
            TBName.Text = "";
            TBIDCard.Text = "";
            CheckReset = true;
        }

        private void disableElement()
        {
            BTCreateSalesLine.Enabled = false;
        }

        private void InvoiceCard_Load(object sender, EventArgs e)
        {
            if (InvoiceForm.No != "")
            {
                showInvoice(InvoiceForm.No);
                disableAllElement();
            }
            else
            {
                disableElement();
                CBCustomerNo.DataSource = cust.getListCustomer().ToList();
                CBCustomerNo.DisplayMember = "No";
                CBCustomerNo.ValueMember = "Name";
                resetTextbox();
            }
        }

        private void disableAllElement()
        {
            BTOK.Enabled = false;
            BTCreateSalesLine.Enabled = false;
            BTGenerateNo.Enabled = false;
        }

        private void showInvoice(string invoiceno)
        {
            DataTable TableHeader = new DataTable();
            TableHeader = SIHeader.displaySalesHeader(invoiceno);

            // display Sales Header
            foreach (DataRow dr in TableHeader.Rows)
            {
                CBCustomerNo.Text = dr["CustNo"].ToString();
                TBNo.Text = dr["InvoiceNo"].ToString();
                TBName.Text = dr["Name"].ToString();
                TBTotalAmount.Text = dr["TotalAmount"].ToString();
                TBIDCard.Text = dr["CustId"].ToString();
                TBTotalVAT.Text = dr["TotalAmountVAT"].ToString();
            }

            DataTable TableLines = new DataTable();
            TableLines = SILine.displaySalesLineWithInvoiceNo(invoiceno);
            foreach (DataRow dr in TableLines.Rows)
            {
                DataGridViewRow row = (DataGridViewRow)SalesLineGrid.Rows[0].Clone();
                row.Cells[0].Value = dr["ItemNo"].ToString();
                row.Cells[1].Value = dr["Description"].ToString();
                row.Cells[2].Value = dr["Quantity"].ToString();
                row.Cells[3].Value = dr["UnitPrice"].ToString();
                row.Cells[4].Value = dr["Amount"].ToString();
                SalesLineGrid.Rows.Add(row);
            }

            // display Sales Line in Sales Header
            
        }


       
        // --- LH ---
        // 04-10-2015
        private void button1_Click(object sender, EventArgs e)
        {
            if (TBNo.Text == "")
                TBNo.Text = SIHeader.generateInvoiceNo().ToString();
            
        }

        // --- LH ---
        // 04-10-2015
        private void CBCustomerNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBName.Text = SIHeader.generateName(int.Parse(CBCustomerNo.Text));
            TBIDCard.Text = SIHeader.generateIdCard(int.Parse(CBCustomerNo.Text));

           if (CBCustomerNo.Text != "" && CheckReset == true && TBNo.Text != "")
           {
               BTCreateSalesLine.Enabled = true;
           }
        }


        // --- LH ---
        // 04-10-2015
        // this function allows create the invoice
        private void BTOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CBCustomerNo.Text))
            {
                try
                {
                    SIHeader.insertSalesHeader(CBCustomerNo.Text, TBIDCard.Text, TBTotalAmount.Text,
                                               TBTotalVAT.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Check again your invoice header.");
                }
                try
                {
                    for (int i = 0; i < SalesLineGrid.Rows.Count - 1; i++)
                    {
                        //insert sales line each rows in datagridview
                        SILine.insertSalesLine(SalesLineGrid.Rows[i].Cells[0].Value.ToString(), SIHeader.getInvoiceNo().ToString(),
                                           SalesLineGrid.Rows[i].Cells[2].Value.ToString(), SalesLineGrid.Rows[i].Cells[3].Value.ToString(),
                                           SalesLineGrid.Rows[i].Cells[4].Value.ToString());

                        // update item stock
                        Item.updateItemStock(SalesLineGrid.Rows[i].Cells[0].Value.ToString(),
                                             SalesLineGrid.Rows[i].Cells[5].Value.ToString());
                    }    
                }
                catch (Exception)
                {
                    MessageBox.Show("Check again your invoice lines.");
                }
                MessageBox.Show("Your invoice has been created.");
                this.Close();
            }
        }


        // __NP__
        //Update sales invoice line 
        private void BTCreateSalesLine_Click(object sender, EventArgs e)
        {
            if (TBNo.Text == "")
            {
                MessageBox.Show("Invoice No. field doesn't has value.");
                return;
            }
            if (CBCustomerNo.Text == "")
            {
                MessageBox.Show("Customer No. field doesn't has value.");
                return;
            }
            
            // delegate event passes invoice lines to Invoice Form
            SalesInvoiceLineCard LineForm = new SalesInvoiceLineCard();
            LineForm.EventCreatingItem += LineForm_EventCreatingItem;
            LineForm.ShowDialog();
        }
        void LineForm_EventCreatingItem(object sender, SalesInvoiceLineEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.ItemNo))
            {
                DataGridViewRow row = (DataGridViewRow)SalesLineGrid.Rows[0].Clone();
                row.Cells[0].Value = e.ItemNo;
                row.Cells[1].Value = e.Desc;
                row.Cells[2].Value = e.Quantity;
                row.Cells[3].Value = e.UnitPrice;
                row.Cells[4].Value = e.Amount;
                row.Cells[5].Value = e.Stock;
                SalesLineGrid.Rows.Add(row);
                calculateTotalAmount();
            }
            
            
        }

        private void calculateTotalAmount()
        {
            decimal TotalAmount = 0;
            for (int i = 0; i < SalesLineGrid.Rows.Count - 1; i++)
            {
                TotalAmount = TotalAmount + decimal.Parse(SalesLineGrid.Rows[i].Cells[4].Value.ToString());
            }
            TBTotalAmount.Text = TotalAmount.ToString();
        }





  
 

        private void SalesLineGrid_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            decimal TotalAmount = 0;
            for (int i = 0; i < SalesLineGrid.Rows.Count - 1; i++)
            {
                TotalAmount = TotalAmount + decimal.Parse(SalesLineGrid.Rows[i].Cells[4].Value.ToString());
            }
            TBTotalAmount.Text = TotalAmount.ToString();
        }

        private void TBTotalAmount_TextChanged(object sender, EventArgs e)
        {
            TBTotalVAT.Text = (decimal.Parse(TBTotalAmount.Text) + 
                decimal.Parse(TBTotalAmount.Text) * 10 / 100).ToString();
        }


      
    }
}
