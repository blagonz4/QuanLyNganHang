using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang.DTO_QLNN

{
    public class DTO_YeuCauVayVon
    {
        private int _YCVV_maYeuCau;//1
        private string _YCVV_cmnd;
        private string _YCVV_mucdich;//3
        private int _YCVV_thoiHanVay;
        private int _YCVV_soTienVay;//5
        private int _YCVV_kiHan;
        private string _YCVV_ngayBatDauVay;//7
        private float _YCVV_laisuat;
        private int _YCVV_trangThai;//9

        public int YCVV_maYeuCau
        {
            get => _YCVV_maYeuCau;
            set => _YCVV_maYeuCau = value;
        }
        public string YCVV_cmnd
        {
            get => _YCVV_cmnd;
            set => _YCVV_cmnd = value;
        }
        public string YCVV_mucdich
        {
            get => _YCVV_mucdich;
            set => _YCVV_mucdich = value;
        }
        public int YCVV_thoiHanVay
        {
            get => _YCVV_thoiHanVay;
            set => _YCVV_thoiHanVay = value;
        }
        public int YCVV_soTienVay
        {
            get => _YCVV_soTienVay;
            set => _YCVV_soTienVay = value;
        }
        public int YCVV_kiHan
        {
            get => _YCVV_kiHan;
            set => _YCVV_kiHan = value;
        }
        public string YCVV_ngayBatDauVay
        {
            get => _YCVV_ngayBatDauVay;
            set => _YCVV_ngayBatDauVay = value;
        }
        public float YCVV_laisuat
        {
            get => _YCVV_laisuat;
            set => _YCVV_laisuat = value;
        }
        public int YCVV_trangThai
        {
            get => _YCVV_trangThai;
            set => _YCVV_trangThai = value;
        }
        public DTO_YeuCauVayVon(
            int mayc,//1
            string cmnd,
            string mucdich,//3
            int thoihan,
            int sotien,//5
            int kihan,
            string ngayvay,//7
            float laisuat,
            int trangthai//9
            )
        {
            this.YCVV_maYeuCau = mayc;
            this.YCVV_cmnd = cmnd;
            this.YCVV_mucdich = mucdich;
            this.YCVV_thoiHanVay = thoihan;
            this.YCVV_soTienVay = sotien;
            this.YCVV_kiHan = kihan;
            this.YCVV_ngayBatDauVay = ngayvay;
            this.YCVV_laisuat = laisuat;
            this.YCVV_trangThai = trangthai;

        }

    }
}
