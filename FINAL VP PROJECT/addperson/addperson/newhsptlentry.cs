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
    public partial class newhsptlentry : Form
    {
        insertkaconnection i = new insertkaconnection();
        public newhsptlentry()
        {
            InitializeComponent();
        }

        private void newhsptlentry_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" && textBox3.Text == "" && textBox1.Text == "" && textBox4.Text == "")
            {

                MessageBox.Show("Boxes can't be Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {



                try
                {
                    i.sqlConnection1.Open();
                    SqlCommand cmd = new SqlCommand("insert into newhsptlentry (hname,Addres,cn,cdn) values(@hname,@Addres,@cn,@cdn)", i.sqlConnection1);
                    cmd.Parameters.AddWithValue("@hname", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Addres", textBox2.Text);
                    cmd.Parameters.AddWithValue("@cn", textBox3.Text);
                    cmd.Parameters.AddWithValue("@cdn", textBox4.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Person Is Added On Database");

                }

                catch (Exception ee)
                {
                    MessageBox.Show("error" + ee);
                }
                i.sqlConnection1.Close();
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ALLMENU a = new ALLMENU();
            a.Show();
            this.Hide();
        }
    }
}
