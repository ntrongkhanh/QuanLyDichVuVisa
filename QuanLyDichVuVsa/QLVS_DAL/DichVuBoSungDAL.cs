using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVS_DTO;
using System.Data;

namespace QLVS_DAL
{
  public  class DichVuBoSungDAL
    {
        private string connectionString;
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public DichVuBoSungDAL()
        {
            connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        }
        public bool them(DichVuBoSungDTO dv)
        {
            //INSERT INTO `quanlikh`.`dichvubosung` VALUES ('DVBS01', 'Private/ Confidential Letter', 8); 
            string query = string.Empty;
            query += "INSERT INTO `quanlikh`.`dichvubosung`  VALUES (@madv,@tendv,@chiphi)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@madv", dv.MaDVBS);
                    cmd.Parameters.AddWithValue("@tendv", dv.Ten);
                    cmd.Parameters.AddWithValue("@chiphi", dv.ChiPhi);
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

        public bool xoa(DichVuBoSungDTO dichVu)
        {
            string query = string.Empty;
            query += "DELETE FROM `quanlikh`.`dichvubosung` WHERE MaDVBS = @madv";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@madv", dichVu.MaDVBS);

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


        public bool sua(DichVuBoSungDTO dv)
        {
            string query = string.Empty;
            query += "UPDATE  `quanlikh`.`dichvubosung`  SET TenDVBS=@tendv , ChiPhi=@chiphi WHERE MaDVBS=@madv";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@madv", dv.MaDVBS);
                    cmd.Parameters.AddWithValue("@tendv", dv.Ten);
                    cmd.Parameters.AddWithValue("@chiphi", dv.ChiPhi);

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
        public List<DichVuBoSungDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM dichvubosung";

            List<DichVuBoSungDTO> list = new List<DichVuBoSungDTO>();
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
                                DichVuBoSungDTO dv = new DichVuBoSungDTO();
                                dv.MaDVBS = reader["MaDVBS"].ToString();
                               dv.Ten = reader["TenDVBS"].ToString();
                                dv.ChiPhi =int.Parse(reader["ChiPhi"].ToString());
                                list.Add(dv);
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
