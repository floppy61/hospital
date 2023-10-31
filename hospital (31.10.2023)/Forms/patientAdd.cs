using Microsoft.Office.Interop.Excel;
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
    public partial class patientAdd : Form
    {
        dataBase database = new dataBase();
        public patientAdd()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
                this.Close();
                patEdit patEdit = new patEdit();
                patEdit.Show();
        }

        private void patientAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand newPatientCommand = new SqlCommand("INSERT INTO [patients] (fullname, birthday, passport, insur_num, insur_policy, " +
                    "registration, res_place, job_company, post, tel_num, disability, benefits_code, card_num) Values(@fullname, @birthday, @passport, " +
                    "@insur_num, @insur_policy, @registration, @res_place, @job_company, @post, @tel_num, @disability, @benefits_code, @card_num)", database.GetConnection());
                newPatientCommand.Parameters.AddWithValue("fullname", fullnameTextBox.Text);
                newPatientCommand.Parameters.AddWithValue("birthday", birthdayPicker.Value);
                newPatientCommand.Parameters.AddWithValue("passport", passportTextBox.Text);
                newPatientCommand.Parameters.AddWithValue("insur_num", insurNumTextBox.Text);
                newPatientCommand.Parameters.AddWithValue("insur_policy", insurPolicyTextBox.Text);
                newPatientCommand.Parameters.AddWithValue("registration", registrationTextBox.Text);
                newPatientCommand.Parameters.AddWithValue("res_place", resPlaceTextBox.Text);
                newPatientCommand.Parameters.AddWithValue("job_company", companyTextBox.Text);
                newPatientCommand.Parameters.AddWithValue("post", postTextBox.Text);
                newPatientCommand.Parameters.AddWithValue("tel_num", telNumTextBox.Text);
                newPatientCommand.Parameters.AddWithValue("disability", disabTextBox.Text);
                newPatientCommand.Parameters.AddWithValue("benefits_code", benCodeTextBox.Text);
                newPatientCommand.Parameters.AddWithValue("card_num", cardTextBox.Text);
                database.openConnection();
                newPatientCommand.ExecuteNonQuery();
                MessageBox.Show("Добавлена информация о новом пациенте", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                database.closeConnection();
                this.Close();
                patEdit pEdit = new patEdit();
                pEdit.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            fullnameTextBox.Text = null;
            birthdayPicker.Value = DateTime.Now;
            passportTextBox.Text = null;
            insurNumTextBox.Text = null;
            insurPolicyTextBox.Text = null;
            registrationTextBox.Text = null;
            resPlaceTextBox.Text = null;
            companyTextBox.Text = null;
            postTextBox.Text = null;
            telNumTextBox.Text = null;
            disabTextBox.Text = null;
            benCodeTextBox.Text = null;
            cardTextBox.Text = null;
        }
    }
}
