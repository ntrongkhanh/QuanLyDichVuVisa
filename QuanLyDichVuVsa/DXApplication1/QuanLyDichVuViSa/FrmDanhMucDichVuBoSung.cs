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
    public partial class FrmDanhMucDichVuBoSung : Form
    {
        private DichVuBoSungBUS dvbus;
        private List<DichVuBoSungDTO> tempList;
        private int sizeMaDVBS = 6;
        private int selectRow;

        public FrmDanhMucDichVuBoSung()
        {
            InitializeComponent();
        }

        private void FrmDanhMucDichVuBoSung_Load(object sender, EventArgs e)
        {
            dvbus = new DichVuBoSungBUS();
            tempList = new List<DichVuBoSungDTO>();

            List<DichVuBoSungDTO> list = dvbus.select();

            loadDichVu(list);

            btn_Sua.Hide();
            btnThem.Show();

            dataGridView1.MouseClick += DataGridView1_MouseClick;
            dataGridView1.CellMouseDown += DataGridView1_CellMouseDown;
        }

        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    return;
                selectRow = e.RowIndex;
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dataGridView1.Rows[e.RowIndex].Selected = true;
                dataGridView1.Focus();
            }
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();

                int position_row = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (position_row >= 0)
                {
                    menu.Items.Add("Xóa").Name = "xoa";
                    menu.Items.Add("Sửa").Name = "sua";
                }
                menu.Show(dataGridView1, new Point(e.X, e.Y));
                menu.ItemClicked += Menu_ItemClicked;
            }
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "xoa":
                    Xoa(sender, e);
                    break;
                case "sua":
                    Sua(sender, e);
                    break;
            }
        }

        void Xoa(object sender, ToolStripItemClickedEventArgs e)
        {
            DialogResult drl = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo!", MessageBoxButtons.YesNo);
            if (drl == DialogResult.No)
                return;
            DichVuBoSungDTO dichVu = new DichVuBoSungDTO();
            dichVu.MaDVBS = tempList[selectRow].MaDVBS;

            bool kq = dvbus.xoa(dichVu);
            if (kq == false)
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Xóa dịch vụ bổ sung thất bại! Có thể còn dữ liệu phụ thuộc liên quan!";
            }
            else
            {
                FrmDanhMucDichVuBoSung_Load(sender, e);
                lb_thongBao.ForeColor = Color.Green;
                lb_thongBao.Text = "Xóa dịch vụ bổ sung thành công!";
            }
        }

        void Sua(object sender, ToolStripItemClickedEventArgs e)
        {
            tbTenDichVu.Text = tempList[selectRow].Ten;
            tbChiPhi.Text = tempList[selectRow].ChiPhi.ToString();
            btnThem.Hide();
            btn_Sua.Show();
            btn_Sua.Click += Btn_Sua_Click;
        }

        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (tbTenDichVu.Text == "" || tbChiPhi.Text == "")
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Có trường dữ liệu còn trống! Vui lòng điền đầy đủ!";
                return;
            }

            DichVuBoSungDTO dichVu = new DichVuBoSungDTO();
            dichVu.MaDVBS = tempList[selectRow].MaDVBS;
            dichVu.Ten = tbTenDichVu.Text;
            dichVu.ChiPhi = int.Parse(tbChiPhi.Text);

            bool kq = dvbus.sua(dichVu);
            if (kq == false)
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Sửa dịch vụ bổ sung thất bại! Kiểm tra lại dữ liệu!";
            }
            else
            {
                FrmDanhMucDichVuBoSung_Load(sender, e);
                lb_thongBao.ForeColor = Color.Green;
                lb_thongBao.Text = "Sửa địa chỉ nhập cảnh thành công!";
                btn_Sua.Hide();
                btnThem.Show();
            }
        }

        private void loadDichVu(List<DichVuBoSungDTO> list)
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

            var bindingList = new BindingList<DichVuBoSungDTO>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            // dataGridView1.DataSource = list;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();

            tempList = list;
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbTenDichVu.Text == "" || tbChiPhi.Text == "")
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Có trường dữ liệu còn trống! Vui lòng điền đầy đủ!";
                return;
            }

            DichVuBoSungDTO dichVu = new DichVuBoSungDTO();
            string maDVBSEx;
            string numZeroStr = "";

            dichVu.Ten = tbTenDichVu.Text;
            dichVu.ChiPhi = int.Parse(tbChiPhi.Text);

            for (int i = 0; i < tempList.Count; i++)
            {
                if (int.Parse(tempList[i].MaDVBS.Substring(4)) != i + 1)
                {
                    i++;
                    maDVBSEx = i.ToString();
                    int numZero = sizeMaDVBS - i.ToString().Length - 4;
                    for (int j = 0; j < numZero; j++)
                        numZeroStr = numZeroStr + "0";
                    dichVu.MaDVBS = "DVBS" + numZeroStr + i.ToString();
                    break;
                }
            }
            if (dichVu.MaDVBS == null)
            {
                int numZero = sizeMaDVBS - (tempList.Count + 1).ToString().Length - 4;
                for (int j = 0; j < numZero; j++)
                    numZeroStr = numZeroStr + "0";

                dichVu.MaDVBS = "DVBS" + numZeroStr + (tempList.Count + 1).ToString();

            }

            bool kq = dvbus.them(dichVu);
            if (kq == false)
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Thêm dịch vụ bổ sung thất bại! Dữ liệu có thể còn liên hệ với các bảng dữ liệu khác!";
            }
            else
            {
                FrmDanhMucDichVuBoSung_Load(sender, e);
                lb_thongBao.ForeColor = Color.Green;
                lb_thongBao.Text = "Thêm dịch vụ bổ dung mới thành công!";
            }
        }

        private void tbChiPhi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
