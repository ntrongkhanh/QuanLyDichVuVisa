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
using System.Collections;

namespace QuanLyDichVuViSa
{
    public partial class FrmDangKyDichVu : Form
    {
        private DangKyDichVuBUS dvbus;
        private DataTable dtDVBS;
        private DataTable dtDCNC;
        private DataTable dtLoaiVS;
        private DataTable dtTGXL;

        private int giaViSa = 0;
        private int giaTGXL = 0;
        private int giaDVBS = 0;
        private int tongGia = 0;
        private string maLoaiViSa;
        private string maTGXL;
        private string maKH;
        private string maDCNC;
        
        
        private List<string> maDVBS=new List<string>();
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
            loadTGXL();
            loadLoaiVISA();
            tbSoHoChieu.Text = soHoChieu;
            if (soHoChieu != "")
                loadThongTinKH();
        }
        
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void dangKy()
        {
            DangKyDichVuDTO dk = new DangKyDichVuDTO();
            dk.MaDV = TaoMaTuDong();
            dk.MaDCNC = maDCNC;
            dk.MaLoaiViSa = maLoaiViSa;
            dk.MaKH = maKH;
            dk.NoiCap = ChuanHoaChuoi(tbNoiCap.Text);
            dk.NoiNhan = ChuanHoaChuoi(tbNoiNhan.Text);
            dk.NgayDK = dateNgayDK.Value;
            dk.NgayNhapCanh = dateNgayNhapCanh.Value;
            dk.NgayXuatCanh = dateNgayXuatCanh.Value;
            dk.MaTGXL = maTGXL;
            dk.ChiPhi = tongGia;
            bool kq = dvbus.insert(dk);
            if (kq == true)
            {
                MessageBox.Show("Thêm thành công");

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
                return;
            }
            if (checkDVBS())
            {
                foreach (CheckedListBoxItem item in checkedComboBoxEdit1.Properties.Items)
                {
                    
                    if (item.CheckState == CheckState.Checked)
                    {

                        for(int i =0;i<dtDVBS.Rows.Count;i++)
                        {
                            if(item.ToString()==dtDVBS.Rows[i][1].ToString())
                            {
                                string x = dtDVBS.Rows[i][0].ToString();

                                maDVBS.Add(x);
                            }
                        }

                    }
                }
                dk.Madvbs = maDVBS;
               kq = dvbus.insertDanhSachDVBS(dk);
            }
            
            
        }

        private bool checkDVBS()
        {
            foreach (CheckedListBoxItem item in checkedComboBoxEdit1.Properties.Items)
            {
                
                if (item.CheckState == CheckState.Checked)
                {
                    return true;


                }
            }
            return false;
        }
        private void BtLuu_Click(object sender, EventArgs e)
        {
            if(checkDL())
                 dangKy();
            
        }
        private string ChuanHoaChuoi(string xau)
        {
            string kq = "";
            xau = xau.Trim().ToLower();//Phải đổi sang Unicode thì sử dụng .ToLower() không bị lỗi font
            for (int i = 0; i < xau.Length; i++)
            {
                if (i == 0)
                    kq += xau[i].ToString().ToUpper();
                else
                    kq += xau[i];
                if (xau[i] == ' ')
                {
                    while (xau[i] == ' ')
                    {
                        i++;
                    }
                    kq += xau[i].ToString().ToUpper();
                }
            }
            return kq.ToString();
        }
        private bool checkDL()
        {
            if (comboLoaiViSa.Text == "" || comboThoiGianXL.Text == "" || tbNoiNhan.Text == "" || tbNoiCap.Text == "" || comboNoiNhapCanh.Text == "")
                return false;
            return true;
        }
        private string TaoMaTuDong()
        {
            DataTable dtKH = new DataTable();
            dtKH = dvbus.loadDanhSachDV();




            //Phương thức thứ 2 là Substring(int index,int lenght).
            //Phuơng thức này sẽ trả về chuỗi con của chuỗi từ vị trí bắt đầu (index) và có chiều dài bao nhiêu (lenght)
            int coso = 0;
            if (dtKH.Rows.Count == 0)// nếu danh sách thuốc rỗng
            {
                coso = 1;
            }
            else if (dtKH.Rows.Count == 1 && int.Parse(dtKH.Rows[0][0].ToString().Substring(2, 4)) == 1) // nếu danh sách có khach hang ma khach hang  này là KH0001
            {
                coso = 2;
            }
            else if (dtKH.Rows.Count == 1 && int.Parse(dtKH.Rows[0][0].ToString().Substring(2, 4)) > 1) // nếu danh sách có 1 thuốc mà mã thuốc này khác T001
            {

                coso = 1;
            }
            else // nếu danh sách có hơn 1 kh
            {
                for (int i = 0; i < dtKH.Rows.Count - 1; i++)
                {
                    if (int.Parse(dtKH.Rows[0][0].ToString().Substring(2, 4)) != 1)
                    {
                       
                        coso = 1;
                        break;
                    }
                    else
                    if ((int.Parse(dtKH.Rows[i + 1][0].ToString().Substring(2, 4)) - int.Parse(dtKH.Rows[i][0].ToString().Substring(2, 4))) > 1)
                    {
                        coso = int.Parse(dtKH.Rows[i][0].ToString().Substring(2, 4)) + 1;
                        break;
                    }
                    else if (i == dtKH.Rows.Count - 2)
                        coso = int.Parse(dtKH.Rows[dtKH.Rows.Count - 1][0].ToString().Substring(2, 4)) + 1;
                }


            }

            //Sau khi lấy được cơ số thứ tự của thuốc, ta gắn thêm tiền tố T vào

            string ma = "";
            if (coso < 10)
                return ma = "DV000" + coso;
            else if (coso < 100)
                return ma = "DV00" + coso;
            else if (coso < 1000)
                return ma = "DV0" + coso;
            else
                return ma = "DV" + coso;

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
        private void loadLoaiVISA()
        {
            dtLoaiVS = new DataTable();
            dtLoaiVS = dvbus.loadLoaiViSa();
            for (int i = 0; i < dtLoaiVS.Rows.Count; i++)
            {
                comboLoaiViSa.Items.Add(dtLoaiVS.Rows[i][1].ToString());
            }
        }
        private void loadTGXL()
        {
            dtTGXL = new DataTable();
            dtTGXL = dvbus.loadTGXL();
            for (int i = 0; i < dtTGXL.Rows.Count; i++)
            {
                comboThoiGianXL.Items.Add(dtTGXL.Rows[i][1].ToString());
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

        private void ComboLoaiViSa_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dtLoaiVS.Rows.Count; i++)
            {
                if (comboLoaiViSa.Text.ToString() == dtLoaiVS.Rows[i][1].ToString())
                {
                    giaViSa =int.Parse(dtLoaiVS.Rows[i][2].ToString());
                    maLoaiViSa = dtLoaiVS.Rows[i][0].ToString();
                    labelGiaViSa.Text = giaViSa.ToString()+" USD";
                }
            }
            tongGia = giaDVBS + giaTGXL + giaViSa;
            labelTongChiPhi.Text = (tongGia).ToString() + " USD";
        }

        private void ComboThoiGianXL_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dtTGXL.Rows.Count; i++)
            {
                if (comboThoiGianXL.Text.ToString() == dtTGXL.Rows[i][1].ToString())
                {
                    giaTGXL = int.Parse(dtTGXL.Rows[i][3].ToString());
                    maTGXL = dtTGXL.Rows[i][0].ToString();
                    labelGiaThoiGian.Text = giaTGXL.ToString() + " USD";
                }
            }
            tongGia = giaDVBS + giaTGXL + giaViSa;
            labelTongChiPhi.Text = (tongGia).ToString() + " USD";
        }

        private void ComboNoiNhapCanh_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dtDCNC.Rows.Count; i++)
            {
                if (comboNoiNhapCanh.Text.ToString() == dtDCNC.Rows[i][1].ToString())
                {
                   
                    maDCNC = dtDCNC.Rows[i][0].ToString();
                    
                }
            }
            tongGia = giaDVBS + giaTGXL + giaViSa;
            labelTongChiPhi.Text = (tongGia).ToString() + " USD";
        }

        private void CheckedComboBoxEdit1_TextChanged(object sender, EventArgs e)
        {
            //checkedComboBoxEdit1.
        }

        private void CheckedComboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {

            ArrayList checkedItems = new ArrayList();
            foreach (CheckedListBoxItem item in checkedComboBoxEdit1.Properties.Items)
            {
                giaDVBS = 0;
                if (item.CheckState == CheckState.Checked)
                {
                    for (int i = 0; i < dtDVBS.Rows.Count; i++)
                    {
                        if (item.ToString() == dtDVBS.Rows[i][1].ToString())
                        {
                            



                            maDVBS.Add(dtDVBS.Rows[i][0].ToString());
                            giaDVBS += int.Parse(dtDVBS.Rows[i][2].ToString());
                        }
                    }

                    
                }
            }
            labelGiaDVBS.Text = giaDVBS.ToString() + " USD";
            tongGia = giaDVBS + giaTGXL + giaViSa;
            labelTongChiPhi.Text = (tongGia).ToString() + " USD";
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            loadThongTinKH();
        }
        private void loadThongTinKH()
        {
            DataTable dtKH = new DataTable();
            dtKH = dvbus.loadThongTinKH(tbSoHoChieu.Text);
            if (dtKH.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng");
                return;
            }
            tbTen.Text = dtKH.Rows[0][1].ToString();
            tbSDT.Text = dtKH.Rows[0][4].ToString();
            tbQuocGia.Text= dtKH.Rows[0][11].ToString();
            tbEmail.Text= dtKH.Rows[0][5].ToString();
            string gt= dtKH.Rows[0][2].ToString();
            if (gt == "nam" || gt == "Nam")
            {
                radioNam.Enabled = true;
                radioNam.Checked = true;
                radioNu.Enabled = false;
            }
            else
            {
                radioNu.Enabled = true;
                radioNam.Enabled = false;
                radioNu.Checked = true;
            }
            maKH= dtKH.Rows[0][0].ToString();

        }
    }
}
