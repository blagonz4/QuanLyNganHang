﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNganHang.DTO_QLNN;
using QuanLyNganHang.DAL_QLNN;
using System.Data;

namespace QuanLyNganHang.BUS_QLNN
{
    class BUS_KhachHang
    {
        private static BUS_KhachHang _instance;
        public static BUS_KhachHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BUS_KhachHang();
                return _instance;
            }
        }
        public bool themKhachHang(DTO_KhachHang kh)
        {
            return DAL_KhachHang.Instance.themKhachHang(kh);
        }
        public DataTable getDanhSach()
        {
            try
            {
                return DAL_KhachHang.Instance.getDanhSach();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DTO_KhachHang findOne(string cmnd)
        {
            try
            {
                return DAL_KhachHang.Instance.findOne(cmnd);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
