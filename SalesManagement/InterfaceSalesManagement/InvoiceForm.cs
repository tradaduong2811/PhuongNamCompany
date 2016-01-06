using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessSalesManagement;

namespace InterfaceSalesManagement
{
    public partial class InvoiceForm : Form
    {

        public InvoiceForm()
        {
            InitializeComponent();
        }
        public static string No = string.Empty;
        InvoiceSalesHeaderDAO invoice = new InvoiceSalesHeaderDAO();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            DGInvoice.DataSource = invoice.displayListInvoice();
        }

        private void BTRefresh_Click(object sender, EventArgs e)
        {
            DGInvoice.DataSource = invoice.displayListInvoice();   
        }

        private void BTSearch_Click(object sender, EventArgs e)
        {
            DGInvoice.DataSource = invoice.searchInvoice(TBSearch.Text);
        }

        private void BTNew_Click(object sender, EventArgs e)
        {
            No = "";
            InvoiceCard form = new InvoiceCard();
            form.ShowDialog();
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DGInvoice.SelectedRows.Count; i++)
            {
                String InvoiceNo = DGInvoice.SelectedRows[i].Cells[0].Value.ToString();
                if (InvoiceNo != "")
                {
                    DialogResult dialogresult = MessageBox.Show("Do you want to delete Invoice No. " +InvoiceNo+"?",
                                                "Delete?", MessageBoxButtons.OKCancel,MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button2);
                    if (dialogresult == DialogResult.OK)
                    {
                        if (invoice.deleteInvoice(int.Parse(InvoiceNo)) == true)
                        {
                            MessageBox.Show("Invoice No. " + InvoiceNo + " has deleted");
                            DGInvoice.DataSource = invoice.displayListInvoice();   
                        }
                    }
                }
            }
        }

        private void BTView_Click(object sender, EventArgs e)
        {
            InvoiceCard InvoiceCard = new InvoiceCard();
            for (int i = 0; i < DGInvoice.SelectedRows.Count; i++)
            {
                String InvoiceNo_Temp = DGInvoice.SelectedRows[i].Cells[0].Value.ToString();
                if (InvoiceNo_Temp != null)
                {
                    No = InvoiceNo_Temp;
                    InvoiceCard.ShowDialog();
                } 
            }
        }
    }
}
