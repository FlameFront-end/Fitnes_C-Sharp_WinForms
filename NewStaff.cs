using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fitnes
{
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String fname = txtFname.Text;
            String lname = txtLname.Text;

            String gender = "";

            bool isChecked = radioButton1.Checked;
            if (isChecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String joindate = dateTimePickerJOINDate.Text;
            String state = txtState.Text;
            String city = txtCity.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = network\\SQLEXPRESS; database = gym; integrated security =  true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewStaff (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Statee,City) values ('" + fname + "', '" + lname + "', '" + gender + "', '" + dob + "', " + mobile + ", '" + email + "', '" + joindate + "', '" + state + "', '" + city + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Данные сохранены!");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtMobile.Clear();

            radioButton2.Checked = false;
            radioButton2.Checked = false;

            txtMobile.Clear();
            txtEmail.Clear();


            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJOINDate.Value = DateTime.Now;
        }

        private void NewStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
