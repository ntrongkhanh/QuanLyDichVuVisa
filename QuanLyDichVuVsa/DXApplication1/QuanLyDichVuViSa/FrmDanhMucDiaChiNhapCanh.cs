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
        private List<DiaChiNCDTO> tempList;
        private int sizeMaDCNC = 6;
        private int selectRow;

        public FrmDanhMucDiaChiNhapCanh()
        {
            InitializeComponent();
        }

        private void FrmDanhMucDiaChiNhapCanh_Load(object sender, EventArgs e)
        {

            dcbus = new DiaChiNCBUS();
            tempList = new List<DiaChiNCDTO>();

            List<DiaChiNCDTO> list = dcbus.select();

            loadDiaChi(list);

            btn_suaDCNC.Hide();
            btnThem.Show();

            dataGridView1.MouseClick += DataGridView1_MouseClick;
            dataGridView1.CellMouseDown += DataGridView1_CellMouseDown;
        }
        //XU LY SU KIEN HÀNG ĐƯỢC CLICK SẼ TÔ ĐẬM
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
        // XỬ LÝ XUẤT HIỆN MENU KHI CLICK VÀO
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
            DiaChiNCDTO dcnc = new DiaChiNCDTO();
            string maDCNC;
            string numZeroStr = ""; // String chứa có bao nhiêu số 0 trong mã

            if (tbNoiNhapCanh.Text == "")
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Có trường dữ liệu còn trống! Vui lòng điền đầy đủ!";
                return;
            }

            dcnc.DiaChiNC = tbNoiNhapCanh.Text;

            for (int i = 0; i < tempList.Count; i++)
            {
                if (int.Parse(tempList[i].MaDCNC.Substring(2)) != i + 1) // Căt pahàn số sau chữ "DC"
                {
                    i++;                                                  // Cộng giá trị lên 1 để tránh số 0
                    maDCNC = i.ToString();              
                    int numZero = sizeMaDCNC - i.ToString().Length - 2;     // tính số số 0 trong chuõi
                    for (int j = 0; j < numZero; j++)
                        numZeroStr = numZeroStr + "0";
                    dcnc.MaDCNC = "DC" + numZeroStr + i.ToString(); // Mã = DC + Số 0 + mã số
                    break;
                }
            }

            if (dcnc.MaDCNC == null)            // tra hết list nếu ko có thêm phần tử mnói
            {             
                int numZero = sizeMaDCNC - (tempList.Count + 1).ToString().Length - 2;
                for (int j = 0; j < numZero; j++)
                    numZeroStr = numZeroStr + "0";

                dcnc.MaDCNC = "DC" + numZeroStr + (tempList.Count + 1).ToString();
            }
            bool kq = dcbus.them(dcnc);
            if (kq == false)
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Thêm địa chỉ nhập cảnh thất bại! Dữ liệu có thể còn liên hệ với các bảng dữ liệu khác!";
            }
            else
            {
                FrmDanhMucDiaChiNhapCanh_Load(sender, e);
                lb_thongBao.ForeColor = Color.Green;
                lb_thongBao.Text = "Thêm địa chỉ nhập cảnh mới thành công!";
            }
        }

        void Xoa(object sender, ToolStripItemClickedEventArgs e)
        {
            DialogResult drl = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo!", MessageBoxButtons.YesNo);
            if (drl == DialogResult.No)
                return;
            DiaChiNCDTO dcnc = new DiaChiNCDTO();
            dcnc.MaDCNC = tempList[selectRow].MaDCNC;

            bool kq = dcbus.xoa(dcnc);
            if (kq == false)
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Xóa địa chỉ nhập cảnh thất bại! Có thể còn dữ liệu phụ thuộc liên quan!";
            }
            else
            {
                FrmDanhMucDiaChiNhapCanh_Load(sender, e);
                lb_thongBao.ForeColor = Color.Green;
                lb_thongBao.Text = "Xóa địa chỉ nhập cảnh thành công!";
            }
        }

        void Sua(object sender, ToolStripItemClickedEventArgs e)
        {
            tbNoiNhapCanh.Text = tempList[selectRow].DiaChiNC;
            btnThem.Hide();
            btn_suaDCNC.Show();
            btn_suaDCNC.Click += Btn_suaDCNC_Click;
        }

        private void Btn_suaDCNC_Click(object sender, EventArgs e)
        {
            if (tbNoiNhapCanh.Text == "")
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Có trường dữ liệu còn trống! Vui lòng điền đầy đủ!";
                return;

            }

            DiaChiNCDTO dcnc = new DiaChiNCDTO();
            dcnc.MaDCNC = tempList[selectRow].MaDCNC;
            dcnc.DiaChiNC = tbNoiNhapCanh.Text;

            bool kq = dcbus.sua(dcnc);
            if (kq == false)
            {
                lb_thongBao.ForeColor = Color.Red;
                lb_thongBao.Text = "Sửa địa chỉ nhập cảnh thất bại! Kiểm tra lại dữ liệu!";
            }
            else
            {
                FrmDanhMucDiaChiNhapCanh_Load(sender, e);
                lb_thongBao.ForeColor = Color.Green;
                lb_thongBao.Text = "Sửa địa chỉ nhập cảnh thành công!";
                btn_suaDCNC.Hide();
                btnThem.Show();
            }
        }
    }
}
