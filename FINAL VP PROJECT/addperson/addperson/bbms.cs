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

namespace addperson
{
    public partial class bbms : Form
    {
        insertkaconnection conn = new insertkaconnection();
        public bbms()
        {
            InitializeComponent();
        }

        private void bbms_Load(object sender, EventArgs e)
        {
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void newBagEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NEWBAGENTRY n = new NEWBAGENTRY();
            n.Show();
            this.Hide();
        }

        private void newDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void newHospitalEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newHospitalEntryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            newhsptlentry n = new newhsptlentry();
            n.Show();
            this.Hide();

        }

        private void newTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtransaction n = new newtransaction();
            n.Show();
            this.Hide();
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Donor d = new Edit_Donor();
            d.Show();
            this.Hide();
        }

        private void handleBloodBagToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchBloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SBG s = new SBG();
            s.Show();
            this.Hide();
        }

        private void checkDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDonor k = new ViewDonor();
            k.Show();
            this.Hide();
        }

        

        private void hospitalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blood Bank Management System By ** Syeda Sadaf **", "Developer", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
    }
}
