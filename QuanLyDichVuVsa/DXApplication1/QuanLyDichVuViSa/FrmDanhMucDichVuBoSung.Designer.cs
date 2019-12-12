namespace QuanLyDichVuViSa
{
    partial class FrmDanhMucDichVuBoSung
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
            this.tbTenDichVu = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.tbChiPhi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaDVBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTenDichVu
            // 
            this.tbTenDichVu.Enabled = false;
            this.tbTenDichVu.Location = new System.Drawing.Point(118, 67);
            this.tbTenDichVu.Name = "tbTenDichVu";
            this.tbTenDichVu.Size = new System.Drawing.Size(253, 20);
            this.tbTenDichVu.TabIndex = 38;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(657, 93);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 31);
            this.btnDong.TabIndex = 44;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.BtnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(118, 93);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên dịch vụ";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(208, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 31);
            this.btnLuu.TabIndex = 41;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(208, 93);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 36;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // tbChiPhi
            // 
            this.tbChiPhi.Enabled = false;
            this.tbChiPhi.Location = new System.Drawing.Point(479, 67);
            this.tbChiPhi.Name = "tbChiPhi";
            this.tbChiPhi.Size = new System.Drawing.Size(253, 20);
            this.tbChiPhi.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Chi phí";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.tbTenDichVu);
            this.panel1.Controls.Add(this.tbChiPhi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 130);
            this.panel1.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "DANH MỤC DỊCH VỤ BỔ SUNG";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(296, 93);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 48;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(296, 93);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 31);
            this.btnHuy.TabIndex = 47;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDVBS,
            this.DichVu,
            this.ChiPhi});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 351);
            this.dataGridView1.TabIndex = 48;
            // 
            // MaDVBS
            // 
            this.MaDVBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaDVBS.DataPropertyName = "MaDVBS";
            this.MaDVBS.HeaderText = "Mã dịch vụ bổ sung";
            this.MaDVBS.Name = "MaDVBS";
            this.MaDVBS.Width = 95;
            // 
            // DichVu
            // 
            this.DichVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DichVu.DataPropertyName = "Ten";
            this.DichVu.HeaderText = "Dịch vụ";
            this.DichVu.Name = "DichVu";
            // 
            // ChiPhi
            // 
            this.ChiPhi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChiPhi.DataPropertyName = "ChiPhi";
            this.ChiPhi.HeaderText = "Chi phí";
            this.ChiPhi.Name = "ChiPhi";
            // 
            // FrmDanhMucDichVuBoSung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 481);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDanhMucDichVuBoSung";
            this.Text = "Dịch vụ bổ sung";
            this.Load += new System.EventHandler(this.FrmDanhMucDichVuBoSung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbTenDichVu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox tbChiPhi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDVBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiPhi;
    }
}