namespace QuanLyDichVuViSa
{
    partial class FrmUpdateKhachHang
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboQuocTich = new System.Windows.Forms.ComboBox();
            this.tbSHC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPassport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.btnAvatar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.pBPassport = new System.Windows.Forms.PictureBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pBAvatar = new System.Windows.Forms.PictureBox();
            this.btnDK = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPassport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Red;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(759, 427);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 31);
            this.btnDong.TabIndex = 66;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.BtnDong_Click);
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Location = new System.Drawing.Point(413, 427);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(135, 31);
            this.btnThayDoi.TabIndex = 65;
            this.btnThayDoi.Text = "Thay đổi thông tin";
            this.btnThayDoi.UseVisualStyleBackColor = true;
            this.btnThayDoi.Click += new System.EventHandler(this.BtnThayDoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(577, 427);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(135, 31);
            this.btnXoa.TabIndex = 72;
            this.btnXoa.Text = "Xóa khách hàng";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(413, 428);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(135, 31);
            this.btnLuu.TabIndex = 73;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(577, 427);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(135, 31);
            this.btnHuy.TabIndex = 75;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 35);
            this.label1.TabIndex = 50;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 48);
            this.panel2.TabIndex = 74;
            // 
            // comboQuocTich
            // 
            this.comboQuocTich.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboQuocTich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboQuocTich.FormattingEnabled = true;
            this.comboQuocTich.Location = new System.Drawing.Point(413, 236);
            this.comboQuocTich.Name = "comboQuocTich";
            this.comboQuocTich.Size = new System.Drawing.Size(420, 21);
            this.comboQuocTich.TabIndex = 95;
            this.comboQuocTich.TextChanged += new System.EventHandler(this.ComboQuocTich_TextChanged);
            // 
            // tbSHC
            // 
            this.tbSHC.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbSHC.Location = new System.Drawing.Point(413, 116);
            this.tbSHC.Name = "tbSHC";
            this.tbSHC.Size = new System.Drawing.Size(231, 21);
            this.tbSHC.TabIndex = 94;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "Số hộ chiếu";
            // 
            // btnPassport
            // 
            this.btnPassport.Location = new System.Drawing.Point(413, 400);
            this.btnPassport.Name = "btnPassport";
            this.btnPassport.Size = new System.Drawing.Size(78, 22);
            this.btnPassport.TabIndex = 92;
            this.btnPassport.Text = "Chọn tệp";
            this.btnPassport.UseVisualStyleBackColor = true;
            this.btnPassport.Click += new System.EventHandler(this.BtnPassport_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioNu);
            this.panel1.Controls.Add(this.radioNam);
            this.panel1.Location = new System.Drawing.Point(719, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 20);
            this.panel1.TabIndex = 91;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(73, 1);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(39, 17);
            this.radioNu.TabIndex = 1;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(3, 1);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(46, 17);
            this.radioNam.TabIndex = 0;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // btnAvatar
            // 
            this.btnAvatar.Location = new System.Drawing.Point(178, 236);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(76, 23);
            this.btnAvatar.TabIndex = 90;
            this.btnAvatar.Text = "Chọn ảnh";
            this.btnAvatar.UseVisualStyleBackColor = true;
            this.btnAvatar.Click += new System.EventHandler(this.BtnAvatar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "HÌNH ẢNH";
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySinh.Location = new System.Drawing.Point(413, 146);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(231, 21);
            this.dateNgaySinh.TabIndex = 88;
            // 
            // pBPassport
            // 
            this.pBPassport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBPassport.Location = new System.Drawing.Point(413, 266);
            this.pBPassport.Name = "pBPassport";
            this.pBPassport.Size = new System.Drawing.Size(420, 128);
            this.pBPassport.TabIndex = 87;
            this.pBPassport.TabStop = false;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(413, 206);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(420, 21);
            this.tbSDT.TabIndex = 86;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(413, 176);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(420, 21);
            this.tbEmail.TabIndex = 85;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(413, 87);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(420, 21);
            this.tbName.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Quốc tịch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Passport";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Họ Tên";
            // 
            // pBAvatar
            // 
            this.pBAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBAvatar.Location = new System.Drawing.Point(159, 82);
            this.pBAvatar.Name = "pBAvatar";
            this.pBAvatar.Size = new System.Drawing.Size(113, 149);
            this.pBAvatar.TabIndex = 76;
            this.pBAvatar.TabStop = false;
            // 
            // btnDK
            // 
            this.btnDK.Location = new System.Drawing.Point(159, 427);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(135, 31);
            this.btnDK.TabIndex = 96;
            this.btnDK.Text = "Đăng ký dịch vụ";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.BtnDK_Click);
            // 
            // FrmUpdateKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 488);
            this.Controls.Add(this.btnDK);
            this.Controls.Add(this.comboQuocTich);
            this.Controls.Add(this.tbSHC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPassport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAvatar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.pBPassport);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBAvatar);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThayDoi);
            this.Name = "FrmUpdateKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa thông tin";
            this.Load += new System.EventHandler(this.FrmUpdateKhachHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPassport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboQuocTich;
        private System.Windows.Forms.TextBox tbSHC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPassport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.Button btnAvatar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.PictureBox pBPassport;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pBAvatar;
        private System.Windows.Forms.Button btnDK;
    }
}