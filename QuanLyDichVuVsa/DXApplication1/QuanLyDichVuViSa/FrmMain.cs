using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyDichVuViSa
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
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
                FrmDanhSachKhachHang forms = new FrmDanhSachKhachHang();
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
            
                FrmDanhSachDichVu forms = new FrmDanhSachDichVu();
                forms.MdiParent = this;
                forms.Show();
            
        }

        private void BarButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachDichVu forms = new FrmDanhSachDichVu();
            forms.MdiParent = this;
            forms.Show();
        }

        private void BarButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachDichVu forms = new FrmDanhSachDichVu();
            forms.MdiParent = this;
            forms.Show();
        }

        private void BarButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachDichVu forms = new FrmDanhSachDichVu();
            forms.MdiParent = this;
            forms.Show();
        }

        private void BarButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachDichVu forms = new FrmDanhSachDichVu();
            forms.MdiParent = this;
            forms.Show();
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
    }
}