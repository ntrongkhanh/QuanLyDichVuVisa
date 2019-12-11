using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
    public class DangKyDichVuDTO
    {
        private string MaKH;
        private string HoTen;
        private string GioiTinh;
        private DateTime NgaySinh;
        private string SDT;
        private string Email;
        private string MaQG;
        private string SoHoChieu;
        private string MaLoaiViSa;
        private string LoaiViSa;
        private string MaDCNC;
        private string DiaChiNC;
        private string NoiCap;
        private DateTime NgayDK;
        private DateTime NgayNhapCanh;
        private DateTime NgayXuatCanh;
        private string MaTGXL;
        private string TGXL;
        private string NoiNhan;
        private int ChiPhi;
        private int TrangThai;

        public DangKyDichVuDTO()
        {
        }

        public DangKyDichVuDTO(string maKH, string hoTen, string gioiTinh, DateTime ngaySinh, string sDT, string email, string maQG, string soHoChieu, string maLoaiViSa, string loaiViSa, string maDCNC, string diaChiNC, string noiCap, DateTime ngayDK, DateTime ngayNhapCanh, DateTime ngayXuatCanh, string maTGXL, string tGXL, string noiNhan, int chiPhi, int trangThai)
        {
            MaKH1 = maKH;
            HoTen1 = hoTen;
            GioiTinh1 = gioiTinh;
            NgaySinh1 = ngaySinh;
            SDT1 = sDT;
            Email1 = email;
            MaQG1 = maQG;
            SoHoChieu1 = soHoChieu;
            MaLoaiViSa1 = maLoaiViSa;
            LoaiViSa1 = loaiViSa;
            MaDCNC1 = maDCNC;
            DiaChiNC1 = diaChiNC;
            NoiCap1 = noiCap;
            NgayDK1 = ngayDK;
            NgayNhapCanh1 = ngayNhapCanh;
            NgayXuatCanh1 = ngayXuatCanh;
            MaTGXL1 = maTGXL;
            TGXL1 = tGXL;
            NoiNhan1 = noiNhan;
            ChiPhi1 = chiPhi;
            TrangThai1 = trangThai;
        }

        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string MaQG1 { get => MaQG; set => MaQG = value; }
        public string SoHoChieu1 { get => SoHoChieu; set => SoHoChieu = value; }
        public string MaLoaiViSa1 { get => MaLoaiViSa; set => MaLoaiViSa = value; }
        public string LoaiViSa1 { get => LoaiViSa; set => LoaiViSa = value; }
        public string MaDCNC1 { get => MaDCNC; set => MaDCNC = value; }
        public string DiaChiNC1 { get => DiaChiNC; set => DiaChiNC = value; }
        public string NoiCap1 { get => NoiCap; set => NoiCap = value; }
        public DateTime NgayDK1 { get => NgayDK; set => NgayDK = value; }
        public DateTime NgayNhapCanh1 { get => NgayNhapCanh; set => NgayNhapCanh = value; }
        public DateTime NgayXuatCanh1 { get => NgayXuatCanh; set => NgayXuatCanh = value; }
        public string MaTGXL1 { get => MaTGXL; set => MaTGXL = value; }
        public string TGXL1 { get => TGXL; set => TGXL = value; }
        public string NoiNhan1 { get => NoiNhan; set => NoiNhan = value; }
        public int ChiPhi1 { get => ChiPhi; set => ChiPhi = value; }
        public int TrangThai1 { get => TrangThai; set => TrangThai = value; }
    }
}
