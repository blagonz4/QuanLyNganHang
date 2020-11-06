using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang.DTO_QLNN
{
    public class DTO_KhachHang
    {
        private int _KhachHang_cmnd;
        private string _KhachHang_name;
        private string _KhachHang_diachi;
        private int _KhachHang_phone;

        public int KhachHang_cmnd
        {
            get => _KhachHang_cmnd;
            set => _KhachHang_cmnd = value;
        }
        public string KhachHang_name
        {
            get => _KhachHang_name;
            set => _KhachHang_name = value;
        }
        public string KhachHang_diachi
        {
            get => _KhachHang_diachi;
            set => _KhachHang_diachi = value;
        }
        public int KhachHang_phone
        {
            get => _KhachHang_phone;
            set => _KhachHang_phone = value;
        }


        public DTO_KhachHang(int cmnd,string name, string diachi, int phone)
        {
            this.KhachHang_cmnd = cmnd;
            this.KhachHang_name = name;
            this.KhachHang_diachi = diachi;
            this.KhachHang_phone = phone;

        }

    }

}

