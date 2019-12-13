namespace QuanLyDichVuViSa
{
    partial class FrmDangKyDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangKyDichVu));
            this.btDong = new System.Windows.Forms.Button();
            this.btXuat = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbSoHoChieu = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbQuocGia = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNoiCap = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbNoiNhan = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelGiaDVBS = new System.Windows.Forms.Label();
            this.labelTongChiPhi = new System.Windows.Forms.Label();
            this.labelGiaViSa = new System.Windows.Forms.Label();
            this.labelGiaThoiGian = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dateNgayDK = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.comboThoiGianXL = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateNgayXuatCanh = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dateNgayNhapCanh = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.comboNoiNhapCanh = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboLoaiViSa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(865, 442);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(90, 27);
            this.btDong.TabIndex = 79;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.BtDong_Click);
            // 
            // btXuat
            // 
            this.btXuat.Location = new System.Drawing.Point(736, 442);
            this.btXuat.Name = "btXuat";
            this.btXuat.Size = new System.Drawing.Size(119, 27);
            this.btXuat.TabIndex = 78;
            this.btXuat.Text = "Xuất biên nhận";
            this.btXuat.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(605, 442);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(119, 27);
            this.btLuu.TabIndex = 77;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.BtLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Số Hộ Chiếu";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbSoHoChieu);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 80);
            this.panel2.TabIndex = 82;
            // 
            // tbSoHoChieu
            // 
            this.tbSoHoChieu.Location = new System.Drawing.Point(88, 44);
            this.tbSoHoChieu.Multiline = true;
            this.tbSoHoChieu.Name = "tbSoHoChieu";
            this.tbSoHoChieu.Size = new System.Drawing.Size(231, 26);
            this.tbSoHoChieu.TabIndex = 56;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(323, 44);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(70, 26);
            this.simpleButton1.TabIndex = 55;
            this.simpleButton1.Text = "Tìm";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 50;
            this.label1.Text = "ĐĂNG KÝ DỊCH VỤ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbQuocGia);
            this.groupBox1.Controls.Add(this.tbSDT);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateNgaySinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tbTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 105);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // tbQuocGia
            // 
            this.tbQuocGia.Location = new System.Drawing.Point(605, 74);
            this.tbQuocGia.Name = "tbQuocGia";
            this.tbQuocGia.ReadOnly = true;
            this.tbQuocGia.Size = new System.Drawing.Size(350, 20);
            this.tbQuocGia.TabIndex = 34;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(605, 43);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.ReadOnly = true;
            this.tbSDT.Size = new System.Drawing.Size(350, 20);
            this.tbSDT.TabIndex = 33;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(605, 13);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(350, 20);
            this.tbEmail.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(503, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Quốc tịch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "SĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Email";
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Enabled = false;
            this.dateNgaySinh.Location = new System.Drawing.Point(88, 74);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(350, 20);
            this.dateNgaySinh.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ngày Sinh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioNu);
            this.panel1.Controls.Add(this.radioNam);
            this.panel1.Location = new System.Drawing.Point(88, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 20);
            this.panel1.TabIndex = 26;
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
            this.radioNam.Size = new System.Drawing.Size(47, 17);
            this.radioNam.TabIndex = 0;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(88, 13);
            this.tbTen.Name = "tbTen";
            this.tbTen.ReadOnly = true;
            this.tbTen.Size = new System.Drawing.Size(350, 20);
            this.tbTen.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Họ Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbNoiCap);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.tbNoiNhan);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.checkedComboBoxEdit1);
            this.groupBox2.Controls.Add(this.labelGiaDVBS);
            this.groupBox2.Controls.Add(this.labelTongChiPhi);
            this.groupBox2.Controls.Add(this.labelGiaViSa);
            this.groupBox2.Controls.Add(this.labelGiaThoiGian);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.dateNgayDK);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.comboThoiGianXL);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.dateNgayXuatCanh);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dateNgayNhapCanh);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboNoiNhapCanh);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboLoaiViSa);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 230);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dịch vụ";
            // 
            // tbNoiCap
            // 
            this.tbNoiCap.Location = new System.Drawing.Point(121, 99);
            this.tbNoiCap.Name = "tbNoiCap";
            this.tbNoiCap.Size = new System.Drawing.Size(198, 20);
            this.tbNoiCap.TabIndex = 111;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 110;
            this.label19.Text = "Nơi Cấp";
            // 
            // tbNoiNhan
            // 
            this.tbNoiNhan.Location = new System.Drawing.Point(121, 72);
            this.tbNoiNhan.Name = "tbNoiNhan";
            this.tbNoiNhan.Size = new System.Drawing.Size(198, 20);
            this.tbNoiNhan.TabIndex = 109;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 108;
            this.label17.Text = "Nơi nhận";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(503, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 107;
            this.label16.Text = "Dịch vụ bổ sung";
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(605, 103);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.AllowMultiSelect = true;
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(292, 20);
            this.checkedComboBoxEdit1.TabIndex = 106;
            this.checkedComboBoxEdit1.EditValueChanged += new System.EventHandler(this.CheckedComboBoxEdit1_EditValueChanged);
            this.checkedComboBoxEdit1.TextChanged += new System.EventHandler(this.CheckedComboBoxEdit1_TextChanged);
            // 
            // labelGiaDVBS
            // 
            this.labelGiaDVBS.Location = new System.Drawing.Point(910, 109);
            this.labelGiaDVBS.Name = "labelGiaDVBS";
            this.labelGiaDVBS.Size = new System.Drawing.Size(45, 14);
            this.labelGiaDVBS.TabIndex = 105;
            this.labelGiaDVBS.Text = "0 USD";
            this.labelGiaDVBS.UseCompatibleTextRendering = true;
            // 
            // labelTongChiPhi
            // 
            this.labelTongChiPhi.Location = new System.Drawing.Point(605, 193);
            this.labelTongChiPhi.Name = "labelTongChiPhi";
            this.labelTongChiPhi.Size = new System.Drawing.Size(231, 13);
            this.labelTongChiPhi.TabIndex = 103;
            this.labelTongChiPhi.Text = "0 USD";
            this.labelTongChiPhi.UseCompatibleTextRendering = true;
            // 
            // labelGiaViSa
            // 
            this.labelGiaViSa.Location = new System.Drawing.Point(348, 16);
            this.labelGiaViSa.Name = "labelGiaViSa";
            this.labelGiaViSa.Size = new System.Drawing.Size(45, 15);
            this.labelGiaViSa.TabIndex = 102;
            this.labelGiaViSa.Text = "0 USD";
            this.labelGiaViSa.UseCompatibleTextRendering = true;
            // 
            // labelGiaThoiGian
            // 
            this.labelGiaThoiGian.Location = new System.Drawing.Point(348, 45);
            this.labelGiaThoiGian.Name = "labelGiaThoiGian";
            this.labelGiaThoiGian.Size = new System.Drawing.Size(45, 14);
            this.labelGiaThoiGian.TabIndex = 101;
            this.labelGiaThoiGian.Text = "0 USD";
            this.labelGiaThoiGian.UseCompatibleTextRendering = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(505, 193);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 100;
            this.label18.Text = "Tổng chi phí";
            // 
            // dateNgayDK
            // 
            this.dateNgayDK.Enabled = false;
            this.dateNgayDK.Location = new System.Drawing.Point(605, 8);
            this.dateNgayDK.Name = "dateNgayDK";
            this.dateNgayDK.Size = new System.Drawing.Size(350, 20);
            this.dateNgayDK.TabIndex = 95;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(503, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 94;
            this.label14.Text = "Ngày đăng ký";
            // 
            // comboThoiGianXL
            // 
            this.comboThoiGianXL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboThoiGianXL.FormattingEnabled = true;
            this.comboThoiGianXL.Location = new System.Drawing.Point(121, 42);
            this.comboThoiGianXL.Name = "comboThoiGianXL";
            this.comboThoiGianXL.Size = new System.Drawing.Size(198, 21);
            this.comboThoiGianXL.TabIndex = 93;
            this.comboThoiGianXL.TextChanged += new System.EventHandler(this.ComboThoiGianXL_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 92;
            this.label13.Text = "Thời gian xử lý";
            // 
            // dateNgayXuatCanh
            // 
            this.dateNgayXuatCanh.Location = new System.Drawing.Point(605, 69);
            this.dateNgayXuatCanh.Name = "dateNgayXuatCanh";
            this.dateNgayXuatCanh.Size = new System.Drawing.Size(350, 20);
            this.dateNgayXuatCanh.TabIndex = 91;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(503, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "Ngày xuất cảnh";
            // 
            // dateNgayNhapCanh
            // 
            this.dateNgayNhapCanh.Location = new System.Drawing.Point(605, 37);
            this.dateNgayNhapCanh.Name = "dateNgayNhapCanh";
            this.dateNgayNhapCanh.Size = new System.Drawing.Size(350, 20);
            this.dateNgayNhapCanh.TabIndex = 89;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(503, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 88;
            this.label11.Text = "Ngày nhập cảnh";
            // 
            // comboNoiNhapCanh
            // 
            this.comboNoiNhapCanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNoiNhapCanh.FormattingEnabled = true;
            this.comboNoiNhapCanh.Location = new System.Drawing.Point(121, 129);
            this.comboNoiNhapCanh.Name = "comboNoiNhapCanh";
            this.comboNoiNhapCanh.Size = new System.Drawing.Size(198, 21);
            this.comboNoiNhapCanh.TabIndex = 87;
            this.comboNoiNhapCanh.TextChanged += new System.EventHandler(this.ComboNoiNhapCanh_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 86;
            this.label10.Text = "Nơi nhập cảnh";
            // 
            // comboLoaiViSa
            // 
            this.comboLoaiViSa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLoaiViSa.FormattingEnabled = true;
            this.comboLoaiViSa.Location = new System.Drawing.Point(121, 12);
            this.comboLoaiViSa.Name = "comboLoaiViSa";
            this.comboLoaiViSa.Size = new System.Drawing.Size(198, 21);
            this.comboLoaiViSa.TabIndex = 85;
            this.comboLoaiViSa.TextChanged += new System.EventHandler(this.ComboLoaiViSa_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 84;
            this.label9.Text = "Loại VISA";
            // 
            // FrmDangKyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btXuat);
            this.Name = "FrmDangKyDichVu";
            this.Text = "Đăng ký dịch vụ";
            this.Load += new System.EventHandler(this.FrmDangKyDichVu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btXuat;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label labelTongChiPhi;
        private System.Windows.Forms.Label labelGiaViSa;
        private System.Windows.Forms.Label labelGiaThoiGian;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateNgayDK;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboThoiGianXL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateNgayXuatCanh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateNgayNhapCanh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboNoiNhapCanh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboLoaiViSa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSoHoChieu;
        private System.Windows.Forms.Label labelGiaDVBS;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
        private System.Windows.Forms.TextBox tbQuocGia;
        private System.Windows.Forms.TextBox tbNoiNhan;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbNoiCap;
        private System.Windows.Forms.Label label19;
    }
}