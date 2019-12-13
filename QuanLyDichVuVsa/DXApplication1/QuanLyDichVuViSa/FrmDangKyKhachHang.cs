using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLVS_BUS;
using QLVS_DTO;
namespace QuanLyDichVuViSa
{
    public partial class FrmDangKyKhachHang : Form
    {
        private DangKyKhachHangBUS khbus;
        private DataTable dt;
        private string maQG;
        private string tenanh;
        public FrmDangKyKhachHang()
        {
            
            InitializeComponent();
            
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadcomboboxQG()
        {
            dt = new DataTable();
            khbus = new DangKyKhachHangBUS();
            dt = khbus.loadQGtoCombobox();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboQuocTich.Items.Add(dt.Rows[i][1].ToString());
            }
            comboQuocTich.Text = dt.Rows[0][1].ToString();
        }

        private void FrmDangKyKhachHang_Load(object sender, EventArgs e)
        {

            loadcomboboxQG();

        }

        private void ComboQuocTich_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(comboQuocTich.Text.ToString()==dt.Rows[i][1].ToString())
                {
                    maQG = dt.Rows[i][0].ToString();
                }
            }
        }

        private void BtnChonAnh_Click(object sender, EventArgs e)
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
        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private void BtnDangKi_Click(object sender, EventArgs e)
        {

            if (!kiemTraDL())
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin");
                return;
            }
            DangKyKhachHangDTO khdto = new DangKyKhachHangDTO();
            khdto.MaKH = TaoMaTuDong();
            khdto.HoTen = ChuanHoaChuoi(tbName.Text);
            if (radioNam.Checked == true)
                khdto.GioiTinh = "Nam";
            else if (radioNu.Checked == true)
                khdto.GioiTinh = "Nữ";
            khdto.NgaySinh = dateNgaySinh.Value;
            khdto.SDT = tbSDT.Text;
            khdto.Email = tbEmail.Text;
            khdto.MaQG = maQG.ToString();
            khdto.SoHoChieu = tbSHC.Text;
            khdto.Passport = imageToByteArray(pBPassport.Image);
            khdto.Avatar = imageToByteArray(pBAvatar.Image);
            bool kq = khbus.them(khdto);
            if (kq == true)
            {
                MessageBox.Show("Thêm khách hàng thành công");
                empty();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại");
                return;
            }

        }
        private string TaoMaTuDong()
        {
            DataTable dtKH = new DataTable();
            dtKH = khbus.loadDuLieuKH();
           
            
            

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
                    if(int.Parse(dtKH.Rows[0][0].ToString().Substring(2, 4))!=1)
                    {
                        MessageBox.Show("dsadsad");
                        coso = 1;
                        break;
                    }else
                    if ((int.Parse(dtKH.Rows[i + 1][0].ToString().Substring(2, 4)) - int.Parse(dtKH.Rows[i][0].ToString().Substring(2, 4)))> 1)
                    {
                        coso = int.Parse(dtKH.Rows[i][0].ToString().Substring(2, 4)) + 1;
                        break;
                    }
                    else if(i== dtKH.Rows.Count - 2)
                        coso = int.Parse(dtKH.Rows[dtKH.Rows.Count - 1][0].ToString().Substring(2, 4)) + 1;
                }
               
                
            }

            //Sau khi lấy được cơ số thứ tự của thuốc, ta gắn thêm tiền tố T vào

            string ma = "";
            if (coso < 10)
                return ma = "KH000" + coso;
            else if (coso < 100)
                return ma = "KH00" + coso;
            else if(coso<1000)
                return ma = "KH0" + coso;
            else
                return ma = "KH" + coso;

        }
        
        private void BtnChonPass_Click(object sender, EventArgs e)
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
        private bool kiemTraDL()
        {
            if (tbEmail.Text == "" || tbName.Text == "" || tbSDT.Text == "" || tbSHC.Text == "" || comboQuocTich.Text == "" || pBAvatar.Image == null || pBPassport.Image == null)
             return false;
            return true;
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

        private void TbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void empty()
        {
            tbEmail.Text = tbName.Text = tbSDT.Text = tbSHC.Text = null;
            pBAvatar.Image = null;
            pBPassport.Image = null;
            comboQuocTich.Text = null;
            
        }
    }
}
