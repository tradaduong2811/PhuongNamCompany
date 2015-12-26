namespace PhuongNamCompany
{
    partial class MH_BoPhanMuaHang
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
            this.btn_DonHang = new System.Windows.Forms.Button();
            this.btn_NhaCungCap = new System.Windows.Forms.Button();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_DonHang
            // 
            this.btn_DonHang.Location = new System.Drawing.Point(67, 85);
            this.btn_DonHang.Name = "btn_DonHang";
            this.btn_DonHang.Size = new System.Drawing.Size(153, 48);
            this.btn_DonHang.TabIndex = 0;
            this.btn_DonHang.Text = "Danh Sách Đơn Hàng";
            this.btn_DonHang.UseVisualStyleBackColor = true;
            this.btn_DonHang.Click += new System.EventHandler(this.btn_DonHang_Click);
            // 
            // btn_NhaCungCap
            // 
            this.btn_NhaCungCap.Location = new System.Drawing.Point(67, 139);
            this.btn_NhaCungCap.Name = "btn_NhaCungCap";
            this.btn_NhaCungCap.Size = new System.Drawing.Size(153, 48);
            this.btn_NhaCungCap.TabIndex = 0;
            this.btn_NhaCungCap.Text = "Danh Sách Nhà Cung Cấp";
            this.btn_NhaCungCap.UseVisualStyleBackColor = true;
            this.btn_NhaCungCap.Click += new System.EventHandler(this.btn_NhaCungCap_Click);
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.Location = new System.Drawing.Point(67, 193);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(153, 48);
            this.btn_SanPham.TabIndex = 0;
            this.btn_SanPham.Text = "Danh Sách Sản Phẩm";
            this.btn_SanPham.UseVisualStyleBackColor = true;
            this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "BỘ PHẬN MUA HÀNG";
            // 
            // MH_BoPhanMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SanPham);
            this.Controls.Add(this.btn_NhaCungCap);
            this.Controls.Add(this.btn_DonHang);
            this.Name = "MH_BoPhanMuaHang";
            this.Text = "MH_BoPhanMuaHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DonHang;
        private System.Windows.Forms.Button btn_NhaCungCap;
        private System.Windows.Forms.Button btn_SanPham;
        private System.Windows.Forms.Label label1;
    }
}