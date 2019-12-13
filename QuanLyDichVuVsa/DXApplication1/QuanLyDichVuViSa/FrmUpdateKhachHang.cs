using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.IO;
using QLVS_BUS;
using QLVS_DTO;
namespace QuanLyDichVuViSa
{
    public partial class FrmUpdateKhachHang : DevExpress.XtraEditors.XtraForm
    {
        private UpdateKhachHangBUS khbus;
        private string MAKH;
        private string MAQG;
        private string connectionString;
        private DataTable dt;
        private DataTable dtQG;
        private FrmMain frm;
        public FrmUpdateKhachHang()
        {
            InitializeComponent();
          //  MAKH = "KH0003";
            
        }
        public FrmUpdateKhachHang(string makh,FrmMain f)
        {
            frm = f;
            InitializeComponent();
            MAKH = makh;
            
            
        }
        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select * from khachhang where MaKH=\"" + MAKH + "\"";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();

            }
            catch (Exception ex)
            {

            }
            
        }
        private void loadcomboboxQG()
        {
            dtQG = new DataTable();
            khbus = new UpdateKhachHangBUS();
            dtQG = khbus.loadQG();
           
            for (int i = 0; i < dtQG.Rows.Count; i++)
            {
                
                
                comboQuocTich.Items.Add(dtQG.Rows[i][1].ToString());
            }
        }
        private void loadKH()
        {
            dt = new DataTable();
            dt = khbus.loadDL(MAKH);
            tbName.Text = dt.Rows[0][1].ToString();
            string gioitinh = dt.Rows[0][2].ToString();
            if (gioitinh == "nam")
                radioNam.Checked = true;
            else radioNu.Checked = true;
            dateNgaySinh.Value = (DateTime)dt.Rows[0][3];
            tbSDT.Text = dt.Rows[0][4].ToString();
            tbEmail.Text = dt.Rows[0][5].ToString();
            comboQuocTich.Items.Add(dt.Rows[0][6].ToString());
            comboQuocTich.Text = dt.Rows[0][6].ToString();

            tbSHC.Text = dt.Rows[0][7].ToString();
            foreach (DataRow dr1 in dt.Rows)
            {
                MemoryStream ms = new MemoryStream((byte[])dt.Rows[0][8]);
                pBPassport.Image = new Bitmap(ms);
                pBPassport.SizeMode = PictureBoxSizeMode.Zoom;

                MemoryStream ms1 = new MemoryStream((byte[])dt.Rows[0][9]);
                pBAvatar.Image = new Bitmap(ms1);
                pBAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void FrmUpdateKhachHang_Load(object sender, EventArgs e)
        {
            khbus = new UpdateKhachHangBUS();
            dtQG = new DataTable();
            disable();
            loadKH();
        }

        private void TextEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void enable()
        {
            tbName.ReadOnly = false;
            tbEmail.ReadOnly = false;
            tbSDT.ReadOnly = false;
            tbSHC.ReadOnly = false;
            radioNam.Enabled = true;
            radioNu.Enabled = true;
            dateNgaySinh.Enabled = true;
            btnAvatar.Visible = true;
            btnPassport.Visible = true;
            radioNam.Enabled = true;
            radioNu.Enabled = true;
            loadcomboboxQG();
            btnThayDoi.Visible = false;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            btnXoa.Visible = false;
        }
        private void disable()
        {
            tbName.ReadOnly = true;
            tbEmail.ReadOnly = true;
            tbSDT.ReadOnly = true;
            tbSHC.ReadOnly = true;
            
            dateNgaySinh.Enabled = false;
            btnAvatar.Visible = false;
            btnPassport.Visible = false;
            btnThayDoi.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            btnXoa.Visible = true;
            // comboQuocTich.Items.Clear();
        }
        private void disableRadio()
        {
            if (radioNam.Checked == true)
                radioNu.Enabled = false;
            else  radioNam.Enabled = false;
        }
        private void BtnDK_Click(object sender, EventArgs e)
        {

            FrmDangKyDichVu forms = new FrmDangKyDichVu(tbSHC.Text);
            forms.MdiParent = frm;
            forms.Show();
            Close();
            


        }
        private void sua()
        {
            if (!kiemTraDL())
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin");
                return;
            }
            UpdateKhachHangDTO khdto = new UpdateKhachHangDTO();
            khdto.MaKH = MAKH;

            khdto.HoTen = ChuanHoaChuoi(tbName.Text);
           
            if (radioNam.Checked == true)
                khdto.GioiTinh = "Nam";
            else if (radioNu.Checked == true)
                khdto.GioiTinh = "Nữ";
            khdto.NgaySinh = dateNgaySinh.Value;
            khdto.SDT = tbSDT.Text;
            khdto.Email = tbEmail.Text;
            khdto.MaQG = getMaQG().ToString();
            khdto.SoHoChieu = tbSHC.Text;
            khdto.Passport = imageToByteArray(pBPassport.Image);
            khdto.Avatar = imageToByteArray(pBAvatar.Image);
            bool kq = khbus.update(khdto);
            if (kq == true)
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công");
                disable();
            }
            else
            {
                MessageBox.Show("Sửa thông tin khách hàng thất bại");
                return;
            }
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

        private void xoa()
        {
            UpdateKhachHangDTO khdto = new UpdateKhachHangDTO();
            khdto.MaKH = MAKH;
            bool kq = khbus.delete(khdto);
            if (kq == true)
            {
                MessageBox.Show("Xóa khách hàng thành công");
                disable();
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại");
                return;
            }
        }

        private byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private bool kiemTraDL()
        {
            if (tbEmail.Text == null || tbName.Text == null || tbSDT.Text == null || tbSHC.Text == null || comboQuocTich.Text == null || pBAvatar.Image == null || pBPassport.Image == null)
                return false;
            return true;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            sua();
            
            disable();
            loadKH();
            disableRadio();
        }

        private void BtnThayDoi_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void ComboQuocTich_TextChanged(object sender, EventArgs e)
        {
            getMaQG();
        }
        private string getMaQG()
        {
            for (int i = 0; i < dtQG.Rows.Count; i++)
            {
                if (comboQuocTich.Text.ToString() == dtQG.Rows[i][1].ToString())
                {
                    MAQG = dtQG.Rows[i][0].ToString();
                }
            }
            return MAQG;
        }
        private void BtnHuy_Click(object sender, EventArgs e)
        {
            disable();
            loadKH();
            disableRadio();
        }
        string tenanh = "";
        private void BtnAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialog fdg = new OpenFileDialog();
                fdg.InitialDirectory = @"d:\";
                fdg.Filter = "File anh(*.jpg;*.bmp;*.gif)|*jpg;*bmp;*gif";
                if (fdg.ShowDialog() == DialogResult.OK)
                {
                    tenanh = fdg.FileName;
                    Bitmap anh = new Bitmap(tenanh);
                    pBAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                    pBAvatar.Image = (Image)anh;
                }
                fdg = null;
            }
            catch (Exception ex)
            {
                tenanh = "";
            }
        }

        private void BtnPassport_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialog fdg = new OpenFileDialog();
                fdg.InitialDirectory = @"d:\";
                fdg.Filter = "File anh(*.jpg;*.bmp;*.gif)|*jpg;*bmp;*gif";
                if (fdg.ShowDialog() == DialogResult.OK)
                {
                    tenanh = fdg.FileName;
                    Bitmap anh = new Bitmap(tenanh);
                    pBPassport.SizeMode = PictureBoxSizeMode.Zoom;
                    pBPassport.Image = (Image)anh;
                }
                fdg = null;
            }
            catch (Exception ex)
            {
                tenanh = "";
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn Xóa ", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
            xoa();
            Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something elsef
               
            }
            
        }
    }
}