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
        private void FillPet()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select AnimalId from AnimalTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AnimalId", typeof(int));
            dt.Load(rdr);
            VisitCb.ValueMember = "AnimalId";
            VisitCb.DataSource = dt;
            Con.Close();
        }

        private void FillClient()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ClientId from ClientTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientId", typeof(int));
            dt.Load(rdr);
            ClientCb.ValueMember = "ClientId";
            ClientCb.DataSource = dt;
            Con.Close();
        }

        private void fetchstddata()
        {
            Con.Open();
            string query = "select * from ClientTbl where ClientId=" + ClientCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                ClientNameTb.Text = dr["ClientName"].ToString();
                ClientPhoneTb.Text = dr["ClientPhone"].ToString();
            }

            Con.Close();
        }
       

        public VisitStartForm()
        {
            InitializeComponent();
        }

        public void populate()
        {
            Con.Open();
            string query = "select * from VisitTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            VisitStartDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VisitId.Text == "" || ClientNameTb.Text == "" )
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                string visitStartDate = VisitStart.Value.Year.ToString() + "-" + VisitStart.Value.Month.ToString() + "-" + VisitStart.Value.Day.ToString();
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into VisitTbl values(" + VisitId.Text + "," + ClientCb.SelectedValue.ToString() + ",'" + ClientNameTb.Text + "'," + ClientPhoneTb.Text + "," + VisitCb.SelectedValue.ToString() + ",'" + visitStartDate + "')", Con);
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
            if (VisitId.Text == "")
            {
                MessageBox.Show("Enter The Visit Id");
            }
            else
            {
                Con.Open();
                string query = "delete from VisitTbl where VisitId =" + VisitId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Visit Succesfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void VisitStartDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = VisitStartDGV.SelectedCells[0].RowIndex;

            ClientCb.SelectedItem = VisitStartDGV.Rows[rowIndex].Cells[0].Value.ToString();
            ClientNameTb.Text = VisitStartDGV.Rows[rowIndex].Cells[1].Value.ToString();
            ClientPhoneTb.Text = VisitStartDGV.Rows[rowIndex].Cells[2].Value.ToString();
            VisitCb.SelectedItem = VisitStartDGV.Rows[rowIndex].Cells[3].Value.ToString();
            VisitId.Text = VisitStartDGV.Rows[rowIndex].Cells[4].Value.ToString();
           


        }

        private void VisitStartForm_Load(object sender, EventArgs e)
        {

            FillPet();
            FillClient();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        private void ClientCb_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void ClientCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchstddata();
           
        }
    }
}
