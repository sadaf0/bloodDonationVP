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
    public partial class Edit_Donor : Form
    {
        insertkaconnection i = new insertkaconnection();
        public Edit_Donor()
        {
            InitializeComponent();
        }

        private void Edit_Donor_Load(object sender, EventArgs e)
        {
            try
            {
                i.sqlConnection1.Open();

                SqlCommand cmf = new SqlCommand("select ID from recordadd", i.sqlConnection1);
                SqlDataReader drr = cmf.ExecuteReader();
                while (drr.Read())
                {
                    this.comboBox3.Items.Add(drr["ID"]).ToString();
                }

            }

            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }
            i.sqlConnection1.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                i.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("Select * from recordadd where ID='" + comboBox3.Text + "'", i.sqlConnection1);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox1.Text = dr["Name"].ToString();
                    textBox2.Text = dr["F_Name"].ToString();
                    textBox3.Text = dr["Age"].ToString();
                    textBox8.Text = dr["Sex"].ToString();
                    textBox10.Text = dr["DOB"].ToString();
                    textBox4.Text = dr["MobileNo"].ToString();
                    textBox5.Text = dr["CNICNo"].ToString();
                    textBox6.Text = dr["City"].ToString();
                    textBox7.Text = dr["Address"].ToString();                
                
                }

            }

            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);

            }

            i.sqlConnection1.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            i.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select * from recordadd",i.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            i.sqlConnection1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox8.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox10.Text == "")
            {

                MessageBox.Show("Boxes can't be Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                 try
                {

                i.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("Update recordadd set name=@name,f_name=@f_name,age=@age,sex=@sex,dob=@dob,mobileno=@mobileno,cnicno=@Cnicno,city=@city,Address=@address where id='" + comboBox3.Text + "'", i.sqlConnection1);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@f_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@age", textBox3.Text);
                cmd.Parameters.AddWithValue("@sex", textBox8.Text);
                cmd.Parameters.AddWithValue("@dob", textBox10.Text);
                cmd.Parameters.AddWithValue("@mobileno", textBox4.Text);
                cmd.Parameters.AddWithValue("@cnicno", textBox5.Text);
                cmd.Parameters.AddWithValue("@city", textBox6.Text);
                cmd.Parameters.AddWithValue("@address", textBox7.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Selected Data has been Updated ");
                i.sqlConnection1.Close();
                button1.Enabled = false;
                }

                 catch (Exception ee)
                 {
                     MessageBox.Show("error" + ee);
                 }
                 i.sqlConnection1.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ALLMENU a = new ALLMENU();
            a.Show();
            this.Hide();
        }
    }
}
