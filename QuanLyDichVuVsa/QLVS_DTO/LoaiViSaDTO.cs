using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
    public class LoaiViSaDTO
    {
        private string MaLVS;
        private string Ten;
        private int chiPhi;

        public LoaiViSaDTO()
        {
        }

        public LoaiViSaDTO(string maLVS, string ten, int chiPhi)
        {
            MaLVS = maLVS;
            Ten = ten;
            this.chiPhi = chiPhi;
        }

        public string MaLVS1 { get => MaLVS; set => MaLVS = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public int ChiPhi { get => chiPhi; set => chiPhi = value; }
    }
}
