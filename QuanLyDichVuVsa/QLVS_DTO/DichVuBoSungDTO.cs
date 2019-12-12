using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
    public class DichVuBoSungDTO
    {
        private string maDVBS;
        private string ten;
        private int chiPhi;
        public DichVuBoSungDTO() { }

        public DichVuBoSungDTO(string maDVBS, string ten, int chiPhi)
        {
            this.MaDVBS = maDVBS;
            this.Ten = ten;
            this.ChiPhi = chiPhi;
        }

        public string MaDVBS { get => maDVBS; set => maDVBS = value; }
        public string Ten { get => ten; set => ten = value; }
        public int ChiPhi { get => chiPhi; set => chiPhi = value; }
    }
}
