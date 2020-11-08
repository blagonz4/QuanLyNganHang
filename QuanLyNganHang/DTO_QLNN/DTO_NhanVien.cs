using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang.DTO_QLNN

{
    public class DTO_NhanVien
    {
        private int _NhanVien_maNhanVien;
        private string _NhanVien_name;
        private string _NhanVien_username;
        private string _NhanVien_password;
        private int _NhanVien_maChucVu;

        public int NhanVien_maNhanVien
        {
            get => _NhanVien_maNhanVien;
            set => _NhanVien_maNhanVien = value;
        }
        public string NhanVien_name
        {
            get => _NhanVien_name;
            set => _NhanVien_name = value;
        }
        public string NhanVien_username
        {
            get => _NhanVien_username;
            set => _NhanVien_username = value;
        }
        public string NhanVien_password
        { 
            get => _NhanVien_password;
            set => _NhanVien_password = value;
        }
        public int NhanVien_maChucVu
        {
            get => _NhanVien_maChucVu;
            set => _NhanVien_maChucVu = value;
        }
        public DTO_NhanVien(int manv, string name, string username, string  password,int macv)
        {
            this.NhanVien_maNhanVien = manv;
            this.NhanVien_name = name;
            this.NhanVien_username = username;
            this.NhanVien_password = password;
            this.NhanVien_maChucVu = macv;
        }

    }
}
