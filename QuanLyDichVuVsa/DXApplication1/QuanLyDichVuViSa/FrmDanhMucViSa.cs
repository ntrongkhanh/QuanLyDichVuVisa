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
    public partial class FrmDanhMucViSa : Form
    {
        private LoaiViSaBUS visabus;
        private List<LoaiViSaDTO> tempList;
        private int sizeMaLoaiVS = 6;
        private int selectRow;


        public FrmDanhMucViSa()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmDanhMucViSa_Load(object sender, EventArgs e)
        {
            visabus = new LoaiViSaBUS();
            tempList = new List<LoaiViSaDTO>();
            List<LoaiViSaDTO> list = visabus.select();

            loadDiaChi(list);

            btnThem.Show();
            btn_Sua.Hide();

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
            LoaiViSaDTO loaiVS = new LoaiViSaDTO();
            loaiVS.MaLVS = tempList[selectRow].MaLVS;

            bool kq = visabus.xoa(loaiVS);
            if (kq == false)
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Xóa địa chỉ nhập cảnh thất bại! Có thể còn dữ liệu phụ thuộc liên quan!";
            }
            else
            {
                FrmDanhMucViSa_Load(sender, e);
                lb_thongBao.ForeColor = Color.Green;
                lb_thongBao.Text = "Xóa địa chỉ nhập cảnh thành công!";
            }
        }

        void Sua(object sender, ToolStripItemClickedEventArgs e)
        {
            tbLoaiViSa.Text = tempList[selectRow].Ten;
            btnThem.Hide();
            btn_Sua.Show();
            btn_Sua.Click += Btn_Sua_Click;
        }

        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (tbLoaiViSa.Text == "" || tbChiPhi.Text == "")
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Có trường dữ liệu còn trống! Vui lòng điền đầy đủ!";
                return;
            }

            LoaiViSaDTO loaiVS = new LoaiViSaDTO();
            loaiVS.MaLVS = tempList[selectRow].MaLVS;
            loaiVS.Ten = tbLoaiViSa.Text;
            loaiVS.ChiPhi = int.Parse(tbChiPhi.Text);

            bool kq = visabus.sua(loaiVS);
            if (kq == false)
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Sửa loại VISA thất bại! Kiểm tra lại dữ liệu!";
            }
            else
            {
                FrmDanhMucViSa_Load(sender, e);
                lb_thongBao.ForeColor = Color.Green;
                lb_thongBao.Text = "Sửa loại VISA thành công!";
                btn_Sua.Hide();
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

        private void loadDiaChi(List<LoaiViSaDTO> list)
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

            var bindingList = new BindingList<LoaiViSaDTO>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            // dataGridView1.DataSource = list;
            
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();

            tempList = list;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbLoaiViSa.Text == "" || tbChiPhi.Text == "")
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Có trường dữ liệu còn trống! Vui lòng điền đầy đủ!";
                return;
            }

            LoaiViSaDTO loaiVS = new LoaiViSaDTO();
            string maLoaiVS;
            string numZeroStr = ""; // String chứa có bao nhiêu số 0 trong mã

            loaiVS.Ten = tbLoaiViSa.Text;
            loaiVS.ChiPhi = int.Parse(tbChiPhi.Text.ToString());

            for (int i = 0; i < tempList.Count; i++)
            {
                if (int.Parse(tempList[i].MaLVS.Substring(3)) != i + 1) // Căt pahàn số sau chữ "DC"
                {
                    i++;                                                  // Cộng giá trị lên 1 để tránh số 0
                    maLoaiVS = i.ToString();
                    int numZero = sizeMaLoaiVS - i.ToString().Length - 3;     // tính số số 0 trong chuõi
                    for (int j = 0; j < numZero; j++)
                        numZeroStr = numZeroStr + "0";
                    loaiVS.MaLVS = "LVS" + numZeroStr + i.ToString(); // Mã = LSV + Số 0 + mã số
                    break;
                }
            }

            if (loaiVS.MaLVS == null)            // tra hết list nếu ko có thêm phần tử mnói
            {
                int numZero = sizeMaLoaiVS - (tempList.Count + 1).ToString().Length - 3;
                for (int j = 0; j < numZero; j++)
                    numZeroStr = numZeroStr + "0";

                loaiVS.MaLVS = "LVS" + numZeroStr + (tempList.Count + 1).ToString();
            }
            bool kq = visabus.them(loaiVS);
            if (kq == false)
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Thêm loại VISA thất bại! Dữ liệu có thể còn liên hệ với các bảng dữ liệu khác!";
            }
            else
            {
                FrmDanhMucViSa_Load(sender, e);
                lb_thongBao.ForeColor = Color.Green;
                lb_thongBao.Text = "Thêm loại VISA mới thành công!";
            }

        }

        private void tbChiPhi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
