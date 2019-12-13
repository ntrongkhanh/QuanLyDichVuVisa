namespace QuanLyDichVuViSa
{
    partial class FrmDanhMucDiaChiNhapCanh
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.tbNoiNhapCanh = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_thongBao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_suaDCNC = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nơi Nhập Cảnh";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(461, 59);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Red;
            this.btnDong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDong.Location = new System.Drawing.Point(851, 86);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 31);
            this.btnDong.TabIndex = 44;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.BtnDong_Click);
            // 
            // tbNoiNhapCanh
            // 
            this.tbNoiNhapCanh.Location = new System.Drawing.Point(134, 65);
            this.tbNoiNhapCanh.Name = "tbNoiNhapCanh";
            this.tbNoiNhapCanh.Size = new System.Drawing.Size(292, 20);
            this.tbNoiNhapCanh.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_thongBao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbNoiNhapCanh);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btn_suaDCNC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 130);
            this.panel1.TabIndex = 45;
            // 
            // lb_thongBao
            // 
            this.lb_thongBao.AutoSize = true;
            this.lb_thongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongBao.Location = new System.Drawing.Point(131, 104);
            this.lb_thongBao.Name = "lb_thongBao";
            this.lb_thongBao.Size = new System.Drawing.Size(0, 16);
            this.lb_thongBao.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "DANH MỤC ĐỊA CHỈ NHẬP CẢNH";
            // 
            // btn_suaDCNC
            // 
            this.btn_suaDCNC.Location = new System.Drawing.Point(461, 59);
            this.btn_suaDCNC.Name = "btn_suaDCNC";
            this.btn_suaDCNC.Size = new System.Drawing.Size(75, 31);
            this.btn_suaDCNC.TabIndex = 47;
            this.btn_suaDCNC.Text = "Sửa";
            this.btn_suaDCNC.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.DiaChi});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(984, 351);
            this.dataGridView1.TabIndex = 46;
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "MaDCNC";
            this.Ma.Frozen = true;
            this.Ma.HeaderText = "Mã Địa Chỉ Nhập Cảnh";
            this.Ma.Name = "Ma";
            this.Ma.Width = 450;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChiNC";
            this.DiaChi.HeaderText = "Địa Chỉ Nhập Cảnh";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 550;
            // 
            // FrmDanhMucDiaChiNhapCanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 481);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDanhMucDiaChiNhapCanh";
            this.Text = "Địa chỉ xuất nhập cảnh";
            this.Load += new System.EventHandler(this.FrmDanhMucDiaChiNhapCanh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox tbNoiNhapCanh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_thongBao;
        private System.Windows.Forms.Button btn_suaDCNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}