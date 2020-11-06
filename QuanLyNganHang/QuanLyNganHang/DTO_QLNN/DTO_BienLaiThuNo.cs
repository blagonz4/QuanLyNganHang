using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang.DTO_QLNN
{
    public class DTO_BienLaiThuNo
    {
            private int _BLTN_maBLPTV;
            private int _BLTN_maHopDong;
            private int _BLTN_soTien;
            private string _BLTN_noiDung;
            private string _BLTN_ngayNopTien;
            private int _BLTN_maNguoiTao;

            public int BLTN_maBLPTV
            {
                get => _BLTN_maBLPTV;
                set => _BLTN_maBLPTV = value;
            }
            public int BLTN_maHopDong
            {
                get => _BLTN_maHopDong;
                set => _BLTN_maHopDong = value;
            }
            public int BLTN_soTien
            {
                get => _BLTN_soTien;
                set => _BLTN_soTien = value;
            }
            public string BLTN_noiDung
            {
                get => _BLTN_noiDung;
                set => _BLTN_noiDung = value;
            }
            public string BLTN_ngayNopTien
            {
                get => _BLTN_ngayNopTien;
                set => _BLTN_ngayNopTien = value;
            }
            public int BLTN_maNguoiTao
            {
                get => _BLTN_maNguoiTao;
                set => _BLTN_maNguoiTao = value;
            }
            public DTO_BienLaiThuNo(int mablptv, int mahd, int sotien, string ndung, string ngaynt, int mant )
            {
                this.BLTN_maBLPTV = mablptv;
                this.BLTN_maHopDong = mahd;
                this.BLTN_soTien = sotien;
                this.BLTN_noiDung = ndung;
                this.BLTN_ngayNopTien = ngaynt;
                this.BLTN_maNguoiTao = mant;
            }

    }

}

