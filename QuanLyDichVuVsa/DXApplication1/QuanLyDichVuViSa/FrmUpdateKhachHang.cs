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

namespace QuanLyDichVuViSa
{
    public partial class FrmUpdateKhachHang : DevExpress.XtraEditors.XtraForm
    {
        private string MAKH;
        private string connectionString;
        public FrmUpdateKhachHang()
        {
            InitializeComponent();
          //  MAKH = "KH0003";
            connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
        }
        public FrmUpdateKhachHang(string makh)
        {
            InitializeComponent();
            MAKH = makh;
            connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
        }
        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUpdateKhachHang_Load(object sender, EventArgs e)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select * from khachhang where MaKH=\""+MAKH+"\"";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();

            }
            catch (Exception ex)
            {

            }
            tbEmail.Text = k.Rows[0][5].ToString();
            foreach (DataRow dr1 in k.Rows)
            {
                MemoryStream ms = new MemoryStream((byte[])k.Rows[0][8]);
                pBPassport.Image = new Bitmap(ms);
                pBPassport.SizeMode = PictureBoxSizeMode.Zoom;

                MemoryStream ms1 = new MemoryStream((byte[])k.Rows[0][9]);
                pBAvatar.Image = new Bitmap(ms1);
                pBAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }
    }
}