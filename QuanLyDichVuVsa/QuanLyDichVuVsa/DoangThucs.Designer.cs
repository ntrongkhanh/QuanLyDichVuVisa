namespace QuanLyDichVuVsa
{
    partial class DoangThucs
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bTXem = new System.Windows.Forms.Button();
            this.bTBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOANH THU";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(751, 344);
            this.dataGridView1.TabIndex = 2;
            // 
            // bTXem
            // 
            this.bTXem.BackgroundImage = global::QuanLyDichVuVsa.Properties.Resources.baseline_search_black_48dp1;
            this.bTXem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bTXem.Location = new System.Drawing.Point(487, 68);
            this.bTXem.Margin = new System.Windows.Forms.Padding(2);
            this.bTXem.Name = "bTXem";
            this.bTXem.Size = new System.Drawing.Size(63, 20);
            this.bTXem.TabIndex = 3;
            this.bTXem.UseVisualStyleBackColor = true;
            // 
            // bTBack
            // 
            this.bTBack.BackgroundImage = global::QuanLyDichVuVsa.Properties.Resources.baseline_arrow_back_black_48dp;
            this.bTBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bTBack.Location = new System.Drawing.Point(185, 69);
            this.bTBack.Name = "bTBack";
            this.bTBack.Size = new System.Drawing.Size(72, 19);
            this.bTBack.TabIndex = 4;
            this.bTBack.UseVisualStyleBackColor = true;
            // 
            // DoangThucs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyDichVuVsa.Properties.Resources.ho_chieu_viet_nam_di_duoc_bao_nhieu_nuoc_khong_can_visa1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bTBack);
            this.Controls.Add(this.bTXem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DoangThucs";
            this.Text = "DoangThucs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bTXem;
        private System.Windows.Forms.Button bTBack;
    }
}