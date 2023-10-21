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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            if (Login.Role == "Doctor")
            {
                Pa_Lb.Enabled = true;
                Doc_Lb.Enabled = false;
                Presc_Lb.Enabled = true;
                Appoint_Lb.Enabled = true;
            }
            DisplayPa();
            PaGridView1.ClearSelection();
        }
        int key = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMINS\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayPa()
        {
            string Query = "Select * from PatientTb1";
            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            PaGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            PaAdd_Tbox.Text = "";
            PaDiagnosis_Tbox.Text = "";
            PaAdd_Tbox.Text = "";
            PaGen_Cbox.Text = "";
            PaAdd_Tbox.Text = "";
            PaSymptoms_Tbox.Text = "";
            PaNote_Tbox.Text = "";
            key = 0;
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            if (PaName_Tbox.Text == "" || PaPhone_Tbox.Text == "" || PaGen_Cbox.SelectedIndex == -1
                && PaAdd_Tbox.Text == "" || PaSymptoms_Tbox.Text == "" || PaDiagnosis_Tbox.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PatientTb1(PaName, PaGen, PaDOB, PaAdd, PaPhone, PaDiagnosis, PaSymptoms, PaNote)values(@PN,@PG,@PDOB,@PA,@PP,@PD,@PS,@PNote)", Con);
                    cmd.Parameters.AddWithValue("@PN", PaName_Tbox.Text);
                    cmd.Parameters.AddWithValue("@PG", PaGen_Cbox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PDOB", PaBirth_DOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PA", PaAdd_Tbox.Text);
                    cmd.Parameters.AddWithValue("@PP", PaPhone_Tbox.Text);
                    cmd.Parameters.AddWithValue("@PD", PaDiagnosis_Tbox.Text);
                    cmd.Parameters.AddWithValue("@PS", PaSymptoms_Tbox.Text);
                    cmd.Parameters.AddWithValue("@PNote", PaNote_Tbox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Added");
                    Con.Close();
                    DisplayPa();
                    Clear();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PaGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PaGridView1.SelectedRows.Count > 0)
            {
                PaName_Tbox.Text = PaGridView1.SelectedRows[0].Cells[1].Value.ToString();
                PaGen_Cbox.SelectedItem = PaGridView1.SelectedRows[0].Cells[2].Value.ToString();
                PaBirth_DOB.Text = PaGridView1.SelectedRows[0].Cells[3].Value.ToString();
                PaAdd_Tbox.Text = PaGridView1.SelectedRows[0].Cells[4].Value.ToString();
                PaPhone_Tbox.Text = PaGridView1.SelectedRows[0].Cells[5].Value.ToString();
                PaDiagnosis_Tbox.Text = PaGridView1.SelectedRows[0].Cells[6].Value.ToString();
                PaSymptoms_Tbox.Text = PaGridView1.SelectedRows[0].Cells[7].Value.ToString();
                PaNote_Tbox.Text = PaGridView1.SelectedRows[0].Cells[8].Value.ToString();
                if (PaName_Tbox.Text == "") { key = 0; }
                else { key = Convert.ToInt32(PaGridView1.SelectedRows[0].Cells[0].Value.ToString()); }
            }
            else { MessageBox.Show("Please select a row before you can access its information."); }
        }

        private void Del_Btn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please select a patient to delete.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE from PatientTb1 where PaID = @PaKey", Con);
                    cmd.Parameters.AddWithValue("@PaKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Deleted");
                    Con.Close();
                    DisplayPa();
                    Clear();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            if (PaName_Tbox.Text == "" || PaPhone_Tbox.Text == "" || PaGen_Cbox.SelectedIndex == -1
                && PaAdd_Tbox.Text == "" || PaSymptoms_Tbox.Text == "" || PaDiagnosis_Tbox.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE PatientTb1 SET PaName = @PN, PaGen = @PG, PaDOB = @PDOB, PaAdd = @PA, PaPhone = @PP, PaDiagnosis = @PD, PaSymptoms = @PS, PaNote = @PNote WHERE PaID = @PaKey", Con); 
                    cmd.Parameters.AddWithValue("@PN", PaName_Tbox.Text);
                    cmd.Parameters.AddWithValue("@PG", PaGen_Cbox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PDOB", PaBirth_DOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PA", PaAdd_Tbox.Text);
                    cmd.Parameters.AddWithValue("@PP", PaPhone_Tbox.Text);
                    cmd.Parameters.AddWithValue("@PD", PaDiagnosis_Tbox.Text);
                    cmd.Parameters.AddWithValue("@PS", PaSymptoms_Tbox.Text);
                    cmd.Parameters.AddWithValue("@PNote", PaNote_Tbox.Text);
                    cmd.Parameters.AddWithValue("@PaKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Edited");
                    Con.Close();
                    DisplayPa();
                    Clear();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }
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
