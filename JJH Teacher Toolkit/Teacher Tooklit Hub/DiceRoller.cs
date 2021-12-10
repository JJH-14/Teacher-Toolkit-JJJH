using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_Tooklit_Hub
{
    public partial class DiceRoller : Form
    {
        public DiceRoller()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 6+1);
            textBox1.Text = dice1.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 12+1);
            textBox2.Text = dice1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 18+1);
            textBox3.Text = dice1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 24+1);
            textBox4.Text = dice1.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newForm = new Hub();
            newForm.Show();
            this.Close();
        }
    }
}
