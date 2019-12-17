using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using QLVS_DTO;
using MySql.Data.MySqlClient;

namespace QLVS_DAL
{
    public class DoanhThuDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DoanhThuDAL() { connectionString = ConfigurationManager.AppSettings["ConnectionString"]; }

        public List<DoanhThuDTO> Select(int month, int year)
        {
            string strQuery = string.Empty;

            strQuery += " 	 SELECT dichvu.MaDV , khachhang.HoTen, dichvu.ChiPhiThanhToan, dichvu.NgayDangKi FROM quanlikh.dichvu, quanlikh.khachhang WHERE year(dichvu.NgayDangKi) = @year and month(dichvu.NgayDangKi) = @month and dichvu.matrangthai = 'TT0004' ";
            List<DoanhThuDTO> listDT = new List<DoanhThuDTO>();

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.Add("@year", MySqlDbType.Int32).Value = year;
                    cmd.Parameters.Add("@month", MySqlDbType.Int32).Value = month;
                    
                    //cmd.Parameters.AddWithValue("@month", month);

                    try
                    {
                        con.Open();
                        MySqlDataReader reader = null;
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DoanhThuDTO doanhThu = new DoanhThuDTO();
                                doanhThu.MaDV = reader["MaDV"].ToString();
                                doanhThu.HoTenKH = reader["Hoten"].ToString();
                                doanhThu.NgayDangKi = (DateTime)reader["NgayDangKi"];
                                doanhThu.ChiPhiThanhToan = int.Parse(reader["ChiPhiThanhToan"].ToString());


                                listDT.Add(doanhThu);
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
            return listDT;
        }

    }
}
