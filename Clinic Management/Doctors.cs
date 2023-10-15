﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinic_Management
{
    public partial class Doctors : Form
    {
        int key = 0;
        public Doctors()
        {
            InitializeComponent();
            DisplayDoc(); 
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
            DocSpec_CBox.SelectedIndex = 0;
            DocPhone_TBox.Text = "";
            key = 0;
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            if(DocName_TBox.Text == "" && DocPhone_TBox.Text == "" && DocSpec_CBox.SelectedIndex == -1
                && DocGen1.Checked == false && DocGen2.Checked == false && DocExp_TBox.Text == "" && DocAdd_TBox.Text == "")
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
                    if (DocGen1.Checked) { cmd.Parameters.AddWithValue("@DG", DocGen1.Checked.ToString()); }
                    else { cmd.Parameters.AddWithValue("@DG", DocGen2.Checked.ToString()); }
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

        private void docGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocName_TBox.Text = docGridView1.SelectedRows[0].Cells[1].Value.ToString();
            DocBirth_DOB.Text = docGridView1.SelectedRows[0].Cells[2].Value.ToString();
            if(DocGen1 != null) { DocGen1.Checked = Convert.ToBoolean(docGridView1.SelectedRows[0].Cells[3].Value.ToString()); }
            else { DocGen2.Checked = Convert.ToBoolean(docGridView1.SelectedRows[0].Cells[3].Value.ToString()); }
            DocSpec_CBox.SelectedItem = docGridView1.SelectedRows[0].Cells[4].Value.ToString();
            DocExp_TBox.Text = docGridView1.SelectedRows[0].Cells[5].Value.ToString();
            DocPhone_TBox.Text = docGridView1.SelectedRows[0].Cells[6].Value.ToString();
            DocAdd_TBox.Text = docGridView1.SelectedRows[0].Cells[7].Value.ToString();

            if (DocName_TBox.Text == "") { key = 0; }
            else { key = Convert.ToInt32(docGridView1.SelectedRows[0].Cells[0].Value.ToString()); }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            if (DocName_TBox.Text == "" && DocPhone_TBox.Text == "" && DocSpec_CBox.SelectedIndex == -1
                && DocGen1.Checked == false && DocGen2.Checked == false && DocExp_TBox.Text == "" && DocAdd_TBox.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update DoctorTb1 set DocName=@DN, DocDOB=@DD, DocGen=@DG, DocSpec=@DS, DocExp=@DE, DocPhone=@DP, DocAdd=@DA where DocID=@DKey)", Con);
                    cmd.Parameters.AddWithValue("@DN", DocName_TBox.Text);
                    cmd.Parameters.AddWithValue("@DD", DocBirth_DOB.Value.Date);
                    if (DocGen1.Checked) { cmd.Parameters.AddWithValue("@DG", DocGen1.Checked.ToString()); }
                    else { cmd.Parameters.AddWithValue("@DG", DocGen2.Checked.ToString()); }
                    cmd.Parameters.AddWithValue("@DS", DocSpec_CBox.SelectedIndex.ToString());
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
    }
}
