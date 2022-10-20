using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Maker
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_form_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_form_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            Hide();
            Scaner obj = new Scaner();
            obj.Show();
        }
    }
}
