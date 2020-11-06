using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang.DTO_QLNN
{
    public class DTO_HopDong
    {
        private int _HopDong_maHopDong;
        private int _HopDong_maYeuCauVayVon;

        public int HopDong_maHopDong
        {
            get => _HopDong_maHopDong;
            set => _HopDong_maHopDong = value;
        }
        public int HopDong_maYeuCauVayVon
        {
            get => HopDong_maHopDong;
            set => _HopDong_maYeuCauVayVon = value;
        }

        public DTO_HopDong(int madk, int maycvv)
        {
            this.HopDong_maHopDong = madk;
            this.HopDong_maYeuCauVayVon = maycvv;

        }

    }

}

