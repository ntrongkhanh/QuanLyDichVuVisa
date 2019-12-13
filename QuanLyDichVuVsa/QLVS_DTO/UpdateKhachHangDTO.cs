using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
   public class UpdateKhachHangDTO
    {
        private string maKH;
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string sDT;
        private string email;
        private string maQG;
        private string soHoChieu;
        private byte[] passport;
        private byte[] avatar;
        private string tenQG;

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Email { get => email; set => email = value; }
        public string MaQG { get => maQG; set => maQG = value; }
        public string SoHoChieu { get => soHoChieu; set => soHoChieu = value; }
        public byte[] Passport { get => passport; set => passport = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }
        public string TenQG { get => tenQG; set => tenQG = value; }

        public UpdateKhachHangDTO(string maKH, string hoTen, string gioiTinh, DateTime ngaySinh, string sDT, string email, string maQG, string soHoChieu, byte[] passport, byte[] avatar, string tenQG)
        {
            this.MaKH = maKH;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.SDT = sDT;
            this.Email = email;
            this.MaQG = maQG;
            this.SoHoChieu = soHoChieu;
            this.Passport = passport;
            this.Avatar = avatar;
            this.TenQG = tenQG;
        }

        public UpdateKhachHangDTO()
        {
        }
    }
}
