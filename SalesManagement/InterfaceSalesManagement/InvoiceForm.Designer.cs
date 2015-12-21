namespace InterfaceSalesManagement
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.BTSearch = new System.Windows.Forms.Button();
            this.DGInvoice = new System.Windows.Forms.DataGridView();
            this.LBInvoice = new System.Windows.Forms.Label();
            this.BTDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BTRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // TBSearch
            // 
            this.TBSearch.AccessibleDescription = "";
            this.TBSearch.Location = new System.Drawing.Point(353, 12);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(185, 20);
            this.TBSearch.TabIndex = 6;
            // 
            // BTSearch
            // 
            this.BTSearch.Image = ((System.Drawing.Image)(resources.GetObject("BTSearch.Image")));
            this.BTSearch.Location = new System.Drawing.Point(544, 6);
            this.BTSearch.Name = "BTSearch";
            this.BTSearch.Size = new System.Drawing.Size(35, 35);
            this.BTSearch.TabIndex = 7;
            this.BTSearch.UseVisualStyleBackColor = true;
            this.BTSearch.Click += new System.EventHandler(this.BTSearch_Click);
            // 
            // DGInvoice
            // 
            this.DGInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGInvoice.Location = new System.Drawing.Point(12, 91);
            this.DGInvoice.Name = "DGInvoice";
            this.DGInvoice.Size = new System.Drawing.Size(562, 177);
            this.DGInvoice.TabIndex = 2;
            this.DGInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LBInvoice
            // 
            this.LBInvoice.AutoSize = true;
            this.LBInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBInvoice.ForeColor = System.Drawing.Color.DarkRed;
            this.LBInvoice.Location = new System.Drawing.Point(172, 53);
            this.LBInvoice.Name = "LBInvoice";
            this.LBInvoice.Size = new System.Drawing.Size(213, 25);
            this.LBInvoice.TabIndex = 3;
            this.LBInvoice.Text = "Posted Sales Invoice";
            // 
            // BTDelete
            // 
            this.BTDelete.FlatAppearance.BorderSize = 0;
            this.BTDelete.Image = ((System.Drawing.Image)(resources.GetObject("BTDelete.Image")));
            this.BTDelete.Location = new System.Drawing.Point(161, 4);
            this.BTDelete.Name = "BTDelete";
            this.BTDelete.Size = new System.Drawing.Size(35, 35);
            this.BTDelete.TabIndex = 4;
            this.BTDelete.UseVisualStyleBackColor = true;
            this.BTDelete.Click += new System.EventHandler(this.BTDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Delete";
            // 
            // BTNew
            // 
            this.BTNew.FlatAppearance.BorderSize = 0;
            this.BTNew.Image = ((System.Drawing.Image)(resources.GetObject("BTNew.Image")));
            this.BTNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNew.Location = new System.Drawing.Point(12, 4);
            this.BTNew.Name = "BTNew";
            this.BTNew.Size = new System.Drawing.Size(35, 40);
            this.BTNew.TabIndex = 2;
            this.BTNew.UseVisualStyleBackColor = true;
            this.BTNew.Click += new System.EventHandler(this.BTNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "New";
            // 
            // BTRefresh
            // 
            this.BTRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BTRefresh.Image")));
            this.BTRefresh.Location = new System.Drawing.Point(248, 4);
            this.BTRefresh.Name = "BTRefresh";
            this.BTRefresh.Size = new System.Drawing.Size(35, 35);
            this.BTRefresh.TabIndex = 5;
            this.BTRefresh.UseVisualStyleBackColor = true;
            this.BTRefresh.Click += new System.EventHandler(this.BTRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Refresh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "View";
            // 
            // BTView
            // 
            this.BTView.FlatAppearance.BorderSize = 0;
            this.BTView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BTView.Image = ((System.Drawing.Image)(resources.GetObject("BTView.Image")));
            this.BTView.Location = new System.Drawing.Point(83, 4);
            this.BTView.Name = "BTView";
            this.BTView.Size = new System.Drawing.Size(35, 37);
            this.BTView.TabIndex = 3;
            this.BTView.UseVisualStyleBackColor = true;
            this.BTView.Click += new System.EventHandler(this.BTView_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(590, 293);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTView);
            this.Controls.Add(this.BTDelete);
            this.Controls.Add(this.LBInvoice);
            this.Controls.Add(this.DGInvoice);
            this.Controls.Add(this.BTSearch);
            this.Controls.Add(this.TBSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InvoiceForm";
            this.Text = "Invoice Form";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Button BTSearch;
        private System.Windows.Forms.DataGridView DGInvoice;
        private System.Windows.Forms.Label LBInvoice;
        private System.Windows.Forms.Button BTDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTView;
    }
}