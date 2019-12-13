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

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void timDichVu(string keyword = "")
        {
            dsDichVu_Bus = new DSDichVu_BUS();
            List<DSDichVu> danhsachDV;
            if (keyword == "" || keyword == string.Empty || keyword.Length == 0)
            {
                danhsachDV = dsDichVu_Bus.Select();
            }
            else
            {
                danhsachDV = dsDichVu_Bus.SelectByKey(keyword);
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
        }

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
