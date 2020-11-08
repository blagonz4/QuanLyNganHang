using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang.DTO_QLNN

{
    public class DTO_TrangThaiYeuCauVayVon
    {
        private int _TTYCVV_maTrangThai;
        private string _TTYCVV_tenTrangThai;

        public int TTYCVV_maTrangThai
        {
            get => _TTYCVV_maTrangThai;
            set => _TTYCVV_maTrangThai = value;
        }
        public string TTYCVV_tenTrangThai
        {
            get => _TTYCVV_tenTrangThai;
            set => _TTYCVV_tenTrangThai = value;
        }

        public DTO_TrangThaiYeuCauVayVon(int matt, string tentt)
        {
            this.TTYCVV_maTrangThai = matt;
            this.TTYCVV_tenTrangThai = tentt;

        }

    }
}
