using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_DZ03_BojanPetrovic2745
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKlikni_Click(object sender, EventArgs e)
        {
            string unesi = tbUnesi.Text;

            lblTextSaTb.Text = unesi;
        }

        private void btnCrveno_Click(object sender, EventArgs e)
        {
           this.BackColor = Color.Red;
        }

        private void btnPlavo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btnZuto_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
    }
}
