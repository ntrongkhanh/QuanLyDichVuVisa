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
  public  class DangKyKhachHangBUS
    {
        private DangKyKhachHangDAL khdal;
        public DangKyKhachHangBUS()
        {
            khdal = new DangKyKhachHangDAL();
        }
        public DataTable loadQGtoCombobox()
        {
            return khdal.loadQGtoCombobox();
        }
        public bool them(DangKyKhachHangDTO khdto)
        {
          bool re=  khdal.them(khdto);
            return re;
        }
        public DataTable loadDuLieuKH()
        {
           return khdal.loadDuLieuKH();

        }
    }
}
