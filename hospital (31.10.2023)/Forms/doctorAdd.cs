using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospital
{
    public partial class doctorAdd : Form
    {
        dataBase database = new dataBase();
        public doctorAdd()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            docEdit docEdit = new docEdit();
            docEdit.Show();
        }

        private void seeButton_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTextBox.PasswordChar = '\0';
        }

        private void seeButton_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            fullnameTextBox.Text = null;
            birthdayPicker.Value = DateTime.Now;
            passportTextBox.Text = null;
            insurNumTextBox.Text = null;
            insurPolicyTextBox.Text = null;
            postTextBox.Text = null;
            telNumTextBox.Text = null;
            loginTextBox.Text = null;
            passwordTextBox.Text = null;
            specTextBox.Text = null;
            cabNumTextBox.Text = null;
            photoTextBox.Text = null;
            photoPictureBox.ImageLocation = null;
        }

        private void doctorAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand newDoctorCommand = new SqlCommand("INSERT INTO [doctors] (fullname, birthday, specialization, post, cab_num, " +
                    "tel_num, passport, insur_num, insur_policy, login, password, photo) Values(@fullname, @birthday, @specialization, @post, " +
                    "@cab_num, @tel_num, @passport, @insur_num, @insur_policy, @login, @password, @photo)", database.GetConnection());
                newDoctorCommand.Parameters.AddWithValue("fullname", fullnameTextBox.Text);
                newDoctorCommand.Parameters.AddWithValue("birthday", birthdayPicker.Value);
                newDoctorCommand.Parameters.AddWithValue("specialization", specTextBox.Text);
                newDoctorCommand.Parameters.AddWithValue("post", postTextBox.Text);
                newDoctorCommand.Parameters.AddWithValue("cab_num", cabNumTextBox.Text);
                newDoctorCommand.Parameters.AddWithValue("tel_num", telNumTextBox.Text);
                newDoctorCommand.Parameters.AddWithValue("passport", passportTextBox.Text);
                newDoctorCommand.Parameters.AddWithValue("insur_num", insurNumTextBox.Text);
                newDoctorCommand.Parameters.AddWithValue("insur_policy", insurPolicyTextBox.Text);
                newDoctorCommand.Parameters.AddWithValue("login", loginTextBox.Text);
                newDoctorCommand.Parameters.AddWithValue("password", passwordTextBox.Text);
                newDoctorCommand.Parameters.AddWithValue("photo", photoTextBox.Text);
                database.openConnection();
                newDoctorCommand.ExecuteNonQuery();
                MessageBox.Show("Создана новая учётная запись доктора.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                database.closeConnection();
                this.Close();
                docEdit dEdit = new docEdit();
                dEdit.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "")
            {
                MessageBox.Show("Для корректного сохранения фото сначала введите логин пользователя.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Фото |*.jpg;*.jpeg;*.png;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    photoTextBox.Text = @"photos\" + loginTextBox.Text + Path.GetExtension(openFileDialog.FileName);
                    if (!File.Exists(photoTextBox.Text))
                    {
                        File.Copy(openFileDialog.FileName, photoTextBox.Text);
                    }
                    photoPictureBox.ImageLocation = photoTextBox.Text;
                }
            }
        }
    }
}
