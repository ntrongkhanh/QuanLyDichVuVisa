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
    class ThoiGianXuLyBUS
    {
        private ThoiGianXuLyDAL dcDAL;

        public ThoiGianXuLyBUS()
        {
            dcDAL = new ThoiGianXuLyDAL();
        }
        public bool them(ThoiGianXuLyDTO dc)
        {
            bool re = dcDAL.them(dc);
            return re;
        }
        public bool sua(ThoiGianXuLyDTO dc)
        {
            bool re = dcDAL.sua(dc);
            return re;
        }
        public List<ThoiGianXuLyDTO> select()
        {
            return dcDAL.select();
        }
        public DataTable loadToDataTable()
        {
            return dcDAL.loadToDataTable();
        }
    }
}
