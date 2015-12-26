namespace PhuongNamCompany
{
    partial class MH_Chinh
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
            this.btn_BoPhanBanHang = new System.Windows.Forms.Button();
            this.btn_BoPhanKho = new System.Windows.Forms.Button();
            this.btn_Marketing = new System.Windows.Forms.Button();
            this.btn_BoPhanMuaHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_BoPhanBanHang
            // 
            this.btn_BoPhanBanHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_BoPhanBanHang.Location = new System.Drawing.Point(757, 525);
            this.btn_BoPhanBanHang.Margin = new System.Windows.Forms.Padding(5);
            this.btn_BoPhanBanHang.Name = "btn_BoPhanBanHang";
            this.btn_BoPhanBanHang.Padding = new System.Windows.Forms.Padding(5);
            this.btn_BoPhanBanHang.Size = new System.Drawing.Size(200, 80);
            this.btn_BoPhanBanHang.TabIndex = 0;
            this.btn_BoPhanBanHang.Text = "Bộ Phận Bán Hàng";
            this.btn_BoPhanBanHang.UseVisualStyleBackColor = true;
            this.btn_BoPhanBanHang.Click += new System.EventHandler(this.btn_BoPhanBanHang_Click);
            // 
            // btn_BoPhanKho
            // 
            this.btn_BoPhanKho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_BoPhanKho.Location = new System.Drawing.Point(757, 317);
            this.btn_BoPhanKho.Margin = new System.Windows.Forms.Padding(5);
            this.btn_BoPhanKho.Name = "btn_BoPhanKho";
            this.btn_BoPhanKho.Padding = new System.Windows.Forms.Padding(5);
            this.btn_BoPhanKho.Size = new System.Drawing.Size(200, 80);
            this.btn_BoPhanKho.TabIndex = 1;
            this.btn_BoPhanKho.Text = "Bộ Phận Kho";
            this.btn_BoPhanKho.UseVisualStyleBackColor = true;
            this.btn_BoPhanKho.Click += new System.EventHandler(this.btn_BoPhanKho_Click);
            // 
            // btn_Marketing
            // 
            this.btn_Marketing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Marketing.Location = new System.Drawing.Point(757, 421);
            this.btn_Marketing.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Marketing.Name = "btn_Marketing";
            this.btn_Marketing.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Marketing.Size = new System.Drawing.Size(200, 80);
            this.btn_Marketing.TabIndex = 2;
            this.btn_Marketing.Text = "Bộ Phận Marketing";
            this.btn_Marketing.UseVisualStyleBackColor = true;
            this.btn_Marketing.Click += new System.EventHandler(this.btn_Marketing_Click);
            // 
            // btn_BoPhanMuaHang
            // 
            this.btn_BoPhanMuaHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_BoPhanMuaHang.Location = new System.Drawing.Point(757, 213);
            this.btn_BoPhanMuaHang.Margin = new System.Windows.Forms.Padding(5);
            this.btn_BoPhanMuaHang.Name = "btn_BoPhanMuaHang";
            this.btn_BoPhanMuaHang.Padding = new System.Windows.Forms.Padding(5);
            this.btn_BoPhanMuaHang.Size = new System.Drawing.Size(200, 80);
            this.btn_BoPhanMuaHang.TabIndex = 3;
            this.btn_BoPhanMuaHang.Text = "Bộ Phận Mua Hàng";
            this.btn_BoPhanMuaHang.UseVisualStyleBackColor = true;
            this.btn_BoPhanMuaHang.Click += new System.EventHandler(this.btn_BoPhanMuaHang_Click);
            // 
            // MH_Chinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 839);
            this.Controls.Add(this.btn_BoPhanMuaHang);
            this.Controls.Add(this.btn_Marketing);
            this.Controls.Add(this.btn_BoPhanKho);
            this.Controls.Add(this.btn_BoPhanBanHang);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MH_Chinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cty Phương Nam";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_BoPhanBanHang;
        private System.Windows.Forms.Button btn_BoPhanKho;
        private System.Windows.Forms.Button btn_Marketing;
        private System.Windows.Forms.Button btn_BoPhanMuaHang;
    }
}

