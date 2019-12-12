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
            List<DanhSachKhachHangDTO> list=khbus.select();
            if (list == null)
                MessageBox.Show("Load danh sách khách hàng thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
            {
               

            }
            loadDanhSach(list);
        }

        private void loadDanhSach(List<DanhSachKhachHangDTO> list)
        {
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = list;
            
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();
        }
    }
}
