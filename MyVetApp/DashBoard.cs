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
    public partial class DashBoard : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=USER\COURSE2017;Initial Catalog=MyVeterinaryDb;Integrated Security=True");

        public DashBoard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from ClientTbl", Con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            ClientsDB.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from DoctorTbl", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            DoctorsDB.Text = dt2.Rows[0][0].ToString();

            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from VisitTbl", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            VisitsDB.Text = dt3.Rows[0][0].ToString();

            SqlDataAdapter sda4 = new SqlDataAdapter("select count(*) from AnimalTbl", Con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            PetsDB.Text = dt4.Rows[0][0].ToString();

            Con.Close();
        }
    }
}
