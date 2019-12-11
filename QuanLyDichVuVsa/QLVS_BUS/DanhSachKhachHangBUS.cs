using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVS_DAL;
using QLVS_DTO;
namespace QLVS_BUS
{
   public class DanhSachKhachHangBUS
    {
        private DanhSachKhachHangDAL khdal;

        public DanhSachKhachHangBUS()
        {
            khdal = new DanhSachKhachHangDAL();
        }
        public List<DanhSachKhachHangDTO> select()
        {
            return khdal.select();
        }
    }
}
