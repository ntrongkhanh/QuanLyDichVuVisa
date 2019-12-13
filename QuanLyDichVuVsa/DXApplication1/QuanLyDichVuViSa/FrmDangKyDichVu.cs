using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using QLVS_DTO;
using QLVS_BUS;
using DevExpress.XtraEditors.Controls;

namespace QuanLyDichVuViSa
{
    public partial class FrmDangKyDichVu : Form
    {
        private DangKyDichVuBUS dvbus;
        private DataTable dtDVBS;
        private DataTable dtDCNC;
        private string maDCNC;
        private string[] maDVBS;
        private string soHoChieu;
        public FrmDangKyDichVu()
        {
            InitializeComponent();
        }
        public FrmDangKyDichVu(string shc)
        {
            soHoChieu = shc;
            InitializeComponent();
        }

        private void FrmDangKyDichVu_Load(object sender, EventArgs e)
        {
            dvbus = new DangKyDichVuBUS();
            loadDCNC();
            loadDVBS();
            tbSoHoChieu.Text = soHoChieu;
        }
        
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        

        private void BtLuu_Click(object sender, EventArgs e)
        {
            
            
        }

        private void BtDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadDCNC()
        {
            dtDCNC = new DataTable();
            dtDCNC = dvbus.loadNoiNhapCanh();
            for(int i=0;i<dtDCNC.Rows.Count;i++)
            {
                comboNoiNhapCanh.Items.Add(dtDCNC.Rows[i][1].ToString());
            }
        }
        private void loadDVBS()
        {
            dtDVBS = new DataTable();
            dtDVBS = dvbus.loadDVBS();
            
            for (int i = 0; i < dtDVBS.Rows.Count; i++)
            {
                CheckedListBoxItem item = new CheckedListBoxItem(dtDVBS.Rows[i][1].ToString(), false);
                checkedComboBoxEdit1.Properties.Items.Add(item);
            }
        }
    }
}
