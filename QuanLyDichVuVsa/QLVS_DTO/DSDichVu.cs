using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
    public class DSDichVu
    {
        string maDV;
        string maLoaiVisa;
        string maDCNC;
        string maKH;
        string noiCap;
        DateTime ngayDangKi;
        DateTime ngayNhapCanh;
        DateTime ngayXuatCanh;
        string maThoiGianXuly;
        string noiNhan;
        int chiPhiThanhToan;
        string maTrangThai;

        string loaiVisa;
        string dcnc;
        string hoTenKH;
        string thoiGianXuLy;
        string trangThai;

        public string MaDV { get => maDV; set => maDV = value; }
        public string MaLoaiVisa { get => maLoaiVisa; set => maLoaiVisa = value; }
        public string MaDCNC { get => maDCNC; set => maDCNC = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }
        public DateTime NgayDangKi { get => ngayDangKi; set => ngayDangKi = value; }
        public DateTime NgayNhapCanh { get => ngayNhapCanh; set => ngayNhapCanh = value; }
        public DateTime NgayXuatCanh { get => ngayXuatCanh; set => ngayXuatCanh = value; }
        public string MaThoiGianXuly { get => maThoiGianXuly; set => maThoiGianXuly = value; }
        public string NoiNhan { get => noiNhan; set => noiNhan = value; }
        public int ChiPhiThanhToan { get => chiPhiThanhToan; set => chiPhiThanhToan = value; }
        public string MaTrangThai { get => maTrangThai; set => maTrangThai = value; }
        public string LoaiVisa { get => loaiVisa; set => loaiVisa = value; }
        public string Dcnc { get => dcnc; set => dcnc = value; }
        public string HoTenKH { get => hoTenKH; set => hoTenKH = value; }
        public string ThoiGianXuLy { get => thoiGianXuLy; set => thoiGianXuLy = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
