using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang.DTO_QLNN
{
    public class DTO_KhachHang
    {
        private string _KhachHang_cmnd;
        private string _KhachHang_name;
        private string _KhachHang_diachi;
        private string _KhachHang_phone;

        public string KhachHang_cmnd
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
        public string KhachHang_phone
        {
            get => _KhachHang_phone;
            set => _KhachHang_phone = value;
        }


        public DTO_KhachHang(string cmnd,string name, string diachi, string phone)
        {
            this.KhachHang_cmnd = cmnd;
            this.KhachHang_name = name;
            this.KhachHang_diachi = diachi;
            this.KhachHang_phone = phone;

        }

    }

}

