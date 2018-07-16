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
    public partial class NEWBAGENTRY : Form
    {
        insertkaconnection i = new insertkaconnection();
        public NEWBAGENTRY()
        {
            InitializeComponent();
        }

        private void NEWBAGENTRY_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            int c = 0;


            i.sqlConnection1.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("select count(id) from bloodbagentry ", i.sqlConnection1);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = Convert.ToInt32(dr[0]);

                }
                c++;
                textBox1.Text = "BE-10" + c.ToString();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }

            i.sqlConnection1.Close();










        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (  textBox2.Text == "" && textBox3.Text == "")
            {

                MessageBox.Show("Boxes can't be Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                try
                {
                    i.sqlConnection1.Open();
                    SqlCommand cmd = new SqlCommand("insert into bloodbagentry (id,Brand,cost,date) values(@id,@brand,@cost,@date)", i.sqlConnection1);
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Brand", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Cost", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Blood Bag Successfully Edit");

                }

                catch (Exception ee)
                {
                    MessageBox.Show("error" + ee);
                }
                i.sqlConnection1.Close();
                button1.Enabled = false;


            }







        }

        private void button3_Click(object sender, EventArgs e)
        {
            ALLMENU a = new ALLMENU();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
