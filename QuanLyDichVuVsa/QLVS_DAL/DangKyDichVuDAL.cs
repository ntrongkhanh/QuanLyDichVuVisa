using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QLVS_DTO;
namespace QLVS_DAL
{
  public  class DangKyDichVuDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public DangKyDichVuDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public DataTable loadNoiNhapCanh()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "SELECT * FROM DCNHAPCANH";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();

            }
            catch (Exception e)
            {

            }
            return k;
        }
        public DataTable loadLoaiVISA()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "SELECT * FROM loaivisa";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();

            }
            catch (Exception e)
            {

            }
            return k;
        }
        public DataTable loadTGXL()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "SELECT * FROM thoigianxuly";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();

            }
            catch (Exception e)
            {

            }
            return k;
        }
        public bool insertDanhSachDVBS(DangKyDichVuDTO dt)
        {
            foreach (string str in dt.Madvbs)
            {
                string query = string.Empty;
                query += "insert into danhsachdichvubosung" +
                            " values (@madvbs,@madv)";


                using (MySqlConnection con = new MySqlConnection(ConnectionString))
                {

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;

                        cmd.Parameters.AddWithValue("@madv", dt.MaDV);
                        cmd.Parameters.AddWithValue("@madvbs", str);

                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            con.Dispose();
                        }
                        catch (Exception ex)
                        {

                            con.Close();
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public bool insert(DangKyDichVuDTO dt)
        {
            string query = string.Empty;
            query += "insert into dichvu"+
                        " values(@madv, @malvs, @madcnc, @makh, @noicap, @ngaydk, @ngaynhapcanh, @ngayxuatcanh, @matgxl, @noinhan, @chiphi, \"TT0001\")";


            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@madv", dt.MaDV);
                    cmd.Parameters.AddWithValue("@malvs", dt.MaLoaiViSa);
                    cmd.Parameters.AddWithValue("@madcnc", dt.MaDCNC);
                    cmd.Parameters.AddWithValue("@makh", dt.MaKH);
                    cmd.Parameters.AddWithValue("@noicap", dt.NoiCap);
                    cmd.Parameters.AddWithValue("@ngaydk", dt.NgayDK);
                    cmd.Parameters.AddWithValue("@ngaynhapcanh", dt.NgayNhapCanh);
                    cmd.Parameters.AddWithValue("@ngayxuatcanh", dt.NgayXuatCanh);
                    cmd.Parameters.AddWithValue("@matgxl", dt.MaTGXL);
                    cmd.Parameters.AddWithValue("@noinhan", dt.NoiNhan);
                    cmd.Parameters.AddWithValue("@chiphi", dt.ChiPhi);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {

                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        public DataTable loadDVBS()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select * from dichvubosung";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();

            }
            catch (Exception e)
            {

            }
            return k;
        }
        public DataTable loadThongTinKH(string shc)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select * from khachhang , quocgia where khachhang.maqg=quocgia.maqg and sohochieu=\"" + shc+"\"";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();

            }
            catch (Exception e)
            {

            }
            return k;
        }
        public DataTable loadDanhSachDV()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select * from dichvu";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();

            }
            catch (Exception e)
            {

            }
            return k;
        }
    }
}
