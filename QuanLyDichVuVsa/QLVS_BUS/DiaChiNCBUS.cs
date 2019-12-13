using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVS_DTO;
using QLVS_DAL;
using System.Data;

namespace QLVS_BUS
{
    public class DiaChiNCBUS
    {
        private DiaChiNCDAL dcDAL;

        public DiaChiNCBUS()
        {
            dcDAL = new DiaChiNCDAL();
        }
        public bool them(DiaChiNCDTO dc)
        {
            bool re = dcDAL.them(dc);
            return re;
        }
        public bool sua(DiaChiNCDTO dc)
        {
            bool re = dcDAL.sua(dc);
            return re;
        }
        public bool xoa(DiaChiNCDTO dc)
        {
            bool re = dcDAL.xoa(dc);
            return re;
        }
        public List<DiaChiNCDTO> select()
        {
            return dcDAL.select();
        }
        public DataTable loadToDataTable()
        {
            return dcDAL.loadToDataTable();
        }
    }
}
