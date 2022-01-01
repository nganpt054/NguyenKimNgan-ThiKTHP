using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVTT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSVTT_Click(object sender, EventArgs e)
        {
            frmSVTT svtt = new frmSVTT();
            svtt.Show();
            this.Hide();
            
        }

        private void btnHSSV_Click(object sender, EventArgs e)
        {

        }

        private void btnHSGV_Click(object sender, EventArgs e)
        {

        }

        private void btnBoMon_Click(object sender, EventArgs e)
        {

        }

        private void btnLop_Click(object sender, EventArgs e)
        {

        }

        private void btnBangDiem_Click(object sender, EventArgs e)
        {

        }
    }
}
