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
    public partial class FrmDoanhThu : Form
    {

        public FrmDoanhThu()
        {
            InitializeComponent();
        }
        //public FrmDoanhThu(int month, int year)
        //{
        //    InitializeComponent();
        //    timDoanhThu(month,year);
        //}



        //private void btTimKiem_Click(object sender, EventArgs e)
        //{
        //    object[] dateThangNam ={ dateThang.Value.ToString("yyyy-MM-dd") };

        //    List<DoanhThuDTO> listDoanhThu = doanhThuBus.Select(dateThangNam);
        //    this.loadDoanhThu(listDoanhThu);
        //}

        //public void timDoanhThu(int month, int year)
        //{
        //    doanhThuBus = new DoanhThuBUS();
        //    List<DoanhThuDTO> doanhThu;

        //    doanhThu = doanhThuBus.Select(month,year);

        //    loadDoanhThu(doanhThu);
        //}

        public void loadDoanhThu(List<DoanhThuDTO> list)
        {
            gw_doanhThu.DataSource = null;
            gw_doanhThu.AutoGenerateColumns = false;
            gw_doanhThu.AllowUserToAddRows = false;
            gw_doanhThu.DataSource = list;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[gw_doanhThu.DataSource];
            myCurrencyManager.Refresh();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTong_Click_1(object sender, EventArgs e)
        {
            lbTong.Text = "0";
            for (int i = 0; i < gw_doanhThu.Rows.Count; i++)
            {
                lbTong.Text = Convert.ToString(double.Parse(lbTong.Text) + double.Parse(gw_doanhThu.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            DateTime days = dateThang.Value;
            //DateTime month = Convert.ToDateTime( dateThang.Value.ToString("MM"));
            DoanhThuBUS doanhThuBus = new DoanhThuBUS();
            List<DoanhThuDTO> listDoanhThu = doanhThuBus.Select(days.Month, days.Year);
            this.loadDoanhThu(listDoanhThu);

        }
    }
}
