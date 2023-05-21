using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitnes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember sm = new SearchMember();
            sm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                toolStripMenuItem1.Text = "⇓";
                b = false;
            } 
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                toolStripMenuItem1.Text = "⇒";
                b = true;
            }
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMember nm = new NewMember();
            nm.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStaff ns = new NewStaff();
            ns.Show();
        }

        private void equlpmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMember dm = new DeleteMember();
            dm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Выход из программы", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти из учётной записи?", "Выход из учётной записи", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Login lg = new Login();
                lg.Show();
                this.Close();
            }
        }
    }
}
