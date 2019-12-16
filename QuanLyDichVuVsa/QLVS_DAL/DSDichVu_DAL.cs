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
    public class DSDichVu_DAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DSDichVu_DAL() { connectionString = ConfigurationManager.AppSettings["ConnectionString"]; }



        public List<DSDichVu> Select()
        {
            string strQuery = string.Empty;
            strQuery += "SELECT `dichvu`.`MaDV`,`loaivisa`.`LoaiVISA`, `dcnhapcanh`.`NoiNhapCanh` , `khachhang`.`HoTen`, `dichvu`.`NoiCap`, ";
            strQuery += "`dichvu`.`NgayDangKi`, `dichvu`.`NgayNhapCanh`, `dichvu`.`NgayXuatCanh`, `thoigianxuly`.`TGXuLy`, `dichvu`.`NoiNhan`,";
            strQuery += "`dichvu`.`ChiPhiThanhToan`, `trangthai`.`trangThai`, `trangthai`.`maTrangThai`";

            strQuery += "FROM `quanlikh`.`dichvu`, `quanlikh`.`trangThai`, `quanlikh`.`dcnhapcanh`, `quanlikh`.`loaivisa`, `quanlikh`.`khachhang`,";
            strQuery += "`quanlikh`.`thoigianxuly`";
            strQuery += "WHERE `dichvu`.`MaLoaiVISA` = `loaivisa`.`MaLoaiVISA` AND `dichvu`.`MaDCNC` = `dcnhapcanh`.`MaDCNC` AND `dichvu`.`MaKH` = `khachhang`.`MaKH` AND";
            strQuery += "`dichvu`.`MaThoiGianXuLy` = `thoigianxuly`.`MaThoiGianXuLy` AND `dichvu`.`maTrangThai` = `trangthai`.`maTrangThai`";

            List<DSDichVu> listDV = new List<DSDichVu>();

            using(MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using(MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;

                    try
                    {
                        con.Open();
                        MySqlDataReader reader = null;
                        reader = cmd.ExecuteReader();

                        if(reader.HasRows == true)
                        {
                            while(reader.Read())
                            {
                                DSDichVu dichVu = new DSDichVu();
                                dichVu.MaDV = reader["maDV"].ToString();
                                dichVu.LoaiVisa = reader["LoaiVisa"].ToString();
                                dichVu.Dcnc = reader["NoiNhapCanh"].ToString();
                                dichVu.HoTenKH = reader["HoTen"].ToString();
                                dichVu.NoiCap = reader["NoiCap"].ToString();
                                dichVu.NgayDangKi = (DateTime)reader["NgayDangKi"];
                                dichVu.NgayNhapCanh = (DateTime)reader["NgayNhapCanh"];
                                dichVu.NgayXuatCanh = (DateTime)reader["NgayXuatCanh"];
                                dichVu.ThoiGianXuLy = reader["TGXuLy"].ToString();
                                dichVu.NoiNhan = reader["NoiNhan"].ToString();
                                dichVu.ChiPhiThanhToan = int.Parse(reader["ChiPhiThanhToan"].ToString());
                                dichVu.TrangThai = reader["trangThai"].ToString();
                                dichVu.MaTrangThai = reader["maTrangThai"].ToString();

                                listDV.Add(dichVu);
                            }
                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch(Exception ex)
                    {
                        con.Close();
                        return null;
                    }

                }
            }
            return listDV;
        }

        public List<DSDichVu> SelectByKey(string key)
        {
            string strQuery = string.Empty;
            strQuery += "SELECT `dichvu`.`MaDV`,`loaivisa`.`LoaiVISA`, `dcnhapcanh`.`NoiNhapCanh` , `khachhang`.`HoTen`, `dichvu`.`NoiCap`, ";
            strQuery += "`dichvu`.`NgayDangKi`, `dichvu`.`NgayNhapCanh`, `dichvu`.`NgayXuatCanh`, `thoigianxuly`.`TGXuLy`, `dichvu`.`NoiNhan`,";
            strQuery += "`dichvu`.`ChiPhiThanhToan`, `trangthai`.`trangThai`, `trangthai`.`maTrangThai`";
            
            strQuery += "FROM `quanlikh`.`dichvu`, `quanlikh`.`trangThai`, `quanlikh`.`dcnhapcanh`, `quanlikh`.`loaivisa`, `quanlikh`.`khachhang`,";
            strQuery += "`quanlikh`.`thoigianxuly`";

            strQuery += "WHERE `dichvu`.`MaLoaiVISA` = `loaivisa`.`MaLoaiVISA` AND `dichvu`.`MaDCNC` = `dcnhapcanh`.`MaDCNC` AND `dichvu`.`MaKH` = `khachhang`.`MaKH` AND";
            strQuery += "`dichvu`.`MaThoiGianXuLy` = `thoigianxuly`.`MaThoiGianXuLy` AND `dichvu`.`maTrangThai` = `trangthai`.`maTrangThai` AND `trangthai`.`maTrangThai` = @strKey";



            List<DSDichVu> listDV = new List<DSDichVu>();

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@strKey", key);

                    try
                    {
                        con.Open();
                        MySqlDataReader reader = null;
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DSDichVu dichVu = new DSDichVu();
                                dichVu.MaDV = reader["maDV"].ToString();
                                dichVu.LoaiVisa = reader["LoaiVisa"].ToString();
                                dichVu.Dcnc = reader["NoiNhapCanh"].ToString();
                                dichVu.HoTenKH = reader["HoTen"].ToString();
                                dichVu.NoiCap = reader["NoiCap"].ToString();
                                dichVu.NgayDangKi = (DateTime)reader["NgayDangKi"];
                                dichVu.NgayNhapCanh = (DateTime)reader["NgayNhapCanh"];
                                dichVu.NgayXuatCanh = (DateTime)reader["NgayXuatCanh"];
                                dichVu.ThoiGianXuLy = reader["TGXuLy"].ToString();
                                dichVu.NoiNhan = reader["NoiNhan"].ToString();
                                dichVu.ChiPhiThanhToan = int.Parse(reader["ChiPhiThanhToan"].ToString());
                                dichVu.TrangThai = reader["trangThai"].ToString();
                                dichVu.MaTrangThai = reader["maTrangThai"].ToString();

                                listDV.Add(dichVu);
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
            return listDV;
        }

        public List<DSDichVu> SelectByKeyword(string keyword)
        {
            string strQuery = string.Empty;
            strQuery += "SELECT `dichvu`.`MaDV`,`loaivisa`.`LoaiVISA`, `dcnhapcanh`.`NoiNhapCanh` , `khachhang`.`HoTen`, `dichvu`.`NoiCap`, ";
            strQuery += "`dichvu`.`NgayDangKi`, `dichvu`.`NgayNhapCanh`, `dichvu`.`NgayXuatCanh`, `thoigianxuly`.`TGXuLy`, `dichvu`.`NoiNhan`,";
            strQuery += "`dichvu`.`ChiPhiThanhToan`, `trangthai`.`trangThai`, `trangthai`.`maTrangThai`";

            strQuery += "FROM `quanlikh`.`dichvu`, `quanlikh`.`trangThai`, `quanlikh`.`dcnhapcanh`, `quanlikh`.`loaivisa`, `quanlikh`.`khachhang`,";
            strQuery += "`quanlikh`.`thoigianxuly`";

            strQuery += "WHERE `dichvu`.`MaLoaiVISA` = `loaivisa`.`MaLoaiVISA` AND `dichvu`.`MaDCNC` = `dcnhapcanh`.`MaDCNC` AND `dichvu`.`MaKH` = `khachhang`.`MaKH` AND";
            strQuery += "`dichvu`.`MaThoiGianXuLy` = `thoigianxuly`.`MaThoiGianXuLy` AND `dichvu`.`maTrangThai` = `trangthai`.`maTrangThai`";
            strQuery += "AND( `dichvu`.`MaDV` LIKE CONCAT('%', @strKey, '%')  OR  `loaivisa`.`LoaiVISA` LIKE CONCAT('%', @strKey, '%') OR  `khachhang`.`HoTen` LIKE CONCAT('%',@strKey,'%'))";



            List<DSDichVu> listDV = new List<DSDichVu>();

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@strKey", keyword);

                    try
                    {
                        con.Open();
                        MySqlDataReader reader = null;
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DSDichVu dichVu = new DSDichVu();
                                dichVu.MaDV = reader["maDV"].ToString();
                                dichVu.LoaiVisa = reader["LoaiVisa"].ToString();
                                dichVu.Dcnc = reader["NoiNhapCanh"].ToString();
                                dichVu.HoTenKH = reader["HoTen"].ToString();
                                dichVu.NoiCap = reader["NoiCap"].ToString();
                                dichVu.NgayDangKi = (DateTime)reader["NgayDangKi"];
                                dichVu.NgayNhapCanh = (DateTime)reader["NgayNhapCanh"];
                                dichVu.NgayXuatCanh = (DateTime)reader["NgayXuatCanh"];
                                dichVu.ThoiGianXuLy = reader["TGXuLy"].ToString();
                                dichVu.NoiNhan = reader["NoiNhan"].ToString();
                                dichVu.ChiPhiThanhToan = int.Parse(reader["ChiPhiThanhToan"].ToString());
                                dichVu.TrangThai = reader["trangThai"].ToString();
                                dichVu.MaTrangThai = reader["maTrangThai"].ToString();

                                listDV.Add(dichVu);
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
            return listDV;
        }

        public bool suaTT(DSDichVu dv) // sua trang thai
        {
            string query = string.Empty;
            query += "UPDATE  `quanlikh`.`dichvu`" + "SET MaTrangThai = @MaTrangThai WHERE MaDV=@maDV";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaDV", dv.MaDV);
                    cmd.Parameters.AddWithValue("@MaTrangThai", dv.MaTrangThai);
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

    }
}
