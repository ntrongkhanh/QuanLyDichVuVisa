namespace QuanLyDichVuVsa
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.bTDangKí = new System.Windows.Forms.Button();
            this.bTKhachHang = new System.Windows.Forms.Button();
            this.bTDoanhThu = new System.Windows.Forms.Button();
            this.bTThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(244, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "VISA";
            // 
            // bTDangKí
            // 
            this.bTDangKí.BackColor = System.Drawing.Color.White;
            this.bTDangKí.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bTDangKí.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTDangKí.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bTDangKí.FlatAppearance.BorderSize = 5;
            this.bTDangKí.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bTDangKí.Location = new System.Drawing.Point(314, 115);
            this.bTDangKí.Name = "bTDangKí";
            this.bTDangKí.Size = new System.Drawing.Size(115, 40);
            this.bTDangKí.TabIndex = 1;
            this.bTDangKí.Text = "ĐĂNG KÍ";
            this.bTDangKí.UseVisualStyleBackColor = false;
            // 
            // bTKhachHang
            // 
            this.bTKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTKhachHang.Location = new System.Drawing.Point(314, 180);
            this.bTKhachHang.Name = "bTKhachHang";
            this.bTKhachHang.Size = new System.Drawing.Size(115, 39);
            this.bTKhachHang.TabIndex = 2;
            this.bTKhachHang.Text = "KHÁCH HÀNG";
            this.bTKhachHang.UseVisualStyleBackColor = true;
            // 
            // bTDoanhThu
            // 
            this.bTDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTDoanhThu.Location = new System.Drawing.Point(314, 249);
            this.bTDoanhThu.Name = "bTDoanhThu";
            this.bTDoanhThu.Size = new System.Drawing.Size(115, 40);
            this.bTDoanhThu.TabIndex = 3;
            this.bTDoanhThu.Text = "DOANH THU";
            this.bTDoanhThu.UseVisualStyleBackColor = true;
            // 
            // bTThoat
            // 
            this.bTThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTThoat.Location = new System.Drawing.Point(314, 319);
            this.bTThoat.Name = "bTThoat";
            this.bTThoat.Size = new System.Drawing.Size(115, 39);
            this.bTThoat.TabIndex = 4;
            this.bTThoat.Text = "THOÁT";
            this.bTThoat.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::QuanLyDichVuVsa.Properties.Resources.Hình_nền_máy_tính_Gradient_màu_xanh;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bTThoat);
            this.Controls.Add(this.bTDoanhThu);
            this.Controls.Add(this.bTKhachHang);
            this.Controls.Add(this.bTDangKí);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Dịch Vụ Visa ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bTDangKí;
        private System.Windows.Forms.Button bTKhachHang;
        private System.Windows.Forms.Button bTDoanhThu;
        private System.Windows.Forms.Button bTThoat;
    }
}