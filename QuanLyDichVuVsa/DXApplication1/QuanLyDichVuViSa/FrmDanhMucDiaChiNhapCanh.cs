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
    
    public partial class FrmDanhMucDiaChiNhapCanh : Form
    {
        private DiaChiNCBUS dcbus;
        public FrmDanhMucDiaChiNhapCanh()
        {
            InitializeComponent();
        }

        private void FrmDanhMucDiaChiNhapCanh_Load(object sender, EventArgs e)
        {
           
            dcbus = new DiaChiNCBUS();
            List<DiaChiNCDTO> list = dcbus.select();
           
            loadDiaChi(list);
        }

        private void loadDiaChi(List<DiaChiNCDTO> list)
        {
            //dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            //DataGridViewTextBoxColumn ma = new DataGridViewTextBoxColumn();
            //ma.Name = "MaDCNC";
            //ma.HeaderText = "Mã Địa Chỉ Nhập cảnh";
            //ma.DataPropertyName = "MaDCNC";
            //dataGridView1.Columns.Add(ma);

            //DataGridViewTextBoxColumn diachi = new DataGridViewTextBoxColumn();
            //diachi.Name = "DiaChiNC";
            //diachi.HeaderText = "Địa Chỉ Nhập Cảnh";
            //diachi.DataPropertyName = "DiaChiNC";
            //dataGridView1.Columns.Add(diachi);

            var bindingList = new BindingList<DiaChiNCDTO>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            // dataGridView1.DataSource = list;
            MessageBox.Show(list.Count.ToString());
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();


        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
