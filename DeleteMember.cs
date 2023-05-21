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
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы уверены, что хотите удалить пользователя?", "Удалить данные", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = network\\SQLEXPRESS; database = gym; integrated security =  true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewMember where MID = " + txtDelete.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);

                DataSet DS = new DataSet();
                DA.Fill(DS);
            } else
            {
                this.Activate();
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

        private void DeleteMember_Load(object sender, EventArgs e)
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
