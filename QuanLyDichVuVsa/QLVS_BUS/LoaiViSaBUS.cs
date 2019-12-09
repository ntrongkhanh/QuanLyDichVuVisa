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
    class LoaiViSaBUS
    {
        private LoaiViSaDAL dcDAL;

        public LoaiViSaBUS()
        {
            dcDAL = new LoaiViSaDAL();
        }
        public bool them(LoaiViSaDTO dc)
        {
            bool re = dcDAL.them(dc);
            return re;
        }
        public bool sua(LoaiViSaDTO dc)
        {
            bool re = dcDAL.sua(dc);
            return re;
        }
        public List<LoaiViSaDTO> select()
        {
            return dcDAL.select();
        }
        public DataTable loadToDataTable()
        {
            return dcDAL.loadToDataTable();
        }
    }
}
