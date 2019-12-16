namespace QuanLyDichVuViSa
{
    partial class FrmDanhSachDichVu
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
            this.btnTim = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gw_dsdv = new System.Windows.Forms.DataGridView();
            this.maDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiVisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiNhapCanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDangKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhapCanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXuatCanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianXuLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiPhiThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_trangThai = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gw_dsdv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTim.Location = new System.Drawing.Point(316, 87);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 31);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(3, 89);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(307, 26);
            this.tbTimKiem.TabIndex = 7;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.btnTim_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(897, 90);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 31);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.BtnDong_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_trangThai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.tbTimKiem);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 130);
            this.panel1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 35);
            this.label1.TabIndex = 50;
            this.label1.Text = "DANH SÁCH DỊCH VỤ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gw_dsdv
            // 
            this.gw_dsdv.AllowUserToAddRows = false;
            this.gw_dsdv.AllowUserToDeleteRows = false;
            this.gw_dsdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gw_dsdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDV,
            this.loaiVisa,
            this.noiNhapCanh,
            this.hoTen,
            this.noiCap,
            this.ngayDangKi,
            this.ngayNhapCanh,
            this.ngayXuatCanh,
            this.thoiGianXuLy,
            this.noiNhan,
            this.chiPhiThanhToan,
            this.trangThai});
            this.gw_dsdv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gw_dsdv.Location = new System.Drawing.Point(0, 130);
            this.gw_dsdv.Name = "gw_dsdv";
            this.gw_dsdv.ReadOnly = true;
            this.gw_dsdv.RowHeadersVisible = false;
            this.gw_dsdv.Size = new System.Drawing.Size(984, 351);
            this.gw_dsdv.TabIndex = 53;
            // 
            // maDV
            // 
            this.maDV.DataPropertyName = "maDV";
            this.maDV.HeaderText = "Mã dịch vụ";
            this.maDV.Name = "maDV";
            this.maDV.ReadOnly = true;
            this.maDV.Width = 50;
            // 
            // loaiVisa
            // 
            this.loaiVisa.DataPropertyName = "LoaiVisa";
            this.loaiVisa.HeaderText = "Loại Visa";
            this.loaiVisa.Name = "loaiVisa";
            this.loaiVisa.ReadOnly = true;
            this.loaiVisa.Width = 125;
            // 
            // noiNhapCanh
            // 
            this.noiNhapCanh.DataPropertyName = "Dcnc";
            this.noiNhapCanh.HeaderText = "Nơi nhập cảnh";
            this.noiNhapCanh.Name = "noiNhapCanh";
            this.noiNhapCanh.ReadOnly = true;
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "HoTenKH";
            this.hoTen.HeaderText = "Tên khách hàng";
            this.hoTen.Name = "hoTen";
            this.hoTen.ReadOnly = true;
            // 
            // noiCap
            // 
            this.noiCap.DataPropertyName = "NoiCap";
            this.noiCap.HeaderText = "Nơi cấp";
            this.noiCap.Name = "noiCap";
            this.noiCap.ReadOnly = true;
            // 
            // ngayDangKi
            // 
            this.ngayDangKi.DataPropertyName = "NgayDangKi";
            this.ngayDangKi.HeaderText = "Ngày đăng kí";
            this.ngayDangKi.Name = "ngayDangKi";
            this.ngayDangKi.ReadOnly = true;
            this.ngayDangKi.Width = 65;
            // 
            // ngayNhapCanh
            // 
            this.ngayNhapCanh.DataPropertyName = "NgayNhapCanh";
            this.ngayNhapCanh.HeaderText = "Ngày nhập cảnh";
            this.ngayNhapCanh.Name = "ngayNhapCanh";
            this.ngayNhapCanh.ReadOnly = true;
            this.ngayNhapCanh.Width = 65;
            // 
            // ngayXuatCanh
            // 
            this.ngayXuatCanh.DataPropertyName = "NgayXuatCanh";
            this.ngayXuatCanh.HeaderText = "Ngày xuất cảnh";
            this.ngayXuatCanh.Name = "ngayXuatCanh";
            this.ngayXuatCanh.ReadOnly = true;
            this.ngayXuatCanh.Width = 65;
            // 
            // thoiGianXuLy
            // 
            this.thoiGianXuLy.DataPropertyName = "ThoiGianXuLy";
            this.thoiGianXuLy.HeaderText = "Thời gian xử lý";
            this.thoiGianXuLy.Name = "thoiGianXuLy";
            this.thoiGianXuLy.ReadOnly = true;
            // 
            // noiNhan
            // 
            this.noiNhan.DataPropertyName = "NoiNhan";
            this.noiNhan.HeaderText = "Nơi nhận";
            this.noiNhan.Name = "noiNhan";
            this.noiNhan.ReadOnly = true;
            // 
            // chiPhiThanhToan
            // 
            this.chiPhiThanhToan.DataPropertyName = "ChiPhiThanhToan";
            this.chiPhiThanhToan.HeaderText = "Chi phí thanh toán";
            this.chiPhiThanhToan.Name = "chiPhiThanhToan";
            this.chiPhiThanhToan.ReadOnly = true;
            this.chiPhiThanhToan.Width = 50;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "TrangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            this.trangThai.Width = 65;
            // 
            // lb_trangThai
            // 
            this.lb_trangThai.AutoSize = true;
            this.lb_trangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trangThai.ForeColor = System.Drawing.Color.Green;
            this.lb_trangThai.Location = new System.Drawing.Point(458, 55);
            this.lb_trangThai.Name = "lb_trangThai";
            this.lb_trangThai.Size = new System.Drawing.Size(52, 16);
            this.lb_trangThai.TabIndex = 51;
            this.lb_trangThai.Text = "Tất cả";
            this.lb_trangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmDanhSachDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 481);
            this.Controls.Add(this.gw_dsdv);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDanhSachDichVu";
            this.Text = "Danh sách dịch vụ";
            this.Load += new System.EventHandler(this.FrmDanhSachDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gw_dsdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gw_dsdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiVisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiNhapCanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDangKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapCanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXuatCanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianXuLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiPhiThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        public System.Windows.Forms.Label lb_trangThai;
    }
}