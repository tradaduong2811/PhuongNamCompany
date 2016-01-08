namespace PhuongNamCompany
{
    partial class MH_ChonSanPham
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
            this.lbNhaCungCap = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBGiaTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.CBBMaSanPham = new System.Windows.Forms.ComboBox();
            this.TBMoTa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBTenSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnChon = new System.Windows.Forms.Button();
            this.TBTongTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNhaCungCap
            // 
            this.lbNhaCungCap.AutoSize = true;
            this.lbNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaCungCap.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbNhaCungCap.Location = new System.Drawing.Point(22, 22);
            this.lbNhaCungCap.Name = "lbNhaCungCap";
            this.lbNhaCungCap.Size = new System.Drawing.Size(0, 16);
            this.lbNhaCungCap.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBGiaTien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbSoLuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CBBMaSanPham);
            this.groupBox1.Controls.Add(this.TBMoTa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TBTenSanPham);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 197);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // TBGiaTien
            // 
            this.TBGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBGiaTien.Location = new System.Drawing.Point(258, 161);
            this.TBGiaTien.Name = "TBGiaTien";
            this.TBGiaTien.ReadOnly = true;
            this.TBGiaTien.Size = new System.Drawing.Size(112, 20);
            this.TBGiaTien.TabIndex = 9;
            this.TBGiaTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giá tiền";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(119, 161);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(67, 20);
            this.tbSoLuong.TabIndex = 7;
            this.tbSoLuong.ValueChanged += new System.EventHandler(this.tbSoLuong_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng";
            // 
            // CBBMaSanPham
            // 
            this.CBBMaSanPham.FormattingEnabled = true;
            this.CBBMaSanPham.Location = new System.Drawing.Point(119, 32);
            this.CBBMaSanPham.Name = "CBBMaSanPham";
            this.CBBMaSanPham.Size = new System.Drawing.Size(163, 21);
            this.CBBMaSanPham.TabIndex = 3;
            this.CBBMaSanPham.SelectedIndexChanged += new System.EventHandler(this.CBBMaSanPham_SelectedIndexChanged);
            // 
            // TBMoTa
            // 
            this.TBMoTa.Location = new System.Drawing.Point(119, 102);
            this.TBMoTa.Multiline = true;
            this.TBMoTa.Name = "TBMoTa";
            this.TBMoTa.Size = new System.Drawing.Size(251, 46);
            this.TBMoTa.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mô tả";
            // 
            // TBTenSanPham
            // 
            this.TBTenSanPham.Location = new System.Drawing.Point(119, 66);
            this.TBTenSanPham.Name = "TBTenSanPham";
            this.TBTenSanPham.Size = new System.Drawing.Size(251, 20);
            this.TBTenSanPham.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm";
            // 
            // BtnChon
            // 
            this.BtnChon.Enabled = false;
            this.BtnChon.Location = new System.Drawing.Point(320, 311);
            this.BtnChon.Name = "BtnChon";
            this.BtnChon.Size = new System.Drawing.Size(75, 23);
            this.BtnChon.TabIndex = 2;
            this.BtnChon.Text = "Chọn";
            this.BtnChon.UseVisualStyleBackColor = true;
            this.BtnChon.Click += new System.EventHandler(this.BtnChon_Click);
            // 
            // TBTongTien
            // 
            this.TBTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTongTien.ForeColor = System.Drawing.Color.Red;
            this.TBTongTien.Location = new System.Drawing.Point(237, 260);
            this.TBTongTien.Multiline = true;
            this.TBTongTien.Name = "TBTongTien";
            this.TBTongTien.ReadOnly = true;
            this.TBTongTien.Size = new System.Drawing.Size(158, 31);
            this.TBTongTien.TabIndex = 10;
            this.TBTongTien.Text = "0";
            this.TBTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBTongTien.TextChanged += new System.EventHandler(this.TBTongTien_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(161, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tổng tiền";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // MH_ChonSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 359);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBTongTien);
            this.Controls.Add(this.BtnChon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbNhaCungCap);
            this.Name = "MH_ChonSanPham";
            this.Text = "Chọn sản phẩm";
            this.Load += new System.EventHandler(this.MH_ChonSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhaCungCap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBMoTa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBTenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnChon;
        private System.Windows.Forms.ComboBox CBBMaSanPham;
        private System.Windows.Forms.NumericUpDown tbSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBGiaTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBTongTien;
        private System.Windows.Forms.Label label7;
    }
}