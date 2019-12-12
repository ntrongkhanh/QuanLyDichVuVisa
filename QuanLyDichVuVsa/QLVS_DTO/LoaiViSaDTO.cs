using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
    public class LoaiViSaDTO
    {
        private string maLVS;
        private string ten;
        private int chiPhi;

        public LoaiViSaDTO()
        {
        }

        public LoaiViSaDTO(string maLVS, string ten, int chiPhi)
        {
            this.MaLVS = maLVS;
            this.Ten = ten;
            this.ChiPhi = chiPhi;
        }

        public string MaLVS { get => maLVS; set => maLVS = value; }
        public string Ten { get => ten; set => ten = value; }
        public int ChiPhi { get => chiPhi; set => chiPhi = value; }
    }
}
