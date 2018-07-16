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
    public partial class newtransaction : Form
    {
        insertkaconnection i = new insertkaconnection();
        public newtransaction()
        {
            InitializeComponent();
        }

        private void newtransaction_Load(object sender, EventArgs e)
        {
            try
            {
                i.sqlConnection1.Open();

                SqlCommand cmf = new SqlCommand("select hname from newhsptlentry", i.sqlConnection1);
                SqlDataReader drr = cmf.ExecuteReader();
                while (drr.Read())
                {
                    this.comboBox2.Items.Add(drr["hname"]).ToString();
                }






            }

            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }
            i.sqlConnection1.Close();
           
            
            try
            {
                i.sqlConnection1.Open();

                SqlCommand cmf = new SqlCommand("select Blood_Group from recordadd", i.sqlConnection1);
                SqlDataReader drr = cmf.ExecuteReader();
                while (drr.Read())
                {
                    this.comboBox1.Items.Add(drr["Blood_Group"]).ToString();
                }

            }

            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }

            i.sqlConnection1.Close();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                i.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("Select * from newhsptlentry where hname='" + comboBox2.Text + "'", i.sqlConnection1);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                { 
                
                textBox2.Text=dr["Addres"].ToString();
                textBox3.Text = dr["cn"].ToString();
                textBox4.Text = dr["cdn"].ToString();
                
                
                }
            
            }

            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
                
            }

            i.sqlConnection1.Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                i.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("Select Name,BagName from recordadd where Blood_Group='" + comboBox1.Text + "'", i.sqlConnection1);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox7.Text = dr["Name"].ToString();
                    textBox6.Text = dr["BagName"].ToString();
                    


                }

            }

            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
                
            }

            i.sqlConnection1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            if (textBox2.Text == "" && textBox3.Text == "" && textBox6.Text == "" && textBox4.Text == "" && textBox7.Text == "" && comboBox1.Text == "" && comboBox2.Text == "" && dateTimePicker1.Text == "")
            {

                MessageBox.Show("Boxes can't be Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {

                button1.Enabled = true;

                try
                {
                    i.sqlConnection1.Open();
                    SqlCommand cmd = new SqlCommand("insert into newtransaction (hname,Addres,cn,cdn,Bloodgroup,DonorName,BagName,Transactiondate) values(@hname,@Addres,@cn,@cdn,@Bloodgroup,@DonorName,@BagName,@Transactiondate)", i.sqlConnection1);
                    cmd.Parameters.AddWithValue("@hname", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Addres", textBox2.Text);
                    cmd.Parameters.AddWithValue("@cn", textBox3.Text);
                    cmd.Parameters.AddWithValue("@cdn", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Bloodgroup", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@DonorName", textBox7.Text);
                    cmd.Parameters.AddWithValue("@BagName", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Transactiondate", dateTimePicker1.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Successfully Done Transactions !! ");

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
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            //textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ALLMENU a = new ALLMENU();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i.sqlConnection1.Open();
            SqlCommand cm = new SqlCommand("Select * from newtransaction", i.sqlConnection1);


            SqlDataReader dr = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            i.sqlConnection1.Close();

        }
    }
}
