using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraWinForm
{
    internal class TaiKhoan
    {
        private string hoten;
        private string lop;
        private string taikhoan;
        private string matkhau;

        public TaiKhoan()
        {
            
        }

        public TaiKhoan(string hoten, string lop, string taikhoan, string matkhau)
        {
            this.hoten = hoten;
            this.lop = lop;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
        }

        public string HoTen { get => hoten; set => hoten = value; }

        public string Lop { get => lop; set => lop = value; }

        public string TaiKhoans { get => taikhoan; set => taikhoan = value; }

        public string MatKhau { get => matkhau; set => matkhau = value; }
    }
}
