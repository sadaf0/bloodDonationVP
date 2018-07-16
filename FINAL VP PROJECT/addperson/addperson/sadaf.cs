using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addperson
{
    public partial class sadaf : Form
    {
        public sadaf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            button2.Visible = true;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void sadaf_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bbms b = new bbms();
            b.Show();
            this.Hide();
        }
    }
}
