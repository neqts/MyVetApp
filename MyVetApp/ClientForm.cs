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

namespace MyVetApp
{
    public partial class ClientForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=USER\COURSE2017;Initial Catalog=MyVeterinaryDb;Integrated Security=True");
        public ClientForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClientForm pet = new ClientForm();
            pet.Show();
            this.Hide();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void populate()
        {
            Con.Open();
            string query = "select * from ClientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ClientId.Text == "" || ClientName.Text == "" || ClientPassword.Text == "" || ClientPhone.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ClientTbl values(" + ClientId.Text + ",'" + ClientName.Text + "','" + ClientPassword.Text + "','" + ClientPhone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client Added Succesfully");
                Con.Close();
                populate();
            }
        }
    }
}
