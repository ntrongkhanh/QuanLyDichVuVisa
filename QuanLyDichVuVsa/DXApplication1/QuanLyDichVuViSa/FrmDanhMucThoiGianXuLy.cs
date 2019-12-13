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
    public partial class FrmDanhMucThoiGianXuLy : Form
    {
        ThoiGianXuLyBUS tgbus;
        private List<ThoiGianXuLyDTO> tempList;
        private int sizeMaTGXL = 6;
        private int selectRow;


        public FrmDanhMucThoiGianXuLy()
        {
            InitializeComponent();
        }

        private void FrmDanhMucThoiGianXuLy_Load(object sender, EventArgs e)
        {
            tgbus = new ThoiGianXuLyBUS();
            tempList = new List<ThoiGianXuLyDTO>();

            List<ThoiGianXuLyDTO> list = tgbus.select();

            loadThoiGianXL(list);

            btnThem.Show();
            bt_Sua.Hide();

            dataGridView1.CellMouseDown += DataGridView1_CellMouseDown;
            dataGridView1.MouseClick += DataGridView1_MouseClick;
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
            ThoiGianXuLyDTO thoiGian = new ThoiGianXuLyDTO();
            thoiGian.MaTG = tempList[selectRow].MaTG;

            bool kq = tgbus.xoa(thoiGian);
            if (kq == false)
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Xóa thời gian xử lý thất bại! Có thể còn dữ liệu phụ thuộc liên quan!";
            }
            else
            {
                FrmDanhMucThoiGianXuLy_Load(sender, e);
                lb_thongBao.ForeColor = Color.Green;
                lb_thongBao.Text = "Xóa thời gian xử lý thành công!";
            }
        }

        void Sua(object sender, ToolStripItemClickedEventArgs e)
        {
            tbThoiGian.Text = tempList[selectRow].ThoiGian;
            tb_soNgay.Text = tempList[selectRow].SoNgay.ToString();
            tbChiPhi.Text = tempList[selectRow].ChiPhi.ToString();
            btnThem.Hide();
            bt_Sua.Show();
            bt_Sua.Click += Bt_Sua_Click;
        }

        private void Bt_Sua_Click(object sender, EventArgs e)
        {
            if (tbThoiGian.Text == "" || tb_soNgay.Text == "" || tbChiPhi.Text == "")
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Có trường dữ liệu còn trống! Vui lòng điền đầy đủ!";
                return;
            }

            ThoiGianXuLyDTO thoiGian = new ThoiGianXuLyDTO();
            thoiGian.MaTG = tempList[selectRow].MaTG;
            thoiGian.ThoiGian = tbThoiGian.Text;
            thoiGian.SoNgay = int.Parse(tb_soNgay.Text);
            thoiGian.ChiPhi = int.Parse(tbChiPhi.Text);

            bool kq = tgbus.sua(thoiGian);
            if (kq == false)
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Sửa thời gian xử lý thất bại! Kiểm tra lại dữ liệu!";
            }
            else
            {
                FrmDanhMucThoiGianXuLy_Load(sender, e);
                lb_thongBao.ForeColor = Color.Green;
                lb_thongBao.Text = "Sửa thời gian xử lý thành công!";
                bt_Sua.Hide();
                btnThem.Show();
            }
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

        private void loadThoiGianXL(List<ThoiGianXuLyDTO> list)
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

            var bindingList = new BindingList<ThoiGianXuLyDTO>(list);
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
            if (tbThoiGian.Text == "" || tb_soNgay.Text == "" || tbChiPhi.Text == "")
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Có trường dữ liệu còn trống! Vui lòng điền đầy đủ!";
                return;
            }

            ThoiGianXuLyDTO thoiGian = new ThoiGianXuLyDTO();
            string maTGXLEx;
            string numZeroStr = ""; // String chứa có bao nhiêu số 0 trong mã

            thoiGian.ThoiGian = tbThoiGian.Text;
            thoiGian.SoNgay = int.Parse(tb_soNgay.Text);
            thoiGian.ChiPhi = int.Parse(tbChiPhi.Text);

            for (int i = 0; i < tempList.Count; i++)
            {
                if (int.Parse(tempList[i].MaTG.Substring(4)) != i + 1) // Căt pahàn số sau chữ "DC"
                {
                    i++;                                                  // Cộng giá trị lên 1 để tránh số 0
                    maTGXLEx = i.ToString();
                    int numZero = sizeMaTGXL - i.ToString().Length - 4;     // tính số số 0 trong chuõi
                    for (int j = 0; j < numZero; j++)
                        numZeroStr = numZeroStr + "0";
                    thoiGian.MaTG = "TGXL" + numZeroStr + i.ToString(); // Mã = TGXL + Số 0 + mã số
                    break;
                }
            }

            if (thoiGian.MaTG == null)            // tra hết list nếu ko có thêm phần tử mnói
            {
                int numZero = sizeMaTGXL - (tempList.Count + 1).ToString().Length - 4;
                for (int j = 0; j < numZero; j++)
                    numZeroStr = numZeroStr + "0";

                thoiGian.MaTG = "TGXL" + numZeroStr + (tempList.Count + 1).ToString();
            }
            bool kq = tgbus.them(thoiGian);
            if (kq == false)
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Thêm thời gian xử lý thất bại! Dữ liệu có thể còn liên hệ với các bảng dữ liệu khác!";
            }
            else
            {
                FrmDanhMucThoiGianXuLy_Load(sender, e);
                lb_thongBao.ForeColor = Color.Green;
                lb_thongBao.Text = "Thêm thời gian xử lý mới thành công!";
            }

        }

        private void tbChiPhi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_soNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
