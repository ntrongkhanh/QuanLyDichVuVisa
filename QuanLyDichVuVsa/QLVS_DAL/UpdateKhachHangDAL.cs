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
   public class UpdateKhachHangDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public UpdateKhachHangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public DataTable loadQGtoCombobox()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "SELECT * FROM quocgia";
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


        public bool update(UpdateKhachHangDTO dt)
        {
            string query = string.Empty;
            query += " UPDATE `quanlikh`.`khachhang`  SET `HoTen` = @hoten,`GioiTinh` = @gioitinh,`NgaySinh` =@ngaysinh,`SDT` =@sdt,`Email` =@email,`MaQG` =@maqg,`SoHoChieu` = @sohochieu,`HinhPassport` =@passport ,`HinhDaiDien`=@avatar WHERE `MaKH` = @makh";


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

        public bool delete(UpdateKhachHangDTO dt)
        {
            string query = string.Empty;
            query += "delete from `quanlikh`.`khachhang` where MAKH=@makh";


            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@makh", dt.MaKH);
                    
                   
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
        public List<UpdateKhachHangDTO> select(string strMa)
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

            query += "select KH.MaKH,HOTEN,SOHOCHIEU,GIOITINH,NGAYSINH,SDT,EMAIL,TENQG,HinhPassport,HinhDaiDien ";
            query += " from KHACHHANG KH ,QUOCGIA QG";
            query += " WHERE KH.MaQG=QG.MaQG";
            query += " and KH.MAKH=@strMa";
            List<UpdateKhachHangDTO> list = new List<UpdateKhachHangDTO>();
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@strMa", strMa);
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
                                UpdateKhachHangDTO kh = new UpdateKhachHangDTO();
                                kh.MaKH = reader["MaKH"].ToString();
                                kh.HoTen = reader["HoTen"].ToString();
                                kh.GioiTinh = reader["GIOITINH"].ToString();
                                kh.NgaySinh = (DateTime)reader["NGAYSINH"];
                                kh.SDT = reader["SDT"].ToString();
                                kh.Email = reader["Email"].ToString();
                                kh.TenQG = reader["TENQG"].ToString();
                                kh.SoHoChieu = reader["SoHoChieu"].ToString();
                                kh.Passport = (byte[])reader["HinhPassport"];
                                kh.Avatar = (byte[])reader["HinhDaiDien"];





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
        public DataTable loadDuLieuKH(string str)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string query = string.Empty;
                query += "select KH.MaKH,HOTEN,GIOITINH,NGAYSINH,SDT,EMAIL,TENQG,SOHOCHIEU,HinhPassport,HinhDaiDien ";
                query += " from KHACHHANG KH ,QUOCGIA QG";
                query += " WHERE KH.MaQG=QG.MaQG";
                query += " and KH.MAKH=\""+str+"\"";

                MySqlDataAdapter dt = new MySqlDataAdapter(query, kn);
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
