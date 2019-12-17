namespace QuanLyDichVuViSa
{
    partial class FrmDoanhThu
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
            this.components = new System.ComponentModel.Container();
            this.dateThang = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTong = new System.Windows.Forms.Label();
            this.btTong = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gw_doanhThu = new System.Windows.Forms.DataGridView();
            this.maDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDangKiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiPhiThanhToanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanhThuDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gw_doanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanhThuDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateThang
            // 
            this.dateThang.CustomFormat = "MM/yyyy";
            this.dateThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateThang.Location = new System.Drawing.Point(102, 61);
            this.dateThang.Name = "dateThang";
            this.dateThang.Size = new System.Drawing.Size(240, 20);
            this.dateThang.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chọn tháng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbTong);
            this.panel1.Controls.Add(this.btTong);
            this.panel1.Controls.Add(this.btTimKiem);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateThang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 130);
            this.panel1.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(771, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "USD";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(700, 102);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(13, 13);
            this.lbTong.TabIndex = 55;
            this.lbTong.Text = "0";
            // 
            // btTong
            // 
            this.btTong.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btTong.Location = new System.Drawing.Point(578, 93);
            this.btTong.Name = "btTong";
            this.btTong.Size = new System.Drawing.Size(100, 31);
            this.btTong.TabIndex = 54;
            this.btTong.Text = "Tổng doanh thu";
            this.btTong.UseVisualStyleBackColor = false;
            this.btTong.Click += new System.EventHandler(this.btTong_Click_1);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(364, 54);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(75, 31);
            this.btTimKiem.TabIndex = 52;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(897, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 51;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 35);
            this.label1.TabIndex = 50;
            this.label1.Text = "DOANH THU";
            // 
            // gw_doanhThu
            // 
            this.gw_doanhThu.AutoGenerateColumns = false;
            this.gw_doanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gw_doanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gw_doanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDVDataGridViewTextBoxColumn,
            this.hoTenKHDataGridViewTextBoxColumn,
            this.ngayDangKiDataGridViewTextBoxColumn,
            this.chiPhiThanhToanDataGridViewTextBoxColumn});
            this.gw_doanhThu.DataSource = this.doanhThuDTOBindingSource;
            this.gw_doanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gw_doanhThu.Location = new System.Drawing.Point(0, 130);
            this.gw_doanhThu.Name = "gw_doanhThu";
            this.gw_doanhThu.Size = new System.Drawing.Size(984, 351);
            this.gw_doanhThu.TabIndex = 53;
            // 
            // maDVDataGridViewTextBoxColumn
            // 
            this.maDVDataGridViewTextBoxColumn.DataPropertyName = "MaDV";
            this.maDVDataGridViewTextBoxColumn.HeaderText = "MaDV";
            this.maDVDataGridViewTextBoxColumn.Name = "maDVDataGridViewTextBoxColumn";
            // 
            // hoTenKHDataGridViewTextBoxColumn
            // 
            this.hoTenKHDataGridViewTextBoxColumn.DataPropertyName = "HoTenKH";
            this.hoTenKHDataGridViewTextBoxColumn.HeaderText = "HoTenKH";
            this.hoTenKHDataGridViewTextBoxColumn.Name = "hoTenKHDataGridViewTextBoxColumn";
            // 
            // ngayDangKiDataGridViewTextBoxColumn
            // 
            this.ngayDangKiDataGridViewTextBoxColumn.DataPropertyName = "NgayDangKi";
            this.ngayDangKiDataGridViewTextBoxColumn.HeaderText = "NgayDangKi";
            this.ngayDangKiDataGridViewTextBoxColumn.Name = "ngayDangKiDataGridViewTextBoxColumn";
            // 
            // chiPhiThanhToanDataGridViewTextBoxColumn
            // 
            this.chiPhiThanhToanDataGridViewTextBoxColumn.DataPropertyName = "ChiPhiThanhToan";
            this.chiPhiThanhToanDataGridViewTextBoxColumn.HeaderText = "ChiPhiThanhToan";
            this.chiPhiThanhToanDataGridViewTextBoxColumn.Name = "chiPhiThanhToanDataGridViewTextBoxColumn";
            // 
            // doanhThuDTOBindingSource
            // 
            this.doanhThuDTOBindingSource.DataSource = typeof(QLVS_DTO.DoanhThuDTO);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "label3";
            // 
            // FrmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gw_doanhThu);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDoanhThu";
            this.Text = "DoanhThu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gw_doanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanhThuDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gw_doanhThu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Button btTong;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.BindingSource doanhThuDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDangKiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiPhiThanhToanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}