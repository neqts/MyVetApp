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
    public partial class PetTbl : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=USER\COURSE2017;Initial Catalog=MyVeterinaryDb;Integrated Security=True");

        public PetTbl()
        {
            InitializeComponent();
        }

        private void PetTbl_Load(object sender, EventArgs e)
        {
            populate();
        }

        public void populate()
        {
            Con.Open();
            string query = "select * from AnimalTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PetDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (AnimalId.Text == "" || AnimalName.Text ==""|| AnimalAge.Text=="" || AnimalColor.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                Con.Open(); 
                SqlCommand cmd = new SqlCommand("insert into AnimalTbl values(" + AnimalId.Text + ",'" + AnimalName.Text + "','" + AnimalAge.Text + "','" + AnimalGender.SelectedItem.ToString() + "','" + AnimalColor.Text + "','" + AnimalNeutered.SelectedItem.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pet Added Succesfully");
                Con.Close();
                populate();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (AnimalId.Text == "")
            {
                MessageBox.Show("Enter The Animal Id");
            }
            else
            {
                Con.Open();
                string query = "delete from AnimalTbl where AnimalId =" + AnimalId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Animal Succesfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (AnimalId.Text == "" || AnimalName.Text == "" || AnimalAge.Text == "" || AnimalColor.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "update AnimalTbl set AnimalId ='" + AnimalId.Text + "',AnimalName ='" + AnimalName.Text + "', AnimalAge ='" + AnimalAge.Text + "', AnimalGender ='" + AnimalGender.Text + "', AnimalColor ='" + AnimalColor.Text + "', AnimalNeutered ='" + AnimalNeutered.Text + "' where AnimalId=" + AnimalId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pet Successfully Update");
                Con.Close();
                populate();
            }
        }

        private void PetDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = PetDGV.SelectedCells[0].RowIndex;

            AnimalId.Text = PetDGV.Rows[rowIndex].Cells[0].Value.ToString();
            AnimalName.Text = PetDGV.Rows[rowIndex].Cells[1].Value.ToString();
            AnimalAge.Text = PetDGV.Rows[rowIndex].Cells[2].Value.ToString();
            AnimalGender.Text = PetDGV.Rows[rowIndex].Cells[3].Value.ToString();
            AnimalColor.Text = PetDGV.Rows[rowIndex].Cells[4].Value.ToString();
            AnimalNeutered.Text = PetDGV.Rows[rowIndex].Cells[5].Value.ToString();
          
        }
      
    }
}
