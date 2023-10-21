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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
            if (Login.Role == "Doctor")
            {
                Pa_Lb.Enabled = true;
                Doc_Lb.Enabled = false;
                Presc_Lb.Enabled = true;
                Appoint_Lb.Enabled = true;
            }
            GetPaID(); GetDocID();
            DisplayAppointment(); ApGridView1.ClearSelection();
        }
        int key = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMINS\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayAppointment()
        {
            string Query = "Select * from ApTb1";
            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            ApGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            DocID_Cbox.SelectedIndex = 0;
            DocName_Tbox.Text = string.Empty;
            PaID_Cbox.SelectedIndex = 0;
            PaName_Tbox.Text = string.Empty;
            ApNote_Tbox.Text = string.Empty;
            key = 0;
        }
        private void GetDocID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select DocID from DoctorTb1", Con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DocID", typeof(int));
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
            foreach (DataRow dr in dt.Rows)
            {
                DocName_Tbox.Text = dr["DocName"].ToString();
            }
            Con.Close();
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

        private void DocID_Cbox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDocName();
        }

        private void PaID_Cbox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPaName();
        }

        private void button2_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("insert into ApTb1(PaID, PaName, DocID, DocName, ApDate, ApTime, ApNote)values(@PI,@PN,@DI,@DN,@ApD,@ApT,@ApN)", Con);
                    cmd.Parameters.AddWithValue("@PI", PaID_Cbox.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", PaName_Tbox.Text);
                    cmd.Parameters.AddWithValue("@DI", DocID_Cbox.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DN", DocName_Tbox.Text);
                    cmd.Parameters.AddWithValue("@ApD", ApDate.Value.Date);
                    cmd.Parameters.AddWithValue("@ApT", ApTime.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@ApN", ApNote_Tbox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment Recorded");
                    Con.Close();
                    DisplayAppointment();
                    Clear();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ApGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ApGridView1.SelectedRows.Count > 0)
            {
                PaName_Tbox.Text = ApGridView1.SelectedRows[0].Cells[2].Value.ToString();
                DocName_Tbox.Text = ApGridView1.SelectedRows[0].Cells[4].Value.ToString();
                ApDate.Text = ApGridView1.SelectedRows[0].Cells[5].Value.ToString();
                ApTime.Text = ApGridView1.SelectedRows[0].Cells[6].Value.ToString();
                ApNote_Tbox.Text = ApGridView1.SelectedRows[0].Cells[7].Value.ToString();
                if (PaName_Tbox.Text == string.Empty || DocName_Tbox.Text == string.Empty) { key = 0; }
                else { key = Convert.ToInt32(ApGridView1.SelectedRows[0].Cells[0].Value.ToString()); }
            }
            else { MessageBox.Show("Please select a row before you can access its information."); }
        }

        private void EditBtn_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("UPDATE ApTb1 SET PaID = @PI, PaName = @PN, DocID = @DI, DocName = @DN, ApDate = @ApD, ApTime = @ApT, ApNote = @ApN WHERE ApID = @ApKey", Con);
                    cmd.Parameters.AddWithValue("@PI", PaID_Cbox.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", PaName_Tbox.Text);
                    cmd.Parameters.AddWithValue("@DI", DocID_Cbox.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DN", DocName_Tbox.Text);
                    cmd.Parameters.AddWithValue("@ApD", ApDate.Value.Date);
                    cmd.Parameters.AddWithValue("@ApT", ApTime.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@ApN", ApNote_Tbox.Text);
                    cmd.Parameters.AddWithValue("@ApKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment Updated");
                    Con.Close();
                    DisplayAppointment();
                    Clear();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please select an appointment to cancel.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE from ApTb1 where ApID = @ApKey", Con);
                    cmd.Parameters.AddWithValue("@ApKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment Cancel");
                    Con.Close();
                    DisplayAppointment();
                    Clear();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
