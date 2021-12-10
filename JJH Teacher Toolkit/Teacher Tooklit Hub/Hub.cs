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
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new Timer();
            newForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new StudentPicker();
            newForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new DiceRoller();
            newForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new RewardSystem();
            newForm.Show();
            this.Close();
        }

        private void Hub_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kahoot.com/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.utcsheffield.org.uk/olp/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bing.com/");
        }
    }
}
