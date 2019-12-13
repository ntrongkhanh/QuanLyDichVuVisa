using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyDichVuViSa
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {

        FrmDanhSachDichVu form_DSDV;
        public FrmMain()
        {
            InitializeComponent();
        }
        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmDangKyKhachHang));
            if (frm == null)
            {
                FrmDangKyKhachHang forms = new FrmDangKyKhachHang();
                forms.MdiParent = this;

                forms.Show();

            }
            else
            {
                frm.Activate();
            }
        }

        private void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmDanhSachKhachHang));
            if (frm == null)
            {
                FrmDanhSachKhachHang forms = new FrmDanhSachKhachHang(this);
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void BarButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Form frm = kiemtraform(typeof(FrmDangKyDichVu));
            if (frm == null)
            {
                FrmDangKyDichVu forms = new FrmDangKyDichVu();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = kiemtraform(typeof(FrmDanhSachDichVu));
            if (frm == null)
            {
                form_DSDV = new FrmDanhSachDichVu("TT0001");
                form_DSDV.MdiParent = this;
                form_DSDV.Show();
            }
            else
            {
                frm.Activate();
                form_DSDV.timDichVu("TT0001");
            }

        }

        private void BarButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmDanhSachDichVu));
            if (frm == null)
            {
                form_DSDV = new FrmDanhSachDichVu("TT0002");
                form_DSDV.MdiParent = this;
                form_DSDV.Show();
            }
            else
            {
                frm.Activate();
                form_DSDV.timDichVu("TT0002");
            }
        }

        private void BarButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmDanhSachDichVu));
            if (frm == null)
            {
                form_DSDV = new FrmDanhSachDichVu("TT0003");
                form_DSDV.MdiParent = this;
                form_DSDV.Show();
            }
            else
            {
                frm.Activate();
                form_DSDV.timDichVu("TT0003");
            }
        }

        private void BarButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmDanhSachDichVu));
            if (frm == null)
            {
                form_DSDV = new FrmDanhSachDichVu("TT0004");
                form_DSDV.MdiParent = this;
                form_DSDV.Show();
            }
            else
            {
                frm.Activate();
                form_DSDV.timDichVu("TT0004");
            }
        }

        private void BarButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmDanhSachDichVu));
            if (frm == null)
            {
                form_DSDV = new FrmDanhSachDichVu("TT0005");
                form_DSDV.MdiParent = this;
                form_DSDV.Show();
            }
            else
            {
                frm.Activate();
                form_DSDV.timDichVu("TT0005");
            }
        }

        private void BarButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmDanhMucViSa));
            if (frm == null)
            {
                FrmDanhMucViSa forms = new FrmDanhMucViSa();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void BarButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmDanhMucDiaChiNhapCanh));
            if (frm == null)
            {
                FrmDanhMucDiaChiNhapCanh forms = new FrmDanhMucDiaChiNhapCanh();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void BarButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmDanhMucThoiGianXuLy));
            if (frm == null)
            {
                FrmDanhMucThoiGianXuLy forms = new FrmDanhMucThoiGianXuLy();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void BarButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmDanhMucDichVuBoSung));
            if (frm == null)
            {
                FrmDanhMucDichVuBoSung forms = new FrmDanhMucDichVuBoSung();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void BarButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmDoanhThu));
            if (frm == null)
            {
                FrmDoanhThu forms = new FrmDoanhThu();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something elsef
                e.Cancel = (dialogResult == DialogResult.No);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (ribbonControl1.SelectedPage.Name == "pageDichVu")
            {
                Form frm = kiemtraform(typeof(FrmDanhSachDichVu));
                if (frm == null)
                {
                    form_DSDV = new FrmDanhSachDichVu();
                    form_DSDV.MdiParent = this;
                    form_DSDV.Show();
                }
                else
                {
                    frm.Activate();
                    form_DSDV.timDichVu();
                }
            }
        }
    }
}