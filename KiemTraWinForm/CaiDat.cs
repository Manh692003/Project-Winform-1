using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace KiemTraWinForm
{
    public partial class CaiDat : Form
    {
        public CaiDat()
        {
            InitializeComponent();
        }

        private Form home;

        private void moHome(Form childForm)
        {
            if (home != null)
            {
                home.Close();
            }
            home = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            body.Controls.Add(childForm);
            body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moHome(new DoiMKQL());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moHome(new QLTaiKhoan());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moHome(new QLKyThi());
        }
    }
}
