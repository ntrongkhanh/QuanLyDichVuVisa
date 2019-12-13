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
   public class UpdateKhachHangBUS
    {
        private UpdateKhachHangDAL khdal;

        public UpdateKhachHangBUS()
        {
            khdal = new UpdateKhachHangDAL();
        }
        public DataTable loadQG()
        {
            return khdal.loadQGtoCombobox();
        }
        public List<UpdateKhachHangDTO> select(string strMa)
        {
            return khdal.select(strMa);
        }
        public DataTable loadDL(string strMa)
        {
            return khdal.loadDuLieuKH(strMa);

        }
        public bool update(UpdateKhachHangDTO khdto)
        {
            bool re = khdal.update(khdto);
            return re;
        }
        public bool delete(UpdateKhachHangDTO khdto)
        {
            bool re = khdal.delete(khdto);
            return re;
        }
    }
}
