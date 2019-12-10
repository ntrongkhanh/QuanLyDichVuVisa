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
        private DichVuBoSungDAL dcDAL;

        public DichVuBoSungBUS()
        {
            dcDAL = new DichVuBoSungDAL();
        }
        public bool them(DichVuBoSungDTO dc)
        {
            bool re = dcDAL.them(dc);
            return re;
        }
        public bool sua(DichVuBoSungDTO dc)
        {
            bool re = dcDAL.sua(dc);
            return re;
        }
        public List<DichVuBoSungDTO> select()
        {
            return dcDAL.select();
        }
        public DataTable loadToDataTable()
        {
            return dcDAL.loadToDataTable();
        }
    }
}
