using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVS_DAL;
using QLVS_DTO;
using System.Data;

namespace QLVS_BUS
{
    public class DoanhThuBUS
    {
        private DoanhThuDAL doanhThuDAL;

        public DoanhThuBUS()
        {
            doanhThuDAL = new QLVS_DAL.DoanhThuDAL();
        }
        public List<DoanhThuDTO> Select(int month, int year)
        {
            return doanhThuDAL.Select(month, year);
        }
    }
}
