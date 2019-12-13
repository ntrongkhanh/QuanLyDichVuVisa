using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLVS_DTO;
using QLVS_BUS;
namespace QuanLyDichVuViSa
{
    public partial class FrmDanhSachKhachHang : Form
    {
        private DanhSachKhachHangBUS khbus;
        private string maKH;

        FrmMain frmMain;
        public FrmDanhSachKhachHang(FrmMain f)
        {
            frmMain = f;
            InitializeComponent();
        }
        public FrmDanhSachKhachHang()
        {
            InitializeComponent();
        }
        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            khbus = new DanhSachKhachHangBUS();
            List<DanhSachKhachHangDTO> list = khbus.select();
            if (list == null)
                MessageBox.Show("Load danh sách khách hàng thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
            {   

            }
            loadDanhSach(list);
        }

        public void loadDanhSach(List<DanhSachKhachHangDTO> list)
        {
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = list;
            
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            string strTuKhoa = tbTimKiem.Text.Trim();
            if (strTuKhoa == null || strTuKhoa == string.Empty || strTuKhoa.Length == 0)
            {
                List<DanhSachKhachHangDTO> list = khbus.select();
                loadDanhSach(list);
            }
            else
            {
                List<DanhSachKhachHangDTO> list = khbus.selectByKeyword(strTuKhoa);
                if (list.Count == 0)
                    MessageBox.Show("Không tìm thấy khách hàng");
                loadDanhSach(list);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                int r = dataGridView1.CurrentRow.Index;
                DataGridViewRow row = dataGridView1.Rows[r];
                maKH = row.Cells[0].Value.ToString();
                FrmUpdateKhachHang frmUpdateKhachHang = new FrmUpdateKhachHang(maKH,frmMain);
            
                frmUpdateKhachHang.Show();
            }
           
            
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            List<DanhSachKhachHangDTO> list = khbus.select();
            loadDanhSach(list);
            tbTimKiem.Text="";
        }

        private void TbTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                string strTuKhoa = tbTimKiem.Text.Trim();
                if (strTuKhoa == null || strTuKhoa == string.Empty || strTuKhoa.Length == 0)
                {
                    List<DanhSachKhachHangDTO> list = khbus.select();
                   loadDanhSach(list);
                }
               else
               {
                    List<DanhSachKhachHangDTO> list = khbus.selectByKeyword(strTuKhoa);
                    if (list.Count == 0)
                    MessageBox.Show("Không tìm thấy khách hàng");
                    loadDanhSach(list);
                }
            }
            
        }
    }
}
