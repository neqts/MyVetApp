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
    public partial class BasicTreatmentsForm : Form
    {
        public BasicTreatmentsForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=USER\COURSE2017;Initial Catalog=MyVeterinaryDb;Integrated Security=True");


        public void populate()
        {
            Con.Open();
            string query = "select * from BasicTreatmentTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            TreatmentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TreatmentName.Text == "" || TreatmentPrice.Text == "" || TreatmentHours.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into BasicTreatmentTbl values('" + TreatmentName.Text + "'," + TreatmentPrice.Text + "," + TreatmentHours.Text + ")", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Treatment Added Succesfully");
                Con.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TreatmentName.Text == "")
            {
                MessageBox.Show("Enter The Client Id");
            }
            else
            {
                Con.Open();
                string query = "delete from BasicTreatmentTbl where TreatmentName ='" + TreatmentName.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Treatment Succesfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TreatmentName.Text == "" || TreatmentPrice.Text == "" || TreatmentHours.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "update BasicTreatmentTbl set TreatmentName ='" + TreatmentName.Text + "',TreatmentPrice =" + TreatmentPrice.Text + ", TreatmentHours =" + TreatmentHours.Text + "  where TreatmentName='" + TreatmentName.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Treatment Successfully Update");
                Con.Close();
                populate();
            }
        }

        private void TreatmentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = TreatmentDGV.SelectedCells[0].RowIndex;

            TreatmentName.Text = TreatmentDGV.Rows[rowIndex].Cells[0].Value.ToString();
            TreatmentPrice.Text = TreatmentDGV.Rows[rowIndex].Cells[1].Value.ToString();
            TreatmentHours.Text = TreatmentDGV.Rows[rowIndex].Cells[2].Value.ToString();
           
        }

        private void BasicTreatmentsForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void TreatmentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }
    }
}
