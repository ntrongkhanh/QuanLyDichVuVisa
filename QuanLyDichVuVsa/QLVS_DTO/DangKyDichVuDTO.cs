using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
    public class DangKyDichVuDTO
    {
        private string maKH;
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string sSDT;
        private string email;
        private string maQG;
        private string soHoChieu;
        private string maLoaiViSa;
        private string loaiViSa;
        private string maDCNC;
        private string diaChiNC;
        private string noiCap;
        private DateTime ngayDK;
        private DateTime ngayNhapCanh;
        private DateTime ngayXuatCanh;
        private string maTGXL;
        private string tGXL;
        private string noiNhan;
        private int chiPhi;
        private int trangThai;

        public DangKyDichVuDTO()
        {
        }

        public DangKyDichVuDTO(string maKH, string hoTen, string gioiTinh, DateTime ngaySinh, string sSDT, string email, string maQG, string soHoChieu, string maLoaiViSa, string loaiViSa, string maDCNC, string diaChiNC, string noiCap, DateTime ngayDK, DateTime ngayNhapCanh, DateTime ngayXuatCanh, string maTGXL, string tGXL, string noiNhan, int chiPhi, int trangThai)
        {
            this.MaKH = maKH;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.SSDT = sSDT;
            this.Email = email;
            this.MaQG = maQG;
            this.SoHoChieu = soHoChieu;
            this.MaLoaiViSa = maLoaiViSa;
            this.LoaiViSa = loaiViSa;
            this.MaDCNC = maDCNC;
            this.DiaChiNC = diaChiNC;
            this.NoiCap = noiCap;
            this.NgayDK = ngayDK;
            this.NgayNhapCanh = ngayNhapCanh;
            this.NgayXuatCanh = ngayXuatCanh;
            this.MaTGXL = maTGXL;
            this.TGXL = tGXL;
            this.NoiNhan = noiNhan;
            this.ChiPhi = chiPhi;
            this.TrangThai = trangThai;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SSDT { get => sSDT; set => sSDT = value; }
        public string Email { get => email; set => email = value; }
        public string MaQG { get => maQG; set => maQG = value; }
        public string SoHoChieu { get => soHoChieu; set => soHoChieu = value; }
        public string MaLoaiViSa { get => maLoaiViSa; set => maLoaiViSa = value; }
        public string LoaiViSa { get => loaiViSa; set => loaiViSa = value; }
        public string MaDCNC { get => maDCNC; set => maDCNC = value; }
        public string DiaChiNC { get => diaChiNC; set => diaChiNC = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }
        public DateTime NgayDK { get => ngayDK; set => ngayDK = value; }
        public DateTime NgayNhapCanh { get => ngayNhapCanh; set => ngayNhapCanh = value; }
        public DateTime NgayXuatCanh { get => ngayXuatCanh; set => ngayXuatCanh = value; }
        public string MaTGXL { get => maTGXL; set => maTGXL = value; }
        public string TGXL { get => tGXL; set => tGXL = value; }
        public string NoiNhan { get => noiNhan; set => noiNhan = value; }
        public int ChiPhi { get => chiPhi; set => chiPhi = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
