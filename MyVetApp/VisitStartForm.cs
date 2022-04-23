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
    public partial class VisitStartForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=USER\COURSE2017;Initial Catalog=MyVeterinaryDb;Integrated Security=True");

        public VisitStartForm()
        {
            InitializeComponent();
        }

        public void populate()
        {
            Con.Open();
            string query = "select * from VisitStartTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            VisitStartDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClientId.Text == "" || AnimalName.Text == "" || ClientPhone.Text == "" || DateVisit.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into VisitStartTbl values(" + ClientId.Text + ",'" + AnimalName.Text + "','" + ClientPhone.Text + "','" + DateVisit.Value + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Visit Added Succesfully");
                Con.Close();
                populate();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ClientId.Text == "")
            {
                MessageBox.Show("Enter The Client Id");
            }
            else
            {
                Con.Open();
                string query = "delete from VisitStartTbl where ClientId =" + ClientId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client Succesfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ClientId.Text == "" || AnimalName.Text == "" || ClientPhone.Text == "" || DateVisit.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "update VisitStartTbl set ClientId ='" + ClientId.Text + "',AnimalName ='" + AnimalName.Text + "', ClientPhone ='" + ClientPhone.Text + "', DateVisit ='" + DateVisit.Text + "' where ClientId=" + ClientId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Visit Successfully Update");
                Con.Close();
                populate();
            }
        }

        private void VisitStartDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = VisitStartDGV.SelectedCells[0].RowIndex;

            ClientId.Text = VisitStartDGV.Rows[rowIndex].Cells[0].Value.ToString();
            AnimalName.Text = VisitStartDGV.Rows[rowIndex].Cells[1].Value.ToString();
            ClientPhone.Text = VisitStartDGV.Rows[rowIndex].Cells[2].Value.ToString();
            DateVisit.Text = VisitStartDGV.Rows[rowIndex].Cells[3].Value.ToString();
            

        }

        private void VisitStartForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }
    }
}
