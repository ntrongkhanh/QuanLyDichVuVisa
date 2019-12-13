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
        public DataTable loadLoaiViSa()
        {
            return dvdal.loadLoaiVISA();
        }
        public DataTable loadDanhSachDV()
        {
            return dvdal.loadDanhSachDV();
        }
        public DataTable loadThongTinKH(string shc)
        {
            return dvdal.loadThongTinKH(shc);
        }
        public DataTable loadTGXL()
        {
            return dvdal.loadTGXL();
        }
        public bool insert(DangKyDichVuDTO dt)
        {
            return dvdal.insert(dt);
        }
        public bool insertDanhSachDVBS(DangKyDichVuDTO dt)
        {
            return dvdal.insertDanhSachDVBS(dt);
        }
        
    }
}
