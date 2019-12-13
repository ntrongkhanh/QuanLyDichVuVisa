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
  public  class LoaiViSaDAL
    {
        private string connectionString;
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public LoaiViSaDAL()
        {
            connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        }
        public bool them(LoaiViSaDTO vs)
        {
            //INSERT INTO `quanlikh`.`loaivisa` VALUES ('LVS001', 'Tourism - 1 month / single entry', 15);
            string query = string.Empty;
            query += "INSERT INTO `quanlikh`.`loaivisa`  VALUES (@mavs,@ten,@chiphi)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mavs", vs.MaLVS);
                    cmd.Parameters.AddWithValue("@ten", vs.Ten);
                    cmd.Parameters.AddWithValue("@chiphi", vs.ChiPhi);
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

        public bool xoa(LoaiViSaDTO lVS)
        {
            string query = string.Empty;
            query += "DELETE FROM `quanlikh`.`loaivisa` WHERE MaLoaiVISA = @mavs";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mavs", lVS.MaLVS);

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

        public bool sua(LoaiViSaDTO vs)
        {
            string query = string.Empty;
            query += "UPDATE  `quanlikh`.`loaivisa`  SET LoaiVISA=@ten , ChiPhi=@chiphi WHERE MaLoaiVISA=@mavs";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mavs", vs.MaLVS);
                    cmd.Parameters.AddWithValue("@ten", vs.Ten);
                    cmd.Parameters.AddWithValue("@chiphi", vs.ChiPhi);

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
        public List<LoaiViSaDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM loaivisa";

            List<LoaiViSaDTO> list = new List<LoaiViSaDTO>();
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
                                LoaiViSaDTO vs = new LoaiViSaDTO();
                               vs.MaLVS = reader["MaLoaiVISA"].ToString();
                                vs.Ten = reader["LoaiVISA"].ToString();
                                vs.ChiPhi= int.Parse(reader["ChiPhi"].ToString());
                                list.Add(vs);
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
                string sql = "select * from loaivisa";
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
