using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang.DTO_QLNN
{
    public class DTO_HoSoVayVon
    {
        private int _HSVV_maHoSoVayVon;
        private int _HSVV_maYeuCauVayVon;
        private string _HSVV_linkFileHoSo;

        public int HSVV_maHoSoVayVon
        {
            get => _HSVV_maHoSoVayVon;
            set => _HSVV_maHoSoVayVon = value;
        }
        public int HSVV_maYeuCauVayVon
        {
            get => _HSVV_maYeuCauVayVon;
            set => _HSVV_maYeuCauVayVon = value;
        }
        public string HSVV_linkFileHoSo
        {
            get => _HSVV_linkFileHoSo;
            set => _HSVV_linkFileHoSo = value;
        }
        public DTO_HoSoVayVon(int mahsvv, int maycvv, string link)
        {
            this.HSVV_maHoSoVayVon = mahsvv;
            this.HSVV_maYeuCauVayVon = maycvv;
            this.HSVV_linkFileHoSo = link;

        }

    }

}

