using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
    public class DangKyKhachHangDTO
    {
        private string MaKH;
        private string HoTen;
        private string GioiTinh;
        private DateTime NgaySinh;
        private string SDT;
        private string Email;
        private string MaQG;
        private string SoHoChieu;
        private byte[] passport;
        private byte[] avatar;
        public DangKyKhachHangDTO()
        {

        }

        public DangKyKhachHangDTO(string maKH, string hoTen, string gioiTinh, DateTime ngaySinh, string sDT, string email, string maQG, string soHoChieu, string maKH1, string hoTen1, string gioiTinh1, DateTime ngaySinh1, string sDT1, string email1, string maQG1, string soHoChieu1,byte[] pass,byte[] avatar)
        {
            MaKH = maKH;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            SDT = sDT;
            Email = email;
            MaQG = maQG;
            SoHoChieu = soHoChieu;
            MaKH1 = maKH1;
            HoTen1 = hoTen1;
            GioiTinh1 = gioiTinh1;
            NgaySinh1 = ngaySinh1;
            SDT1 = sDT1;
            Email1 = email1;
            MaQG1 = maQG1;
            SoHoChieu1 = soHoChieu1;
            Passport = pass;
            Avatar = avatar;

        }

        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string MaQG1 { get => MaQG; set => MaQG = value; }
        public string SoHoChieu1 { get => SoHoChieu; set => SoHoChieu = value; }
        public byte[] Passport { get => passport; set => passport = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }
    }
}
