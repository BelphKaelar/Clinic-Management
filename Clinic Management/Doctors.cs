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
    public partial class Doctors : Form
    {
        int key = 0;
        public Doctors()
        {
            InitializeComponent();
            DisplayDoc();
            docGridView1.ClearSelection();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMINS\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayDoc()
        {
            //Con.Open(); //This shit was not needed lol //Connection started here somewhere
            string Query = "Select * from DoctorTb1";
            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            docGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            DocAdd_TBox.Text = "";
            DocExp_TBox.Text = "";
            DocName_TBox.Text = "";
            DocGen_Cbox.SelectedIndex = 0;
            DocSpec_CBox.SelectedIndex = 0;
            DocPhone_TBox.Text = "";
            key = 0;
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            if(DocName_TBox.Text == "" || DocPhone_TBox.Text == "" || DocSpec_CBox.SelectedIndex == -1
                || DocGen_Cbox.SelectedIndex == -1 || DocExp_TBox.Text == "" || DocAdd_TBox.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DoctorTb1(DocName, DocDOB, DocGen, DocSpec, DocExp, DocPhone, DocAdd)values(@DN,@DD,@DG,@DS,@DE,@DP,@DA)",Con);
                    cmd.Parameters.AddWithValue("@DN", DocName_TBox.Text);
                    cmd.Parameters.AddWithValue("@DD", DocBirth_DOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DG", DocGen_Cbox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DS", DocSpec_CBox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DocExp_TBox.Text);
                    cmd.Parameters.AddWithValue("@DP", DocPhone_TBox.Text);
                    cmd.Parameters.AddWithValue("@DA", DocAdd_TBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Added");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch(Exception Ex) {MessageBox.Show(Ex.Message); }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void docGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the row index of the clicked cell
            int rowIndex = e.RowIndex;

            // Check if the row is selected
            if (rowIndex >= 0 && docGridView1.SelectedRows.Count > 0)
            {
                // Row is selected
                DocName_TBox.Text = docGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DocBirth_DOB.Text = docGridView1.SelectedRows[0].Cells[2].Value.ToString();
                DocGen_Cbox.SelectedItem = docGridView1.SelectedRows[0].Cells[3].Value.ToString();
                DocSpec_CBox.SelectedItem = docGridView1.SelectedRows[0].Cells[4].Value.ToString();
                DocExp_TBox.Text = docGridView1.SelectedRows[0].Cells[5].Value.ToString();
                DocPhone_TBox.Text = docGridView1.SelectedRows[0].Cells[6].Value.ToString();
                DocAdd_TBox.Text = docGridView1.SelectedRows[0].Cells[7].Value.ToString();

                // Set the key based on the value in the first cell
                if (DocName_TBox.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(docGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            else{MessageBox.Show("Please select a row before you can access its information.");}
        }


        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            if (DocName_TBox.Text == "" || DocPhone_TBox.Text == "" || DocSpec_CBox.SelectedIndex == -1
                || DocGen_Cbox.SelectedIndex == -1 || DocExp_TBox.Text == "" || DocAdd_TBox.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update DoctorTb1 set DocName=@DN, DocDOB=@DD, DocGen=@DG, DocSpec=@DS, DocExp=@DE, DocPhone=@DP, DocAdd=@DA where DocID=@DKey", Con);
                    cmd.Parameters.AddWithValue("@DN", DocName_TBox.Text);
                    cmd.Parameters.AddWithValue("@DD", DocBirth_DOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DG", DocGen_Cbox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DS", DocSpec_CBox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DocExp_TBox.Text);
                    cmd.Parameters.AddWithValue("@DP", DocPhone_TBox.Text);
                    cmd.Parameters.AddWithValue("@DA", DocAdd_TBox.Text);
                    cmd.Parameters.AddWithValue("@DKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Edited");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }
        }

        private void Del_Btn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please select a doctor to delete.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from DoctorTb1 where DocID = @DKey", Con);
                    cmd.Parameters.AddWithValue("@DKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Deleted");
                    Con.Close();
                    DisplayDoc();
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

        private void label5_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
