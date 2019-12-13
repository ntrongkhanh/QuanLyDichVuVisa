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
  public  class DichVuBoSungBUS
    {
        private DichVuBoSungDAL dvDAL;

        public DichVuBoSungBUS()
        {
            dvDAL = new DichVuBoSungDAL();
        }
        public bool them(DichVuBoSungDTO dv)
        {
            bool re = dvDAL.them(dv);
            return re;
        }
        public bool xoa(DichVuBoSungDTO dv)
        {
            bool re = dvDAL.xoa(dv);
            return re;
        }
        public bool sua(DichVuBoSungDTO dv)
        {
            bool re = dvDAL.sua(dv);
            return re;
        }
        public List<DichVuBoSungDTO> select()
        {
            return dvDAL.select();
        }
        public DataTable loadToDataTable()
        {
            return dvDAL.loadToDataTable();
        }
    }
}
