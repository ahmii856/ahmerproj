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
    public partial class START : Form
    {
        public START()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 gamewindow = new Form1();
            gamewindow.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Highscores hi = new Highscores();
            hi.Show();
        }
    }
}
