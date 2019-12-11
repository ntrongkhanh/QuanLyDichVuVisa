using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
   public class DanhSachKhachHangDTO
   {
        private string MaKH;
        private string HoTen;
        private string GioiTinh;
        private DateTime NgaySinh;
        private string SDT;
        private string Email;
        private string TenQG;
        private string SoHoChieu;
        private byte[] passport;
        private byte[] avatar;

        public DanhSachKhachHangDTO()
        {
        }

        public DanhSachKhachHangDTO(string maKH, string hoTen, string gioiTinh, DateTime ngaySinh, string sDT, string email, string maQG, string soHoChieu, byte[] passport, byte[] avatar)
        {
            MaKH = maKH;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            SDT = sDT;
            Email = email;
            TenQG = maQG;
            SoHoChieu = soHoChieu;
            this.passport = passport;
            this.avatar = avatar;
        }

        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string TenQG1 { get => TenQG; set => TenQG = value; }
        public string SoHoChieu1 { get => SoHoChieu; set => SoHoChieu = value; }
        public byte[] Passport { get => passport; set => passport = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }
    }
}
