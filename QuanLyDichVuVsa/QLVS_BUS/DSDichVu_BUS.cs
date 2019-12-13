using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVS_DAL;
using QLVS_DTO;

namespace QLVS_BUS
{
    public class DSDichVu_BUS
    {
        private DSDichVu_DAL dsDichVu_DAL;

        public DSDichVu_BUS()
        {
            dsDichVu_DAL = new DSDichVu_DAL();
        }

        public List<DSDichVu> Select()
        {
            return dsDichVu_DAL.Select();
        }

        public List<DSDichVu> SelectByKey(string key)
        {
            return dsDichVu_DAL.SelectByKey(key);
        }

        public List<DSDichVu> SelectByKeyword(string keyword)
        {
            return dsDichVu_DAL.SelectByKeyword(keyword);
        }
    }
}
