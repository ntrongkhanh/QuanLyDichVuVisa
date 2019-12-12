using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
    public class DiaChiNCDTO
    {
        private string maDCNC;
        private string diaChiNC;
        public DiaChiNCDTO() { }

        public DiaChiNCDTO(string maDCNC, string diaChiNC)
        {
            this.MaDCNC = maDCNC;
            this.DiaChiNC = diaChiNC;
        }

        public string MaDCNC { get => maDCNC; set => maDCNC = value; }
        public string DiaChiNC { get => diaChiNC; set => diaChiNC = value; }
    }
}
