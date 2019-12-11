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
                                kh.MaKH1 = reader["MaKH"].ToString();
                                kh.HoTen1 = reader["HoTen"].ToString();
                                kh.SoHoChieu1 = reader["SoHoChieu"].ToString();
                                kh.NgaySinh1 = (DateTime)reader["NGAYSINH"];
                                kh.SDT1 = reader["SDT"].ToString();
                                kh.Email1 = reader["TenQG"].ToString();
                                kh.GioiTinh1 = reader["GIOITINH"].ToString();
                                kh.TenQG1 = reader["TENQG"].ToString();

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
