using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Fitnes
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String EquipName = txtEqName.Text;
            String EDescription = txtDescr.Text;
            String MUsed = txtMusclesUsed.Text;
            String DDAte = dateTimeDate.Text;
            Int64 Cost = Int64.Parse(txtGost.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = network\\SQLEXPRESS; database = gym; integrated security =  true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Equipment (EquipName,EDescription,MUsed,DDate,Cost) values ('" + EquipName + "', '" + EDescription + "', '" + MUsed + "', '" + DDAte + "', " + Cost + ")";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Данные сохранены!");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEqName.Clear();
            txtDescr.Clear();
            txtMusclesUsed.Clear();
            txtGost.Clear();
            dateTimeDate.Value = DateTime.Now;
        }
    }
}
