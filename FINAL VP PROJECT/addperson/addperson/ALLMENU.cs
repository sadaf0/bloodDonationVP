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
    public partial class ALLMENU : Form
    {
        public ALLMENU()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Edit_Donor d = new Edit_Donor();
            d.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            NEWBAGENTRY n = new NEWBAGENTRY();
            n.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SBG s = new SBG();
            s.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            newtransaction n = new newtransaction();
            n.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            newhsptlentry n = new newhsptlentry();
            n.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blood Bank Management System By ** Syeda Sadaf **", "Developer", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ALLMENU_Load(object sender, EventArgs e)
        {
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button9.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            button12.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button13.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button14.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewDonor k = new ViewDonor();
            k.Show();
            this.Hide();
        }
    }
}
