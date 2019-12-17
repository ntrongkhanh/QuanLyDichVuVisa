using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_DTO
{
    public class DoanhThuDTO
    {
        private String maDT;
        private DateTime ngayDangKi;
        private String maDV;
        private String maKH;
        private int tong;

        String tenDichVu;
        String hoTenKH;
        int chiPhiThanhToan;


        public string MaDT { get => maDT; set => maDT = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public int Tong { get => tong; set => tong = value; }
        public DateTime NgayDangKi { get => ngayDangKi; set => ngayDangKi = value; }
        public string MaDV { get => maDV; set => maDV = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public string HoTenKH { get => hoTenKH; set => hoTenKH = value; }
        public int ChiPhiThanhToan { get => chiPhiThanhToan; set => chiPhiThanhToan = value; }


    }

}
