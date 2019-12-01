namespace QuanLyDichVuVsa
{
    partial class KhachHang
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
            this.tBTimKiem = new System.Windows.Forms.TextBox();
            this.bTTimKiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bTDangKi = new System.Windows.Forms.Button();
            this.bTSua = new System.Windows.Forms.Button();
            this.bTXoa = new System.Windows.Forms.Button();
            this.bTBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // tBTimKiem
            // 
            this.tBTimKiem.Location = new System.Drawing.Point(442, 57);
            this.tBTimKiem.Multiline = true;
            this.tBTimKiem.Name = "tBTimKiem";
            this.tBTimKiem.Size = new System.Drawing.Size(271, 25);
            this.tBTimKiem.TabIndex = 1;
            // 
            // bTTimKiem
            // 
            this.bTTimKiem.BackgroundImage = global::QuanLyDichVuVsa.Properties.Resources.baseline_search_black_48dp;
            this.bTTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bTTimKiem.Location = new System.Drawing.Point(719, 57);
            this.bTTimKiem.Name = "bTTimKiem";
            this.bTTimKiem.Size = new System.Drawing.Size(69, 25);
            this.bTTimKiem.TabIndex = 2;
            this.bTTimKiem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(776, 350);
            this.dataGridView1.TabIndex = 3;
            // 
            // bTDangKi
            // 
            this.bTDangKi.BackColor = System.Drawing.Color.Transparent;
            this.bTDangKi.BackgroundImage = global::QuanLyDichVuVsa.Properties.Resources.baseline_person_add_black_48dp;
            this.bTDangKi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bTDangKi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTDangKi.Location = new System.Drawing.Point(26, 57);
            this.bTDangKi.Name = "bTDangKi";
            this.bTDangKi.Size = new System.Drawing.Size(86, 25);
            this.bTDangKi.TabIndex = 4;
            this.bTDangKi.UseVisualStyleBackColor = false;
            // 
            // bTSua
            // 
            this.bTSua.BackColor = System.Drawing.Color.Transparent;
            this.bTSua.BackgroundImage = global::QuanLyDichVuVsa.Properties.Resources.baseline_edit_black_48dp;
            this.bTSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bTSua.Location = new System.Drawing.Point(118, 57);
            this.bTSua.Name = "bTSua";
            this.bTSua.Size = new System.Drawing.Size(86, 25);
            this.bTSua.TabIndex = 5;
            this.bTSua.UseVisualStyleBackColor = false;
            // 
            // bTXoa
            // 
            this.bTXoa.BackgroundImage = global::QuanLyDichVuVsa.Properties.Resources.baseline_delete_sweep_black_48dp;
            this.bTXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bTXoa.Location = new System.Drawing.Point(210, 57);
            this.bTXoa.Name = "bTXoa";
            this.bTXoa.Size = new System.Drawing.Size(86, 25);
            this.bTXoa.TabIndex = 6;
            this.bTXoa.UseVisualStyleBackColor = true;
            // 
            // bTBack
            // 
            this.bTBack.BackgroundImage = global::QuanLyDichVuVsa.Properties.Resources.baseline_arrow_back_black_48dp1;
            this.bTBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bTBack.Location = new System.Drawing.Point(302, 57);
            this.bTBack.Name = "bTBack";
            this.bTBack.Size = new System.Drawing.Size(86, 25);
            this.bTBack.TabIndex = 7;
            this.bTBack.UseVisualStyleBackColor = true;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyDichVuVsa.Properties.Resources.hero_landing_constellation_head_3000x1688_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bTBack);
            this.Controls.Add(this.bTXoa);
            this.Controls.Add(this.bTSua);
            this.Controls.Add(this.bTDangKi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bTTimKiem);
            this.Controls.Add(this.tBTimKiem);
            this.Controls.Add(this.label1);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBTimKiem;
        private System.Windows.Forms.Button bTTimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bTDangKi;
        private System.Windows.Forms.Button bTSua;
        private System.Windows.Forms.Button bTXoa;
        private System.Windows.Forms.Button bTBack;
    }
}