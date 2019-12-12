using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
     public  class ThoiGianXuLyDTO
    {
        private string maTG;
        private string thoiGian;
        private int soNgay;
        private int chiPhi;

        public ThoiGianXuLyDTO()
        {
        }

        public ThoiGianXuLyDTO(string maTG, string thoiGian, int soNgay, int chiPhi)
        {
            MaTG = maTG;
            this.ThoiGian = thoiGian;
            this.SoNgay = soNgay;
            this.ChiPhi = chiPhi;
        }

        public string MaTG { get => maTG; set => maTG = value; }
        public string ThoiGian { get => thoiGian; set => thoiGian = value; }
        public int SoNgay { get => soNgay; set => soNgay = value; }
        public int ChiPhi { get => chiPhi; set => chiPhi = value; }
    }
}
