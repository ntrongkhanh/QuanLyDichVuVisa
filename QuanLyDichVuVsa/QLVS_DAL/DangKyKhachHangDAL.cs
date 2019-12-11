﻿using System;
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
   public class DangKyKhachHangDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public DangKyKhachHangDAL()
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

                    cmd.Parameters.AddWithValue("@makh", dt.MaKH1);
                    cmd.Parameters.AddWithValue("@hoten", dt.HoTen1);
                    cmd.Parameters.AddWithValue("@gioitinh", dt.GioiTinh1);
                    cmd.Parameters.AddWithValue("@ngaysinh", dt.NgaySinh1);
                    cmd.Parameters.AddWithValue("@sdt", dt.SDT1);
                    cmd.Parameters.AddWithValue("@email", dt.Email1);
                    cmd.Parameters.AddWithValue("@maqg", dt.MaQG1);
                    cmd.Parameters.AddWithValue("@sohochieu", dt.SoHoChieu1);
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
        public DataTable loadDuLieuKH()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select * from khachhang";
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