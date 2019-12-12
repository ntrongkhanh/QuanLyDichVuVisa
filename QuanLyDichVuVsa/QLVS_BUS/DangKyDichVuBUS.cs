using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVS_DAL;
using QLVS_DTO;
namespace QLVS_BUS
{
   public class DangKyDichVuBUS
    {
        private DangKyDichVuDAL dvdal;

        public DangKyDichVuBUS()
        {
            dvdal = new DangKyDichVuDAL();
        }
        public DataTable loadNoiNhapCanh()
        {
            return dvdal.loadNoiNhapCanh();
        }
        public DataTable loadDVBS()
        {
            return dvdal.loadDVBS();
        }
    }
}
