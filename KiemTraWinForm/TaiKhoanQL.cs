using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraWinForm
{
    internal class TaiKhoanQL
    {
        private string tenTaiKhoan;
        private string matKhau;

        public TaiKhoanQL()
        {

        }

        public TaiKhoanQL(string tenTaiKhoan, string matKhau)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }

        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
