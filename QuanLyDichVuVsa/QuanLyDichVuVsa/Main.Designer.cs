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
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "VISA";
            // 
            // bTDangKí
            // 
            this.bTDangKí.Location = new System.Drawing.Point(419, 142);
            this.bTDangKí.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTDangKí.Name = "bTDangKí";
            this.bTDangKí.Size = new System.Drawing.Size(153, 49);
            this.bTDangKí.TabIndex = 1;
            this.bTDangKí.Text = "ĐĂNG KÍ";
            this.bTDangKí.UseVisualStyleBackColor = true;
            // 
            // bTKhachHang
            // 
            this.bTKhachHang.Location = new System.Drawing.Point(419, 222);
            this.bTKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTKhachHang.Name = "bTKhachHang";
            this.bTKhachHang.Size = new System.Drawing.Size(153, 48);
            this.bTKhachHang.TabIndex = 2;
            this.bTKhachHang.Text = "KHÁCH HÀNG";
            this.bTKhachHang.UseVisualStyleBackColor = true;
            // 
            // bTDoanhThu
            // 
            this.bTDoanhThu.Location = new System.Drawing.Point(419, 306);
            this.bTDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTDoanhThu.Name = "bTDoanhThu";
            this.bTDoanhThu.Size = new System.Drawing.Size(153, 49);
            this.bTDoanhThu.TabIndex = 3;
            this.bTDoanhThu.Text = "DOANH THU";
            this.bTDoanhThu.UseVisualStyleBackColor = true;
            // 
            // bTThoat
            // 
            this.bTThoat.Location = new System.Drawing.Point(419, 393);
            this.bTThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTThoat.Name = "bTThoat";
            this.bTThoat.Size = new System.Drawing.Size(153, 48);
            this.bTThoat.TabIndex = 4;
            this.bTThoat.Text = "THOÁT";
            this.bTThoat.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bTThoat);
            this.Controls.Add(this.bTDoanhThu);
            this.Controls.Add(this.bTKhachHang);
            this.Controls.Add(this.bTDangKí);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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