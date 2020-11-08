using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang.DTO_QLNN
{
    public class DTO_DieuChinhHopDong
    {
        private int _DCHP_maDieuChinhHopDong;
        private int _DCHP_maHopDong;
        private int _DCHP_maDieuKhoan;


        public int DCHP_maDieuChinhHopDong
        {
            get => _DCHP_maDieuChinhHopDong;
            set => _DCHP_maDieuChinhHopDong = value;
        }
        public int DCHP_maHopDong
        {
            get => _DCHP_maHopDong;
            set => _DCHP_maHopDong = value;
        }
        public int DCHP_maDieuKhoan
        {
            get => _DCHP_maDieuKhoan;
            set => _DCHP_maDieuKhoan = value;
        }

        public DTO_DieuChinhHopDong(int madchp, int mahd, int madk)
        {
            this.DCHP_maDieuChinhHopDong = madchp;
            this.DCHP_maHopDong = mahd;
            this.DCHP_maDieuKhoan = madk;

        }

    }

}

