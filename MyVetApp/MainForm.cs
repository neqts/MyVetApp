using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVetApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            VisitStartForm Visit = new VisitStartForm();
            Visit.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pets_Click(object sender, EventArgs e)
        {
            ClientForm pet = new ClientForm();
            pet.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PetTbl petform = new PetTbl();
            petform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorForm Doctor = new DoctorForm();
            Doctor.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BasicTreatmentsForm Treatment = new BasicTreatmentsForm();
            Treatment.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AboutUs About = new AboutUs();
            About.Show();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DashBoard Board = new DashBoard();
            Board.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TipsForm tips = new TipsForm();
            tips.Show();
        }
    }
}
