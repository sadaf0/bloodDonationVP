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
    public partial class LOGINFINAL : Form
    {
        public LOGINFINAL()
        {
            InitializeComponent();
        }

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    textBox2.PasswordChar = '*';
        //    button1.Visible = true;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (textBox1.Text == "a" && textBox2.Text == "a")
        //    {
        //        bbms b = new bbms();
        //        b.Show();
        //        this.Hide();


        //    }
        //    else
        //    {
        //        MessageBox.Show("Kindly Enter ID And Password to proceed Further","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        //    }
        //}

        private void LOGINFINAL_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            label3.Visible = false;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            button1.Visible = true;
            label3.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "a" && textBox2.Text == "a")
            {
                bbms b = new bbms();
                b.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Kindly Enter ID And Password to proceed Further", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
