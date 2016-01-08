namespace InterfaceSalesManagement
{
    partial class InvoiceCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceCard));
            this.label1 = new System.Windows.Forms.Label();
            this.InvoiceHeader = new System.Windows.Forms.GroupBox();
            this.BTCreateSalesLine = new System.Windows.Forms.Button();
            this.CBCustomerNo = new System.Windows.Forms.ComboBox();
            this.BTGenerateNo = new System.Windows.Forms.Button();
            this.TBIDCard = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SalesLineGrid = new System.Windows.Forms.DataGridView();
            this.ItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBTotalAmount = new System.Windows.Forms.TextBox();
            this.TBTotalVAT = new System.Windows.Forms.TextBox();
            this.BTOK = new System.Windows.Forms.Button();
            this.InvoiceHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesLineGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Invoice No.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InvoiceHeader
            // 
            this.InvoiceHeader.Controls.Add(this.BTCreateSalesLine);
            this.InvoiceHeader.Controls.Add(this.CBCustomerNo);
            this.InvoiceHeader.Controls.Add(this.BTGenerateNo);
            this.InvoiceHeader.Controls.Add(this.TBIDCard);
            this.InvoiceHeader.Controls.Add(this.TBName);
            this.InvoiceHeader.Controls.Add(this.label4);
            this.InvoiceHeader.Controls.Add(this.label3);
            this.InvoiceHeader.Controls.Add(this.label2);
            this.InvoiceHeader.Controls.Add(this.TBNo);
            this.InvoiceHeader.Controls.Add(this.label1);
            this.InvoiceHeader.Location = new System.Drawing.Point(12, 12);
            this.InvoiceHeader.Name = "InvoiceHeader";
            this.InvoiceHeader.Size = new System.Drawing.Size(566, 133);
            this.InvoiceHeader.TabIndex = 3;
            this.InvoiceHeader.TabStop = false;
            this.InvoiceHeader.Text = "Invoice Header";
            // 
            // BTCreateSalesLine
            // 
            this.BTCreateSalesLine.Enabled = false;
            this.BTCreateSalesLine.Location = new System.Drawing.Point(453, 93);
            this.BTCreateSalesLine.Margin = new System.Windows.Forms.Padding(2);
            this.BTCreateSalesLine.Name = "BTCreateSalesLine";
            this.BTCreateSalesLine.Size = new System.Drawing.Size(92, 26);
            this.BTCreateSalesLine.TabIndex = 10;
            this.BTCreateSalesLine.Text = "Create";
            this.BTCreateSalesLine.UseVisualStyleBackColor = true;
            this.BTCreateSalesLine.Click += new System.EventHandler(this.BTCreateSalesLine_Click);
            // 
            // CBCustomerNo
            // 
            this.CBCustomerNo.FormattingEnabled = true;
            this.CBCustomerNo.Location = new System.Drawing.Point(115, 54);
            this.CBCustomerNo.Name = "CBCustomerNo";
            this.CBCustomerNo.Size = new System.Drawing.Size(128, 21);
            this.CBCustomerNo.TabIndex = 4;
            this.CBCustomerNo.SelectedIndexChanged += new System.EventHandler(this.CBCustomerNo_SelectedIndexChanged);
            // 
            // BTGenerateNo
            // 
            this.BTGenerateNo.Location = new System.Drawing.Point(249, 26);
            this.BTGenerateNo.Name = "BTGenerateNo";
            this.BTGenerateNo.Size = new System.Drawing.Size(25, 23);
            this.BTGenerateNo.TabIndex = 2;
            this.BTGenerateNo.Text = "...";
            this.BTGenerateNo.UseVisualStyleBackColor = true;
            this.BTGenerateNo.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBIDCard
            // 
            this.TBIDCard.Location = new System.Drawing.Point(355, 53);
            this.TBIDCard.Name = "TBIDCard";
            this.TBIDCard.Size = new System.Drawing.Size(128, 20);
            this.TBIDCard.TabIndex = 9;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(355, 25);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(190, 20);
            this.TBName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer No.";
            // 
            // TBNo
            // 
            this.TBNo.Location = new System.Drawing.Point(115, 27);
            this.TBNo.Name = "TBNo";
            this.TBNo.Size = new System.Drawing.Size(128, 20);
            this.TBNo.TabIndex = 1;
            this.TBNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SalesLineGrid);
            this.groupBox1.Location = new System.Drawing.Point(13, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Invoice Line";
            // 
            // SalesLineGrid
            // 
            this.SalesLineGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalesLineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesLineGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNo,
            this.Desc,
            this.Quantity,
            this.Price,
            this.Amount,
            this.Column1});
            this.SalesLineGrid.Location = new System.Drawing.Point(11, 19);
            this.SalesLineGrid.Name = "SalesLineGrid";
            this.SalesLineGrid.Size = new System.Drawing.Size(540, 116);
            this.SalesLineGrid.TabIndex = 2;
            this.SalesLineGrid.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesLineGrid_RowValidated);
            // 
            // ItemNo
            // 
            this.ItemNo.HeaderText = "Item No";
            this.ItemNo.Name = "ItemNo";
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Description";
            this.Desc.Name = "Desc";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Stock";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Amount VAT (10%)";
            // 
            // TBTotalAmount
            // 
            this.TBTotalAmount.Enabled = false;
            this.TBTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTotalAmount.Location = new System.Drawing.Point(465, 329);
            this.TBTotalAmount.Name = "TBTotalAmount";
            this.TBTotalAmount.Size = new System.Drawing.Size(114, 22);
            this.TBTotalAmount.TabIndex = 7;
            this.TBTotalAmount.Text = "0.00";
            this.TBTotalAmount.TextChanged += new System.EventHandler(this.TBTotalAmount_TextChanged);
            // 
            // TBTotalVAT
            // 
            this.TBTotalVAT.Enabled = false;
            this.TBTotalVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTotalVAT.Location = new System.Drawing.Point(465, 358);
            this.TBTotalVAT.Name = "TBTotalVAT";
            this.TBTotalVAT.Size = new System.Drawing.Size(113, 22);
            this.TBTotalVAT.TabIndex = 8;
            this.TBTotalVAT.Text = "0.00";
            // 
            // BTOK
            // 
            this.BTOK.Location = new System.Drawing.Point(472, 397);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(91, 30);
            this.BTOK.TabIndex = 9;
            this.BTOK.Text = "OK";
            this.BTOK.UseVisualStyleBackColor = true;
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // InvoiceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(590, 435);
            this.Controls.Add(this.BTOK);
            this.Controls.Add(this.TBTotalVAT);
            this.Controls.Add(this.TBTotalAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InvoiceHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceCard";
            this.Text = "Invoice Card";
            this.Load += new System.EventHandler(this.InvoiceCard_Load);
            this.InvoiceHeader.ResumeLayout(false);
            this.InvoiceHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesLineGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox InvoiceHeader;
        private System.Windows.Forms.TextBox TBNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBIDCard;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTGenerateNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView SalesLineGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBTotalAmount;
        private System.Windows.Forms.TextBox TBTotalVAT;
        private System.Windows.Forms.ComboBox CBCustomerNo;
        private System.Windows.Forms.Button BTOK;
        private System.Windows.Forms.Button BTCreateSalesLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

