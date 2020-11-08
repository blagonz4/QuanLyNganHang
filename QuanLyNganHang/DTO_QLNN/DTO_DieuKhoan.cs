using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang.DTO_QLNN
{
    public class DTO_DieuKhoan
    {
        private int _DieuKhoan_maDieuKhoan;
        private int _DieuKhoan_maHopDong;
        private string _DieuKhoan_noiDungDieuKhoan;


        public int DieuKhoan_maDieuKhoan
        {
            get => _DieuKhoan_maDieuKhoan;
            set => _DieuKhoan_maDieuKhoan = value;
        }
        public int DieuKhoan_maHopDong
        {
            get => _DieuKhoan_maHopDong;
            set => _DieuKhoan_maHopDong = value;
        }
        public string DieuKhoan_noiDungDieuKhoan
        {
            get => _DieuKhoan_noiDungDieuKhoan;
            set => _DieuKhoan_noiDungDieuKhoan = value;
        }

        public DTO_DieuKhoan(int madk, int mahd, string ndung)
        {
            this.DieuKhoan_maDieuKhoan = madk;
            this.DieuKhoan_maHopDong = mahd;
            this.DieuKhoan_noiDungDieuKhoan = ndung;

        }

    }

}

