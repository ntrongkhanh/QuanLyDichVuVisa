using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
    public class DiaChiNCDTO
    {
        private string MaDCNC;
        private string DiaChiNC;
        public DiaChiNCDTO() { }

        public DiaChiNCDTO(string maDCNC, string diaChiNC)
        {
            MaDCNC1 = maDCNC;
            DiaChiNC1 = diaChiNC;
        }

        public string MaDCNC1 { get => MaDCNC; set => MaDCNC = value; }
        public string DiaChiNC1 { get => DiaChiNC; set => DiaChiNC = value; }
    }
}
