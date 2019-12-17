using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLVS_BUS;
using QLVS_DTO;

namespace QuanLyDichVuViSa
{
    public partial class FrmDanhSachDichVu : Form
    {
        private DSDichVu_BUS dsDichVu_Bus;
        private List<DSDichVu> tempList;
        private int selectRow;

        public FrmDanhSachDichVu()
        {
            InitializeComponent();
            timDichVu();
        }
        public FrmDanhSachDichVu(string flag)
        {
            
            InitializeComponent();
            timDichVu(flag);
        }

        private void FrmDanhSachDichVu_Load(object sender, EventArgs e)
        {
            gw_dsdv.CellMouseDown += Gw_dsdv_CellMouseDown;
            gw_dsdv.MouseClick += Gw_dsdv_MouseClick;
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void timDichVu(string keyword = "")
        {
            dsDichVu_Bus = new DSDichVu_BUS();
            tempList = new List<DSDichVu>();

            List<DSDichVu> danhsachDV;
            if (keyword == "" || keyword == string.Empty || keyword.Length == 0)
            {
                danhsachDV = dsDichVu_Bus.Select();
                lb_trangThai.Text = "Tất cả";
            }
            else
            {
                danhsachDV = dsDichVu_Bus.SelectByKey(keyword);
                if (keyword != "TT0005") lb_trangThai.ForeColor = Color.Green;
                if (keyword == "TT0001") lb_trangThai.Text = "Chưa xử lý";
                if (keyword == "TT0002") lb_trangThai.Text = "Đang xử lý";
                if (keyword == "TT0003") lb_trangThai.Text = "Xử lý xong";
                if (keyword == "TT0004") lb_trangThai.Text = "Hoàn thành";
                if (keyword == "TT0005")
                {
                    lb_trangThai.ForeColor = Color.Red;
                    lb_trangThai.Text = "Thất bại";
                }
            }

            loadDanhSach(danhsachDV);
        }

        public void loadDanhSach(List<DSDichVu> list)
        {
            gw_dsdv.DataSource = null;
            gw_dsdv.AutoGenerateColumns = false;
            gw_dsdv.AllowUserToAddRows = false;
            gw_dsdv.DataSource = list;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[gw_dsdv.DataSource];
            myCurrencyManager.Refresh();

            tempList = list;
        }
        // --------------- Click chuyen trang thai-----------------//
        private void Gw_dsdv_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();

                int position_row = gw_dsdv.HitTest(e.X, e.Y).RowIndex;

                if (position_row >= 0)
                {
                    DSDichVu dichVu = new DSDichVu();
                    dichVu = tempList[selectRow];
                    if (dichVu.TrangThai == "Unfulfilled")
                        menu.Items.Add("Chuyển sang đang xử lý").Name = "CdangXuLy";
                    else if (dichVu.TrangThai == "Processing")
                    {
                        menu.Items.Add("Xử lý thất bại").Name = "CThatbai";
                        menu.Items.Add("Xử lý thành công").Name = "CXuLyXong";
                    }
                    else if (dichVu.TrangThai == "Completed")
                        menu.Items.Add("Hoàn thành").Name = "CHoanThanh";
                }
                menu.Show(gw_dsdv, new Point(e.X, e.Y));
                menu.ItemClicked += Menu_ItemClicked;
            }
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DSDichVu dichVu = new DSDichVu();
            bool kq;
            switch (e.ClickedItem.Name.ToString())
            {
                case "CdangXuLy":
                    dichVu = tempList[selectRow];                  
                    dichVu.MaTrangThai = "TT0002";
                    kq = dsDichVu_Bus.suaTT(dichVu);
                    break;
                case "CThatbai":
                    dichVu = tempList[selectRow];
                    dichVu.MaTrangThai = "TT0005";
                    kq = dsDichVu_Bus.suaTT(dichVu);
                    break;
                case "CXuLyXong":
                    dichVu = tempList[selectRow];
                    dichVu.MaTrangThai = "TT0003";
                    kq = dsDichVu_Bus.suaTT(dichVu);
                    break;
                case "CHoanThanh":
                    dichVu = tempList[selectRow];
                    dichVu.MaTrangThai = "TT0004";
                    kq = dsDichVu_Bus.suaTT(dichVu);
                    break;
            }
            if (lb_trangThai.Text == "Tất cả")
                timDichVu();
            else if (lb_trangThai.Text == "Chưa xử lý")
            {
                timDichVu("TT0001");
            }
            else if (lb_trangThai.Text == "Đang xử lý")
            {
                timDichVu("TT0002");
            }
            else if (lb_trangThai.Text == "Xử lý xong")
            {
                timDichVu("TT0003");
            }
            else if (lb_trangThai.Text == "Hoàn thành")
            {
                timDichVu("TT0004");
            }
            else
            {
                timDichVu("TT0005");
            }
        }

        private void Gw_dsdv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    return;
                selectRow = e.RowIndex;
                gw_dsdv.CurrentCell = gw_dsdv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                gw_dsdv.Rows[e.RowIndex].Selected = true;
                gw_dsdv.Focus();
            }
        }
        // ------------------ end Click chuyen trang thai-----------------//
        private void btnTim_Click(object sender, EventArgs e)
        {
            string strTuKhoa = tbTimKiem.Text.Trim();
            if (strTuKhoa == null || strTuKhoa == string.Empty || strTuKhoa.Length == 0)
            {
                List<DSDichVu> listDV = dsDichVu_Bus.Select();
                this.loadDanhSach(listDV);
            }
            else
            {
                List<DSDichVu> listDV = dsDichVu_Bus.SelectByKeyword(strTuKhoa);
                this.loadDanhSach(listDV);
            }
        }
    }
}
