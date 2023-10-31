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
    public partial class personal : Form
    {
        dataBase database = new dataBase();
        public static int ID_doctor;
        public personal()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            main main = new main();
            main.Show();
        }

        private void unAuthButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход из учётной записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
                auth auth = new auth();
                auth.Show();
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand changePasswordCommand = new SqlCommand($"UPDATE [doctors] SET password = @password where ID_doctor = '" + ID_doctor + "'", database.GetConnection());
                changePasswordCommand.Parameters.AddWithValue("password", passwordTextBox.Text);
                database.openConnection();
                changePasswordCommand.ExecuteNonQuery();
                database.openConnection();
                MessageBox.Show("Был обновлён пароль вашей уч. записи.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void personal_Load(object sender, EventArgs e)
        {
            SqlCommand personalInfoCommand = new SqlCommand($"select * from [doctors] where ID_doctor = '"
                + ID_doctor + "'", database.GetConnection());
            try
            {
                database.openConnection();
                SqlDataReader personalInfo = personalInfoCommand.ExecuteReader();
                while (personalInfo.Read())
                {
                    fullnameTextBox.Text = Convert.ToString(personalInfo["fullname"]);
                    birthdayTextBox.Text = Convert.ToString(personalInfo["birthday"]).Remove(10);
                    passportTextBox.Text = Convert.ToString(personalInfo["passport"]);
                    insurNumTextBox.Text = Convert.ToString(personalInfo["insur_num"]);
                    insurPolicyTextBox.Text = Convert.ToString(personalInfo["insur_policy"]);
                    postTextBox.Text = Convert.ToString(personalInfo["post"]);
                    telNumTextBox.Text = Convert.ToString(personalInfo["tel_num"]);
                    loginTextBox.Text = Convert.ToString(personalInfo["login"]);
                    passwordTextBox.Text = Convert.ToString(personalInfo["password"]);
                    specTextBox.Text = Convert.ToString(personalInfo["specialization"]);
                    if (Convert.ToString(personalInfo["cab_num"]) == "")
                        cabNumTextBox.Text = "-";
                    else
                        cabNumTextBox.Text = Convert.ToString(personalInfo["cab_num"]);
                    photoPictureBox.ImageLocation = (string)personalInfo["photo"];
                }
                personalInfo.Close();
                database.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seeButton_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTextBox.PasswordChar = '\0';
        }

        private void seeButton_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }
    }
}
