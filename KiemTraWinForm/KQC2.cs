using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraWinForm
{
    public partial class KQC2 : Form
    {
        public static string DiemThi = string.Empty;
        public static string ck1 = string.Empty;
        public static string ck2 = string.Empty;
        public static string ck3 = string.Empty;
        public static string ck4 = string.Empty;
        public static string ck5 = string.Empty;
        public static string ck6 = string.Empty;
        public static string ck7 = string.Empty;
        public static string ck8 = string.Empty;
        public static string ck9 = string.Empty;
        public static string ck10 = string.Empty;

        public KQC2()
        {
            InitializeComponent();
        }

        private void KQC2_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DiemThi))
            {
                this.diem.Text = DiemThi;
            }
            if (!string.IsNullOrEmpty(ck1))
            {
                this.cau1.Text = ck1;
            }
            if (!string.IsNullOrEmpty(ck2))
            {
                this.cau2.Text = ck2;
            }
            if (!string.IsNullOrEmpty(ck3))
            {
                this.cau3.Text = ck3;
            }
            if (!string.IsNullOrEmpty(ck4))
            {
                this.cau4.Text = ck4;
            }
            if (!string.IsNullOrEmpty(ck5))
            {
                this.cau5.Text = ck5;
            }
            if (!string.IsNullOrEmpty(ck6))
            {
                this.cau6.Text = ck6;
            }
            if (!string.IsNullOrEmpty(ck7))
            {
                this.cau7.Text = ck7;
            }
            if (!string.IsNullOrEmpty(ck8))
            {
                this.cau8.Text = ck8;
            }
            if (!string.IsNullOrEmpty(ck9))
            {
                this.cau9.Text = ck9;
            }
            if (!string.IsNullOrEmpty(ck10))
            {
                this.cau10.Text = ck10;
            }

            string tk = diem.Text;
            string kt1 = cau1.Text;
            string kt2 = cau2.Text;
            string kt3 = cau3.Text;
            string kt4 = cau4.Text;
            string kt5 = cau5.Text;
            string kt6 = cau6.Text;
            string kt7 = cau7.Text;
            string kt8 = cau8.Text;
            string kt9 = cau9.Text;
            string kt10 = cau10.Text;
        }
    }
}
