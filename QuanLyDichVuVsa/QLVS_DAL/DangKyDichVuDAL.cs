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


        public bool them(DangKyKhachHangDTO dt)
        {
            string query = string.Empty;
            query += "insert into khachhang VALUES (@makh,@hoten,@gioitinh,@ngaysinh,@sdt,@email,@maqg,@sohochieu,@passport,@avatar)";


            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@makh", dt.MaKH);
                    cmd.Parameters.AddWithValue("@hoten", dt.HoTen);
                    cmd.Parameters.AddWithValue("@gioitinh", dt.GioiTinh);
                    cmd.Parameters.AddWithValue("@ngaysinh", dt.NgaySinh);
                    cmd.Parameters.AddWithValue("@sdt", dt.SDT);
                    cmd.Parameters.AddWithValue("@email", dt.Email);
                    cmd.Parameters.AddWithValue("@maqg", dt.MaQG);
                    cmd.Parameters.AddWithValue("@sohochieu", dt.SoHoChieu);
                    MySqlParameter picpara = new MySqlParameter();
                    picpara.MySqlDbType = MySqlDbType.MediumBlob;
                    picpara.ParameterName = "passport";
                    picpara.Value = dt.Passport;
                    cmd.Parameters.Add(picpara);
                    MySqlParameter picpara1 = new MySqlParameter();
                    picpara1.MySqlDbType = MySqlDbType.MediumBlob;
                    picpara1.ParameterName = "avatar";
                    picpara1.Value = dt.Avatar;
                    cmd.Parameters.Add(picpara1);
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
    }
}
