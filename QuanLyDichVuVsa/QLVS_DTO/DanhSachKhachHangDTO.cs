using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
   public class DanhSachKhachHangDTO
   {
        private string maKH;
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string sDT;
        private string email;
        private string tenQG;
        private string soHoChieu;
        private byte[] passport;
        private byte[] avatar;

        public DanhSachKhachHangDTO()
        {
        }

        public DanhSachKhachHangDTO(string maKH, string hoTen, string gioiTinh, DateTime ngaySinh, string sDT, string email, string tenQG, string soHoChieu, byte[] passport, byte[] avatar)
        {
            this.MaKH = maKH;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.SDT = sDT;
            this.Email = email;
            this.TenQG = tenQG;
            this.SoHoChieu = soHoChieu;
            this.Passport = passport;
            this.Avatar = avatar;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Email { get => email; set => email = value; }
        public string TenQG { get => tenQG; set => tenQG = value; }
        public string SoHoChieu { get => soHoChieu; set => soHoChieu = value; }
        public byte[] Passport { get => passport; set => passport = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }
    }
}
