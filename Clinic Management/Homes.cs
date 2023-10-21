using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management
{
    public partial class Homes : Form
    {
        public Homes()
        {
            InitializeComponent();
            if(Login.Role == "Doctor")
            {
                Pa_Lb.Enabled = true;
                Doc_Lb.Enabled = false;
                Presc_Lb.Enabled = true;
                Appoint_Lb.Enabled = true;
            }
            CountPa();
            CountDoc();
            timer1.Start();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMINS\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void CountPa()
        {
            Con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select count(*) from PatientTb1", Con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            TotalPa.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountDoc()
        {
            Con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select count(*) from DoctorTb1", Con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            TotalDoc.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
            obj.Show();
            this.Hide();
        }

        private void Doc_Lb_Click(object sender, EventArgs e)
        {
            Doctors obj = new Doctors();
            obj.Show();
            this.Hide();
        }

        private void Presc_Lb_Click(object sender, EventArgs e)
        {
            Prescriptions obj = new Prescriptions();
            obj.Show();
            this.Hide();
        }

        private void Appoint_Lb_Click(object sender, EventArgs e)
        {
            Appointment obj = new Appointment();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label4.Text = DateTime.Now.ToString();
        }
    }
}
