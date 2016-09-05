using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmPlus
{
    public partial class frmSplash : Form
    {
        int counter = 0;
        int buffer = 0;
        frmLogin frm2 = new frmLogin();
        public frmSplash()
        {
            InitializeComponent();
            Opacity = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Opacity == 1)
            {
                timer2.Start();
                timer1.Stop();
            }
            else
            {
                counter++;
                Opacity = counter * 0.03;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (buffer == 3)
            {
                timer3.Start();
                timer2.Stop();
            }
            else
            {
                buffer++;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                frm2.Show();
                Hide();
                timer3.Stop();
            }
            else
            {
                this.progressBar1.Increment(Convert.ToInt32(counter/5));
                counter--;
                Opacity = counter * 0.5;
            }
        }
    }
}
