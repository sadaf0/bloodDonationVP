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
    public partial class Form1 : Form
    {
        insertkaconnection i = new insertkaconnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox8.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox10.Text == "" && textBox11.Text == "" && textBox12.Text == "")
            {

                MessageBox.Show("Boxes can't be Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                try
                {
                    i.sqlConnection1.Open();
                    SqlCommand cmd = new SqlCommand("insert into recordadd (ID,Name,F_Name,Age,Sex,DOB,MobileNo,CNICNo,City,Address,Height,EyeColor,Any_Disease,Donated_Before,Blood_Group,Date_donation,BagName) values(@ID,@Name,@F_Name,@Age,@Sex,@DOB,@MobileNo,@CNICNo,@City,@Address,@Height,@EyeColor,@Any_Disease,@Donated_Before,@Blood_Group,@Date_donation,@BagName)", i.sqlConnection1);
                    cmd.Parameters.AddWithValue("@ID", textBox9.Text);
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@F_Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Age", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Sex", textBox8.Text);
                    cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@MobileNo", textBox4.Text);
                    cmd.Parameters.AddWithValue("@CNICNo", textBox5.Text);
                    cmd.Parameters.AddWithValue("@City", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Address", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Height", textBox10.Text);
                    cmd.Parameters.AddWithValue("@EyeColor", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Any_Disease", textBox11.Text);
                    cmd.Parameters.AddWithValue("@Donated_Before", textBox12.Text);
                    cmd.Parameters.AddWithValue("@Blood_Group", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Date_Donation", dateTimePicker2.Text);
                    cmd.Parameters.AddWithValue("@BagName", comboBox3.Text);
                    cmd.ExecuteNonQuery();
                    //textBox5.Text += "PO-ID: " + comboBox1.Text + Environment.NewLine + "V-Status: " + textBox7.Text + Environment.NewLine + "V-Name: " + textBox6.Text + Environment.NewLine + "DDate: " + textBox4.Text + Environment.NewLine + "GR-Date: " + dateTimePicker1.Text + Environment.NewLine + "SNO: " + textBox3.Text;
                    MessageBox.Show("New Person Is Added On Database");
                    //SqlCommand cm = new SqlCommand("Select * from recordadd", i.sqlConnection1);


                    //SqlDataReader dr = cm.ExecuteReader();
                    //DataTable dt = new DataTable();
                    //dt.Load(dr);
                    //dataGridView1.DataSource = dt;
                }

                catch (Exception ee)
                {
                    MessageBox.Show("error" + ee);
                }
                i.sqlConnection1.Close();
                button1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBox9.ReadOnly = true;

            string[] eyecolr = {"red","hazel","blue"};
            {
            
            comboBox1.Items.AddRange(eyecolr);
            
            }


            string[] bloodgrup = { "O+", "O-", "AB+" };
            {

                comboBox2.Items.AddRange(bloodgrup);

            }



            int c = 0;


            i.sqlConnection1.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("select count(id) from recordadd ", i.sqlConnection1);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = Convert.ToInt32(dr[0]);

                }
                c++;
                textBox9.Text = "ID-0" + c.ToString() + "-" + System.DateTime.Today.Year;

             

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }

            i.sqlConnection1.Close();


            try {
                i.sqlConnection1.Open();

                SqlCommand cmf = new SqlCommand("select id from bloodbagentry", i.sqlConnection1);
                SqlDataReader drr = cmf.ExecuteReader();
                while (drr.Read())
                {
                    this.comboBox3.Items.Add(drr["id"]).ToString();
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






        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";











        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ALLMENU a = new ALLMENU();
            a.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SqlCommand cm = new SqlCommand("Select * from recordadd", i.sqlConnection1);
            i.sqlConnection1.Open();

            SqlDataReader dr = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            i.sqlConnection1.Close();









        }
    }
}
