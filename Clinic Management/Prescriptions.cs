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
    public partial class Prescriptions : Form
    {
        public Prescriptions()
        {
            InitializeComponent();
            if (Login.Role == "Doctor")
            {
                Pa_Lb.Enabled = true;
                Doc_Lb.Enabled = false;
                Presc_Lb.Enabled = true;
                Appoint_Lb.Enabled = true;
            }
            DisplayPrescriptions();
            PrescGridView1.ClearSelection();
            GetDocID(); GetPaID();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMINS\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayPrescriptions()
        {
            string Query = "Select * from PrescriptionsTb1";
            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            PrescGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            DocID_Cbox.SelectedIndex = 0;
            DocName_Tbox.Text = string.Empty;
            PaID_Cbox.SelectedIndex = 0;
            PaName_Tbox.Text= string.Empty;
            Med_Tbox.Text = string.Empty;
            //key = 0;
        }
        private void GetDocID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select DocID from DoctorTb1", Con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DocID",typeof(int));
            dt.Load(dr);
            DocID_Cbox.ValueMember = "DocID";
            DocID_Cbox.DataSource = dt;
            Con.Close();
        }
        private void GetPaID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select PaID from PatientTb1", Con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PaID", typeof(int));
            dt.Load(dr);
            PaID_Cbox.ValueMember = "PaID";
            PaID_Cbox.DataSource = dt;
            Con.Close();
        }
        private void GetDocName()
        {
            Con.Open();
            string Query = "Select * from DoctorTb1 where DocID=" + DocID_Cbox.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                DocName_Tbox.Text = dr["DocName"].ToString();
            }
            Con.Close();
        }
        private void DocID_Cbox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDocName();
        }
        private void GetPaName()
        {
            Con.Open();
            string Query = "Select * from PatientTb1 where PaID=" + PaID_Cbox.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PaName_Tbox.Text = dr["PaName"].ToString();
            }
            Con.Close();
        }

        private void PaID_Cbox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPaName();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (PaName_Tbox.Text == "" || DocName_Tbox.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PrescriptionsTb1(DocID, DocName, PaID, PaName, Medications)values(@DI,@DN,@PI,@PN,@Med)", Con);
                    cmd.Parameters.AddWithValue("@DI", DocID_Cbox.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DN", DocName_Tbox.Text);
                    cmd.Parameters.AddWithValue("@PI", PaID_Cbox.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", PaName_Tbox.Text);
                    cmd.Parameters.AddWithValue("@Med", Med_Tbox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prescription Added");
                    Con.Close();
                    DisplayPrescriptions();
                    Clear();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void PrescGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Presc.Text = "";
            Presc.Text = "                       Prescriptions                       \n******************************************************************\n" + DateTime.Today.Date + "\nPatient:" + PrescGridView1.SelectedRows[0].Cells[4].Value.ToString() + "\nDoctor:" + PrescGridView1.SelectedRows[0].Cells[2].Value.ToString() + "\n******************************************************************\nMedication:" + PrescGridView1.SelectedRows[0].Cells[5].Value.ToString() + "\n******************************************************************\nHave a wonderful day!";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Presc.Text + "\n", new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new Point(95, 80));
        }

        private void Pa_Lb_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Homes obj = new Homes();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
