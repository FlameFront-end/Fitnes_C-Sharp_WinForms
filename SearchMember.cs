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

namespace Fitnes
{
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = network\\SQLEXPRESS; database = gym; integrated security =  true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewMember where MID = " + txtSearch.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);

                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите ID пользователя!");
            }
        }

        private void SearchMember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = network\\SQLEXPRESS; database = gym; integrated security =  true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewMember";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);

            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }
    }
}
