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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Connection string for database if needed
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMINS\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string Role;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Role_Cbox.SelectedIndex == -1) { MessageBox.Show("Please select your position"); }
            else if (Role_Cbox.SelectedIndex == 0)
            {
                if (User_Tbox.Text == "" || Pass_Tbox.Text == "") { MessageBox.Show("Your username or password is missing."); }
                else if(User_Tbox.Text == "admin" ||  Pass_Tbox.Text == "123")
                {
                    Role = "Admin"; 
                    Patients obj = new Patients();
                    obj.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Wrong admin username and password"); }
            }
            else if(Role_Cbox.SelectedIndex == 1)
            {
                if (User_Tbox.Text == "" || Pass_Tbox.Text == "") { MessageBox.Show("Your username or password is missing."); }
                //Haven't created a database for user yet //Same method for GridView
                else if(User_Tbox.Text=="doc"|| Pass_Tbox.Text=="123")
                {
                    Role = "Doctor";
                    Prescriptions obj = new Prescriptions();
                    obj.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Wrong doctor username and password"); }
            }
        }
    }
}
