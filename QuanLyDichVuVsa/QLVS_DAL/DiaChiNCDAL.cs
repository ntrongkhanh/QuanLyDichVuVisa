using QLVS_DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace QLVS_DAL
{
    public class DiaChiNCDAL
    {
        private string connectionString;
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public DiaChiNCDAL()
        {
            connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        }
        public bool them(DiaChiNCDTO dc)
        {
            //INSERT INTO `quanlikh`.`dcnhapcanh` VALUES('DC0001', 'Tan Son Nhat airport (SGN) – Hochiminh city');
            string query = string.Empty;
            query += "INSERT INTO `quanlikh`.`dcnhapcanh`  VALUES (@madc,@dcnc)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@madc", dc.MaDCNC);
                    cmd.Parameters.AddWithValue("@dcnc", dc.DiaChiNC);
                    
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
        public bool sua(DiaChiNCDTO dc)
        {
            string query = string.Empty;
            query += "UPDATE  `quanlikh`.`dcnhapcanh`  SET NoiNhapCanh=@noinc WHERE MaDCNC=@madc";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@madc", dc.MaDCNC);
                    cmd.Parameters.AddWithValue("@noinc", dc.DiaChiNC);
                    
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
        public List<DiaChiNCDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * FROM `quanlikh`.`dcnhapcanh`";
            

            List<DiaChiNCDTO> list = new List<DiaChiNCDTO>();
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
                                DiaChiNCDTO dc = new DiaChiNCDTO();
                                dc.MaDCNC = reader["MaDCNC"].ToString();
                                dc.DiaChiNC = reader["NoiNhapCanh"].ToString();
                                list.Add(dc);
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
                string sql = "select * from `quanlikh`.`dcnhapcanh`";
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
