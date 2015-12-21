namespace InterfaceSalesManagement
{
    partial class SalesInvoiceLineCard
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
            this.TBDesc = new System.Windows.Forms.TextBox();
            this.CBBItemNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBUnitPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBAmount = new System.Windows.Forms.TextBox();
            this.BTOK = new System.Windows.Forms.Button();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LBStock = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBDesc
            // 
            this.TBDesc.Location = new System.Drawing.Point(98, 58);
            this.TBDesc.Margin = new System.Windows.Forms.Padding(2);
            this.TBDesc.Name = "TBDesc";
            this.TBDesc.Size = new System.Drawing.Size(175, 20);
            this.TBDesc.TabIndex = 1;
            // 
            // CBBItemNo
            // 
            this.CBBItemNo.FormattingEnabled = true;
            this.CBBItemNo.Location = new System.Drawing.Point(98, 23);
            this.CBBItemNo.Margin = new System.Windows.Forms.Padding(2);
            this.CBBItemNo.Name = "CBBItemNo";
            this.CBBItemNo.Size = new System.Drawing.Size(92, 21);
            this.CBBItemNo.TabIndex = 0;
            this.CBBItemNo.SelectedIndexChanged += new System.EventHandler(this.CBBItemNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // TBQuantity
            // 
            this.TBQuantity.Location = new System.Drawing.Point(98, 93);
            this.TBQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.TBQuantity.Name = "TBQuantity";
            this.TBQuantity.Size = new System.Drawing.Size(70, 20);
            this.TBQuantity.TabIndex = 5;
            this.TBQuantity.Text = "0.00";
            this.TBQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBQuantity.Validated += new System.EventHandler(this.TBQuantity_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unit Price";
            // 
            // TBUnitPrice
            // 
            this.TBUnitPrice.Location = new System.Drawing.Point(98, 124);
            this.TBUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.TBUnitPrice.Name = "TBUnitPrice";
            this.TBUnitPrice.Size = new System.Drawing.Size(70, 20);
            this.TBUnitPrice.TabIndex = 7;
            this.TBUnitPrice.Text = "0.00";
            this.TBUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // TBAmount
            // 
            this.TBAmount.Location = new System.Drawing.Point(98, 156);
            this.TBAmount.Margin = new System.Windows.Forms.Padding(2);
            this.TBAmount.Name = "TBAmount";
            this.TBAmount.Size = new System.Drawing.Size(70, 20);
            this.TBAmount.TabIndex = 8;
            this.TBAmount.Text = "0.00";
            this.TBAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTOK
            // 
            this.BTOK.Enabled = false;
            this.BTOK.Location = new System.Drawing.Point(161, 188);
            this.BTOK.Margin = new System.Windows.Forms.Padding(2);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(56, 19);
            this.BTOK.TabIndex = 6;
            this.BTOK.Text = "OK";
            this.BTOK.UseVisualStyleBackColor = true;
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // BTNCancel
            // 
            this.BTNCancel.Location = new System.Drawing.Point(221, 188);
            this.BTNCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(56, 19);
            this.BTNCancel.TabIndex = 10;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.UseVisualStyleBackColor = true;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stock:";
            // 
            // LBStock
            // 
            this.LBStock.AutoSize = true;
            this.LBStock.Location = new System.Drawing.Point(214, 96);
            this.LBStock.Name = "LBStock";
            this.LBStock.Size = new System.Drawing.Size(13, 13);
            this.LBStock.TabIndex = 13;
            this.LBStock.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "PCS";
            // 
            // SalesInvoiceLineCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LBStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.BTOK);
            this.Controls.Add(this.TBAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBUnitPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBBItemNo);
            this.Controls.Add(this.TBDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(300, 260);
            this.MinimumSize = new System.Drawing.Size(300, 260);
            this.Name = "SalesInvoiceLineCard";
            this.Text = "Sales Invoice Line";
            this.Load += new System.EventHandler(this.SalesInvoiceLineCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBDesc;
        private System.Windows.Forms.ComboBox CBBItemNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBUnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBAmount;
        private System.Windows.Forms.Button BTOK;
        private System.Windows.Forms.Button BTNCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBStock;
        private System.Windows.Forms.Label label8;
    }
}