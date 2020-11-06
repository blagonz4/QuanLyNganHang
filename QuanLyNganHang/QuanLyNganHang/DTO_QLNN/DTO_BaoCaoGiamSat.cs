using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang.DTO_QLNN
{
    class DTO_BaoCaoGiamSat
    {
        private int _BCGS_maBCGS;
        private string _BCGS_cmnd;
        private string _BCGS_linkFileBaoCao;
        private int _BCGS_maNhanVien;

        public int BCGS_maBCGS
        {
            get => _BCGS_maBCGS;
            set => _BCGS_maBCGS = value;
        }
        public string BCGS_cmnd
        {
            get => _BCGS_cmnd;
            set => _BCGS_cmnd = value;
        }
        public string BCGS_linkFileBaoCao
        {
            get => _BCGS_linkFileBaoCao;
            set => _BCGS_linkFileBaoCao = value;
        }
        public int BCGS_maNhanVien
        {
            get => _BCGS_maNhanVien;
            set => _BCGS_maNhanVien = value;
        }
        public DTO_BaoCaoGiamSat(int maBCGS,string cmnd, string link, int magv )
        {
            this.BCGS_maBCGS = maBCGS;
            this.BCGS_cmnd = cmnd;
            this.BCGS_linkFileBaoCao = link;
            this.BCGS_maNhanVien =magv;
        }
    }
}
