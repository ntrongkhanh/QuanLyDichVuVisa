namespace QuanLyDichVuViSa
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangKyKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKyDichVu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DanhSachCho = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachDangXuLy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachXuLyXong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachHoanThanh = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachThatBai = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoanhThu = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiViSa = new DevExpress.XtraBars.BarButtonItem();
            this.btnDiaChiNhapCanh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoiGianXuLy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDichVuBoSung = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangKyKH,
            this.btnDanhSachKH,
            this.btnDangKyDichVu,
            this.btn_DanhSachCho,
            this.btnDanhSachDangXuLy,
            this.btnDanhSachXuLyXong,
            this.btnDanhSachHoanThanh,
            this.btnDanhSachThatBai,
            this.btnDoanhThu,
            this.btnLoaiViSa,
            this.btnDiaChiNhapCanh,
            this.btnThoiGianXuLy,
            this.btnDichVuBoSung});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(998, 150);
            // 
            // btnDangKyKH
            // 
            this.btnDangKyKH.Caption = "Đăng ký khách hàng";
            this.btnDangKyKH.Id = 2;
            this.btnDangKyKH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.btnDangKyKH.Name = "btnDangKyKH";
            this.btnDangKyKH.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangKyKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem1_ItemClick);
            // 
            // btnDanhSachKH
            // 
            this.btnDanhSachKH.Caption = "Danh sách khách hàng";
            this.btnDanhSachKH.Id = 3;
            this.btnDanhSachKH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.btnDanhSachKH.Name = "btnDanhSachKH";
            this.btnDanhSachKH.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanhSachKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem2_ItemClick);
            // 
            // btnDangKyDichVu
            // 
            this.btnDangKyDichVu.Caption = "Đăng ký dịch vụ";
            this.btnDangKyDichVu.Id = 4;
            this.btnDangKyDichVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.btnDangKyDichVu.Name = "btnDangKyDichVu";
            this.btnDangKyDichVu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangKyDichVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem3_ItemClick);
            // 
            // btn_DanhSachCho
            // 
            this.btn_DanhSachCho.Caption = "Danh sách dịch vụ chưa xử lý";
            this.btn_DanhSachCho.Id = 7;
            this.btn_DanhSachCho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.btn_DanhSachCho.Name = "btn_DanhSachCho";
            this.btn_DanhSachCho.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_DanhSachCho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem4_ItemClick);
            // 
            // btnDanhSachDangXuLy
            // 
            this.btnDanhSachDangXuLy.Caption = "Danh sách dịch vụ đang xử lý";
            this.btnDanhSachDangXuLy.Id = 8;
            this.btnDanhSachDangXuLy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.btnDanhSachDangXuLy.Name = "btnDanhSachDangXuLy";
            this.btnDanhSachDangXuLy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanhSachDangXuLy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem5_ItemClick);
            // 
            // btnDanhSachXuLyXong
            // 
            this.btnDanhSachXuLyXong.Caption = "Danh sách dịch vụ xử lý xong";
            this.btnDanhSachXuLyXong.Id = 9;
            this.btnDanhSachXuLyXong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.btnDanhSachXuLyXong.Name = "btnDanhSachXuLyXong";
            this.btnDanhSachXuLyXong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanhSachXuLyXong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem6_ItemClick);
            // 
            // btnDanhSachHoanThanh
            // 
            this.btnDanhSachHoanThanh.Caption = "Danh sách dịch vụ đã hoàn thành";
            this.btnDanhSachHoanThanh.Id = 10;
            this.btnDanhSachHoanThanh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.btnDanhSachHoanThanh.Name = "btnDanhSachHoanThanh";
            this.btnDanhSachHoanThanh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanhSachHoanThanh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem7_ItemClick);
            // 
            // btnDanhSachThatBai
            // 
            this.btnDanhSachThatBai.Caption = "Danh sách dịch vụ xử lý thất bại";
            this.btnDanhSachThatBai.Id = 11;
            this.btnDanhSachThatBai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem8.ImageOptions.SvgImage")));
            this.btnDanhSachThatBai.Name = "btnDanhSachThatBai";
            this.btnDanhSachThatBai.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanhSachThatBai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem8_ItemClick);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Caption = "Doanh thu theo tháng";
            this.btnDoanhThu.Id = 13;
            this.btnDoanhThu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem10.ImageOptions.SvgImage")));
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDoanhThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem10_ItemClick);
            // 
            // btnLoaiViSa
            // 
            this.btnLoaiViSa.Caption = "Loại ViSa";
            this.btnLoaiViSa.Id = 14;
            this.btnLoaiViSa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem11.ImageOptions.SvgImage")));
            this.btnLoaiViSa.Name = "btnLoaiViSa";
            this.btnLoaiViSa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLoaiViSa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem11_ItemClick);
            // 
            // btnDiaChiNhapCanh
            // 
            this.btnDiaChiNhapCanh.Caption = "Địa chỉ nhập cảnh";
            this.btnDiaChiNhapCanh.Id = 15;
            this.btnDiaChiNhapCanh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem12.ImageOptions.SvgImage")));
            this.btnDiaChiNhapCanh.Name = "btnDiaChiNhapCanh";
            this.btnDiaChiNhapCanh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDiaChiNhapCanh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem12_ItemClick);
            // 
            // btnThoiGianXuLy
            // 
            this.btnThoiGianXuLy.Caption = "Thời gian xử lý";
            this.btnThoiGianXuLy.Id = 16;
            this.btnThoiGianXuLy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem13.ImageOptions.SvgImage")));
            this.btnThoiGianXuLy.Name = "btnThoiGianXuLy";
            this.btnThoiGianXuLy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThoiGianXuLy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem13_ItemClick);
            // 
            // btnDichVuBoSung
            // 
            this.btnDichVuBoSung.Caption = "Dịch vụ bổ sung";
            this.btnDichVuBoSung.Id = 17;
            this.btnDichVuBoSung.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem14.ImageOptions.SvgImage")));
            this.btnDichVuBoSung.Name = "btnDichVuBoSung";
            this.btnDichVuBoSung.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDichVuBoSung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem14_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "KHÁCH HÀNG";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangKyKH);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDanhSachKH);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý khách hàng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDangKyDichVu);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "DỊCH VỤ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_DanhSachCho);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDanhSachDangXuLy);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDanhSachXuLyXong);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDanhSachHoanThanh);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDanhSachThatBai);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý dịch vụ khách hàng";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "DANH THU";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDoanhThu);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Doanh thu";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "DANH MỤC";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnLoaiViSa);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDiaChiNhapCanh);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnThoiGianXuLy);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDichVuBoSung);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Danh mục";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 668);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnDangKyKH;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachKH;
        private DevExpress.XtraBars.BarButtonItem btnDangKyDichVu;
        private DevExpress.XtraBars.BarButtonItem btn_DanhSachCho;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachDangXuLy;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachXuLyXong;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachHoanThanh;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachThatBai;
        private DevExpress.XtraBars.BarButtonItem btnDoanhThu;
        private DevExpress.XtraBars.BarButtonItem btnLoaiViSa;
        private DevExpress.XtraBars.BarButtonItem btnDiaChiNhapCanh;
        private DevExpress.XtraBars.BarButtonItem btnThoiGianXuLy;
        private DevExpress.XtraBars.BarButtonItem btnDichVuBoSung;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}