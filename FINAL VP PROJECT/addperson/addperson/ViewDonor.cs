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
    public partial class ViewDonor : Form
    {
        insertkaconnection conn = new insertkaconnection();
        public ViewDonor()
        {
            InitializeComponent();
        }

        private void checkdonor_Load(object sender, EventArgs e)
        {
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select Name from recordadd", conn.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.comboBox1.Items.Add(dr["Name"]).ToString();
            }
            conn.sqlConnection1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select  * from recordadd where Name='" + this.comboBox1.Text + "'", conn.sqlConnection1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           // button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ALLMENU a = new ALLMENU();
            a.Show();
            this.Hide();
        }
    }
}
