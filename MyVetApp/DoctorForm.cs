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
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=USER\COURSE2017;Initial Catalog=MyVeterinaryDb;Integrated Security=True");

        public void populate()
        {
            Con.Open();
            string query = "select * from DoctorTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DoctorId.Text == "" || DoctorName.Text == "" || DoctorLastName.Text == "" || DoctorAge.Text == "" || DoctorCertification.Text == "" || DoctorPhone.Text == "" || DoctorProffesion.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into DoctorTbl values(" + DoctorId.Text + ",'" + DoctorName.Text + "','" + DoctorLastName.Text + "','" + DoctorAge.Text + "','" + DoctorCertification.Text + "','" + DoctorPhone.Text + "','" + DoctorProffesion.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Added Succesfully");
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
            if (DoctorId.Text == "")
            {
                MessageBox.Show("Enter The Doctor Id");
            }
            else
            {
                Con.Open();
                string query = "delete from DoctorTbl where DoctorId =" + DoctorId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Succesfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void DoctorDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = DoctorDGV.SelectedCells[0].RowIndex;

            DoctorId.Text = DoctorDGV.Rows[rowIndex].Cells[0].Value.ToString();
            DoctorName.Text = DoctorDGV.Rows[rowIndex].Cells[1].Value.ToString();
            DoctorLastName.Text = DoctorDGV.Rows[rowIndex].Cells[2].Value.ToString();
            DoctorAge.Text = DoctorDGV.Rows[rowIndex].Cells[3].Value.ToString();
            DoctorPhone.Text = DoctorDGV.Rows[rowIndex].Cells[4].Value.ToString();
            DoctorCertification.Text = DoctorDGV.Rows[rowIndex].Cells[5].Value.ToString();
            DoctorProffesion.Text = DoctorDGV.Rows[rowIndex].Cells[6].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DoctorId.Text == "" || DoctorName.Text == "" || DoctorLastName.Text == "" || DoctorAge.Text == "" || DoctorCertification.Text == "" || DoctorPhone.Text == "" || DoctorProffesion.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "update DoctorTbl set DoctorName ='" + DoctorName.Text + "',DoctorLastName ='" + DoctorLastName.Text + "', DoctorAge ='" + DoctorAge.Text + "', DoctorCertification ='" + DoctorCertification.Text + "', DoctorPhone ='" + DoctorPhone.Text + "', DoctorProffesion ='" + DoctorProffesion.Text + "' where DoctorId=" + DoctorId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Update");
                Con.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }
    }
}
