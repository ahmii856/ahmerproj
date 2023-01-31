using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Traffic_Racer_2D
{
    public partial class Highscores : Form
    {
        public Highscores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Highscores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'racing_carDataSet.Table_3' table. You can move, or remove it, as needed.
            this.table_3TableAdapter.Fill(this.racing_carDataSet.Table_3);
            // TODO: This line of code loads data into the 'ahmercarDataSet1.Table_2' table. You can move, or remove it, as needed.
            this.table_2TableAdapter1.Fill(this.ahmercarDataSet1.Table_2);
            // TODO: This line of code loads data into the 'ahmercarDataSet.Table_2' table. You can move, or remove it, as needed.
            this.table_2TableAdapter.Fill(this.ahmercarDataSet.Table_2);
            // TODO: This line of code loads data into the 'carDataSet.game' table. You can move, or remove it, as needed.
            this.gameTableAdapter.Fill(this.carDataSet.game);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            table3BindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table3BindingSource.EndEdit();
            table_3TableAdapter.Update(racing_carDataSet.Table_3);
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-C6B1GJG\\SQLEXPRESS;Initial Catalog=\"racing car\";Integrated Security=True");
            con.Open();
            MessageBox.Show("Connection open");
            SqlCommand cm;
            string nm = textBox1.Text;
            string query = "insert into Table3 (Name) values ( '" + nm + "')";
            cm = new SqlCommand(query, con);
            cm.Dispose();
            con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table3BindingSource.RemoveCurrent();
        }
    }
}
