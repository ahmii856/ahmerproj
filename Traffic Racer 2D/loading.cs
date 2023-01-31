using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Racer_2D
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        int second = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                second++;
                panel2.Left += 2;
                if (panel2.Left + panel2.Width > panel1.Width + 10)
                    panel2.Left = 0;
                if (second == 300)
                {
                    START st1 = new START();
                    timer1.Stop();
                    this.Hide();
                    st1.Show();
                }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
