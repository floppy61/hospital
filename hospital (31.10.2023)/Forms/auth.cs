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

namespace hospital
{
    public partial class auth : Form
    {
        dataBase database = new dataBase();
        public auth()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordTextBox.Text;

            SqlDataAdapter adapterDoc = new SqlDataAdapter();
            DataTable tableDoc = new DataTable();

            SqlDataAdapter adapterAdmReg = new SqlDataAdapter();
            DataTable tableAdmReg = new DataTable();

            string loginStringDoc = $"select * from doctors where login = '{login}' and password = '{password}'";
            string loginStringAdmReg = $"select * from adm_reg where login = '{login}' and password = '{password}'";

            SqlCommand commandDoc = new SqlCommand(loginStringDoc, database.GetConnection());
            SqlCommand commandAdmReg = new SqlCommand(loginStringAdmReg, database.GetConnection());

            try
            {
                adapterDoc.SelectCommand = commandDoc;
                adapterDoc.Fill(tableDoc);

                adapterAdmReg.SelectCommand = commandAdmReg;
                adapterAdmReg.Fill(tableAdmReg);

                if (tableDoc.Rows.Count == 1)
                {
                    main main = new main();
                    this.Hide();
                    main.Show();
                    personal.ID_doctor = Convert.ToInt32(tableDoc.Rows[0].ItemArray[0]);
                    visiting.ID_doctor = Convert.ToInt32(tableDoc.Rows[0].ItemArray[0]);
                    visiting.doc_fullname = Convert.ToString(tableDoc.Rows[0].ItemArray[1]);
                    prevVisitings.doc_fullname = Convert.ToString(tableDoc.Rows[0].ItemArray[1]);
                }
                else if (tableAdmReg.Rows.Count == 1)
                {
                    if (Convert.ToString(tableAdmReg.Rows[0].ItemArray[9]) == "admin")
                    {
                        MessageBox.Show("Вы авторизовались как администратор.", "Успешная авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        admin admin = new admin();
                        this.Hide();
                        admin.Show();
                    }
                    else if (Convert.ToString(tableAdmReg.Rows[0].ItemArray[9]) == "reg")
                    {
                        MessageBox.Show("Вы авторизовались как регистратор.", "Успешная авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reg reg = new reg();
                        this.Hide();
                        reg.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            loginTextBox.Text = null;
            passwordTextBox.Text = null;
        }

        private void seeButton_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTextBox.PasswordChar = '\0';
        }

        private void seeButton_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
        }

        private void auth_Load(object sender, EventArgs e)
        {
            helloLabel.Parent = gifPictureBox;
            helloLabel.BackColor = Color.Transparent;
        }
    }
}
