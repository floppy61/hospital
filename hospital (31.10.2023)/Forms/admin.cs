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
using Microsoft.Office.Interop.Excel;

namespace hospital
{
    public partial class admin : Form
    {
        dataBase database = new dataBase();
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход из учётной записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
                auth auth = new auth();
                auth.Show();
            }
        }

        private void adminsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            admEdit admEdit = new admEdit();
            admEdit.Show();
        }

        private void doctorsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            docEdit docEdit = new docEdit();
            docEdit.Show();
        }

        private void catOfDisButton_Click(object sender, EventArgs e)
        {
            this.Close();
            disEdit disEdit = new disEdit();
            disEdit.Show();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
        }
    }
}
