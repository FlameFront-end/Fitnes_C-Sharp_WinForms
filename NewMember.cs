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

namespace Fitnes
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String fname = txtFirstName.Text;
            String lname = Lname.Text;

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
            String joindate = dateTimePickerJoinDate.Text;
            String gymTinme = comboBoxGymTime.Text;
            String address = txtAddress.Text;
            String membership = comboBoxMembership.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = network\\SQLEXPRESS; database = gym; integrated security =  true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewMember (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Gymtime,Maddress,MembershipTime) values ('" + fname + "', '" + lname + "', '" + gender + "', '" + dob + "', " + mobile + ", '" + email + "', '" + joindate + "', '" + gymTinme + "', '" + address + "',  '" + membership + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Данные сохранены!");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            Lname.Clear();
            txtAddress.Clear();

            radioButton2.Checked = false;
            radioButton2.Checked = false;

            txtMobile.Clear();
            txtEmail.Clear();

            comboBoxGymTime.ResetText();
            comboBoxMembership.ResetText();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;
        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }
    }
}
