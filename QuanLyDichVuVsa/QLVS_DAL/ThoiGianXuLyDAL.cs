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
   public class ThoiGianXuLyDAL
    {
        private string connectionString;
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public ThoiGianXuLyDAL()
        {
            connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        }
        public bool them(ThoiGianXuLyDTO tg)
        {
            //INSERT INTO `quanlikh`.`loaivisa` VALUES ('LVS001', 'Tourism - 1 month / single entry', 15);
            string query = string.Empty;
            query += "INSERT INTO `quanlikh`.`thoigianxuly`  VALUES (@ma,@ten,@songay,@chiphi)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ma", tg.MaTG);
                    cmd.Parameters.AddWithValue("@ten", tg.ThoiGian);
                    cmd.Parameters.AddWithValue("@songay", tg.SoNgay);
                    cmd.Parameters.AddWithValue("@chiphi", tg.ChiPhi);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        string s = ex.Message;
                        con.Close();
                    }
                }
            }
            return false;
        }
        public bool sua(ThoiGianXuLyDTO tg)
        {
            string query = string.Empty;
            query += "UPDATE  `quanlikh`.`thoigianxuly`  SET TGXuLy=@thoigian,SoNgay=@songay , ChiPhi=@chiphi WHERE MaThoiGianXuLy=@ma";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ma", tg.MaTG);
                    cmd.Parameters.AddWithValue("@thoigian", tg.ThoiGian);
                    cmd.Parameters.AddWithValue("@songay", tg.SoNgay);
                    cmd.Parameters.AddWithValue("@chiphi", tg.ChiPhi);

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
        public List<ThoiGianXuLyDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM thoigianxuly";

            List<ThoiGianXuLyDTO> list = new List<ThoiGianXuLyDTO>();
            string ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"];
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        MySqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                ThoiGianXuLyDTO tg = new ThoiGianXuLyDTO();
                                tg.MaTG = reader["MaThoiGianXuLy"].ToString();
                                tg.ThoiGian = reader["TGXuLy"].ToString();
                                tg.SoNgay = int.Parse(reader["SoNgay"].ToString());
                                tg.ChiPhi = int.Parse(reader["ChiPhi"].ToString());
                                list.Add(tg);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }

                }
            }
            return list;
        }
        public DataTable loadToDataTable()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select * from thoigianxuly";
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
