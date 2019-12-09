using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
    public class DichVuBoSungDTO
    {
        private string MaDVBS;
        private string Ten;
        private int ChiPhi;
        public DichVuBoSungDTO() { }
        public DichVuBoSungDTO(string maDVBS, string ten, int chiPhi)
        {
            MaDVBS = maDVBS;
            Ten = ten;
            ChiPhi = chiPhi;
        }

        public string MaDVBS1 { get => MaDVBS; set => MaDVBS = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public int ChiPhi1 { get => ChiPhi; set => ChiPhi = value; }
    }
}
