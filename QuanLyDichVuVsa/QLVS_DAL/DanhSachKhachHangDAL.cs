using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QLVS_DTO;
namespace QLVS_DAL
{
  public  class DanhSachKhachHangDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DanhSachKhachHangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public List<DanhSachKhachHangDTO> selectByKeyword(string strTuKhoa)
        {
            string query = string.Empty;

            //query += "select KH.MaKH,HOTEN,SOHOCHIEU,GIOITINH,NGAYSINH,SDT,EMAIL,TENQG ";
            //query += "from KHACHHANG KH ,QUOCGIA QG";
            //query += " WHERE KH.MaQG=QG.MaQG";
            //query += " AND (([SOHOCHIEU] LIKE CONCAT('%',@strTuKhoa,'%'))";
            //query += " OR (([HOTEN] LIKE CONCAT('%',@strTuKhoa,'%'))";
            //query += " OR (([GIOITINH] LIKE CONCAT('%',@strTuKhoa,'%'))";
            //query += " OR (([NGAYSINH] LIKE CONCAT('%',@strTuKhoa,'%'))";
            //query += " OR (([SDT] LIKE CONCAT('%',@strTuKhoa,'%'))";
            //query += " OR (([EMAIL] LIKE CONCAT('%',@strTuKhoa,'%'))";
            //query += " OR (([TENQG] LIKE CONCAT('%',@strTuKhoa,'%'))";

            query += "select KH.MaKH,HOTEN,SOHOCHIEU,GIOITINH,NGAYSINH,SDT,EMAIL,TENQG " +
                    " from KHACHHANG KH ,QUOCGIA QG" +
                    " WHERE KH.MaQG = QG.MaQG" +
                    " AND(" +
                    " (SOHOCHIEU LIKE CONCAT('%',@strTuKhoa,'%'))" +
                    " OR(HOTEN LIKE CONCAT('%',@strTuKhoa,'%'))" +
                    " OR(MAKH LIKE CONCAT('%',@strTuKhoa,'%'))" +
                    " OR(GIOITINH LIKE CONCAT('%',@strTuKhoa,'%'))" +
                    " OR(NGAYSINH LIKE CONCAT('%',@strTuKhoa,'%'))" +
                    " OR(SDT LIKE CONCAT('%',@strTuKhoa,'%'))" +
                    " OR(EMAIL LIKE CONCAT('%',@strTuKhoa,'%'))" +
                    " OR(TENQG LIKE CONCAT('%',@strTuKhoa,'%'))" +
                    ")";
            List<DanhSachKhachHangDTO> list = new List<DanhSachKhachHangDTO>();
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@strTuKhoa", strTuKhoa);
                    int x = 0;
                    try
                    {
                        con.Open();
                        MySqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DanhSachKhachHangDTO kh = new DanhSachKhachHangDTO();
                                kh.MaKH = reader["MaKH"].ToString();
                                kh.HoTen = reader["HoTen"].ToString();
                                kh.SoHoChieu = reader["SoHoChieu"].ToString();
                                kh.NgaySinh = (DateTime)reader["NGAYSINH"];
                                kh.SDT = reader["SDT"].ToString();
                                kh.Email = reader["Email"].ToString();
                                kh.GioiTinh = reader["GIOITINH"].ToString();
                                kh.TenQG = reader["TENQG"].ToString();

                                list.Add(kh);
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
        public List<DanhSachKhachHangDTO> select()
        {
            string query = string.Empty;

            query += "select KH.MaKH,HOTEN,SOHOCHIEU,GIOITINH,NGAYSINH,SDT,EMAIL,TENQG ";
            query += "from KHACHHANG KH ,QUOCGIA QG";
            query += " WHERE KH.MaQG=QG.MaQG";
            List<DanhSachKhachHangDTO> list = new List<DanhSachKhachHangDTO>();
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
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
                                DanhSachKhachHangDTO kh = new DanhSachKhachHangDTO();
                                kh.MaKH = reader["MaKH"].ToString();
                                kh.HoTen = reader["HoTen"].ToString();
                                kh.SoHoChieu = reader["SoHoChieu"].ToString();
                                kh.NgaySinh= (DateTime)reader["NGAYSINH"];
                                kh.SDT = reader["SDT"].ToString();
                                kh.Email = reader["Email"].ToString();
                                kh.GioiTinh = reader["GIOITINH"].ToString();
                                kh.TenQG = reader["TENQG"].ToString();

                                list.Add(kh);
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
    }
}
