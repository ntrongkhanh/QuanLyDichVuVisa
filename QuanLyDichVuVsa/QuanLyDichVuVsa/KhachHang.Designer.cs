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
            this.bTxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // tBTimKiem
            // 
            this.tBTimKiem.Location = new System.Drawing.Point(744, 69);
            this.tBTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBTimKiem.Name = "tBTimKiem";
            this.tBTimKiem.Size = new System.Drawing.Size(198, 22);
            this.tBTimKiem.TabIndex = 1;
            // 
            // bTTimKiem
            // 
            this.bTTimKiem.Location = new System.Drawing.Point(951, 65);
            this.bTTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTTimKiem.Name = "bTTimKiem";
            this.bTTimKiem.Size = new System.Drawing.Size(100, 28);
            this.bTTimKiem.TabIndex = 2;
            this.bTTimKiem.Text = "Tìm Kiếm";
            this.bTTimKiem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(706, 474);
            this.dataGridView1.TabIndex = 3;
            // 
            // bTDangKi
            // 
            this.bTDangKi.Location = new System.Drawing.Point(744, 159);
            this.bTDangKi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTDangKi.Name = "bTDangKi";
            this.bTDangKi.Size = new System.Drawing.Size(307, 54);
            this.bTDangKi.TabIndex = 4;
            this.bTDangKi.Text = "Đăng kí";
            this.bTDangKi.UseVisualStyleBackColor = true;
            // 
            // bTSua
            // 
            this.bTSua.Location = new System.Drawing.Point(744, 244);
            this.bTSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTSua.Name = "bTSua";
            this.bTSua.Size = new System.Drawing.Size(307, 53);
            this.bTSua.TabIndex = 5;
            this.bTSua.Text = "Sửa";
            this.bTSua.UseVisualStyleBackColor = true;
            // 
            // bTxoa
            // 
            this.bTxoa.Location = new System.Drawing.Point(744, 329);
            this.bTxoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTxoa.Name = "bTxoa";
            this.bTxoa.Size = new System.Drawing.Size(307, 57);
            this.bTxoa.TabIndex = 6;
            this.bTxoa.Text = "Xóa";
            this.bTxoa.UseVisualStyleBackColor = true;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bTxoa);
            this.Controls.Add(this.bTSua);
            this.Controls.Add(this.bTDangKi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bTTimKiem);
            this.Controls.Add(this.tBTimKiem);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button bTxoa;
    }
}