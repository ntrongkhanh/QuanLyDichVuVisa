using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
    public class DangKyDichVuDTO
    {
        private string maDV;
        private string maLoaiViSa;
        private string maDCNC;
        private string maKH;
        private string noiCap;
        private DateTime ngayDK;
        private DateTime ngayNhapCanh;
        private DateTime ngayXuatCanh;
        private string maTGXL;
        private string noiNhan;
        private int chiPhi;
        private string maTrangThai;

        private List<string> madvbs;

        
        

        public DangKyDichVuDTO()
        {
        }

        public DangKyDichVuDTO(string maDV, string maLoaiViSa, string maDCNC, string maKH, string noiCap, DateTime ngayDK, DateTime ngayNhapCanh, DateTime ngayXuatCanh, string maTGXL, string noiNhan, int chiPhi, string maTrangThai, List<string> madvbs)
        {
            this.MaDV = maDV;
            this.MaLoaiViSa = maLoaiViSa;
            this.MaDCNC = maDCNC;
            this.MaKH = maKH;
            this.NoiCap = noiCap;
            this.NgayDK = ngayDK;
            this.NgayNhapCanh = ngayNhapCanh;
            this.NgayXuatCanh = ngayXuatCanh;
            this.MaTGXL = maTGXL;
            this.NoiNhan = noiNhan;
            this.ChiPhi = chiPhi;
            this.MaTrangThai = maTrangThai;
            this.Madvbs = madvbs;
        }

        public string MaDV { get => maDV; set => maDV = value; }
        public string MaLoaiViSa { get => maLoaiViSa; set => maLoaiViSa = value; }
        public string MaDCNC { get => maDCNC; set => maDCNC = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }
        public DateTime NgayDK { get => ngayDK; set => ngayDK = value; }
        public DateTime NgayNhapCanh { get => ngayNhapCanh; set => ngayNhapCanh = value; }
        public DateTime NgayXuatCanh { get => ngayXuatCanh; set => ngayXuatCanh = value; }
        public string MaTGXL { get => maTGXL; set => maTGXL = value; }
        public string NoiNhan { get => noiNhan; set => noiNhan = value; }
        public int ChiPhi { get => chiPhi; set => chiPhi = value; }
        public string MaTrangThai { get => maTrangThai; set => maTrangThai = value; }
        public List<string> Madvbs { get => madvbs; set => madvbs = value; }
    }
}
