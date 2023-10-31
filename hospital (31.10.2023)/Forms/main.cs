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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospital
{
    public partial class main : Form
    {
        dataBase database = new dataBase();
        public main()
        {
            InitializeComponent();
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

        private void main_Load(object sender, EventArgs e)
        {
            patientsList();
        }

        private void patientsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand patientInfoCommand = new SqlCommand($"select * from [patients] where fullname = '" 
                    + Convert.ToString(patientsComboBox.SelectedItem) + "'", database.GetConnection());
                database.openConnection();
                SqlDataReader patientInfo = patientInfoCommand.ExecuteReader();
                while (patientInfo.Read())
                {
                    visiting visiting = new visiting();
                    prevVisitings prevVisitings = new prevVisitings(); 
                    visiting.ID_patient = Convert.ToInt32(patientInfo["ID_patient"]);
                    prevVisitings.ID_patient_current = Convert.ToInt32(patientInfo["ID_patient"]);
                    visiting.fullname = Convert.ToString(patientInfo["fullname"]);
                    visiting.birth = Convert.ToString(patientInfo["birthday"]).Remove(10);
                    prevVisitings.fullname = Convert.ToString(patientInfo["fullname"]);
                    prevVisitings.birth = Convert.ToString(patientInfo["birthday"]).Remove(10);
                    birthdayTextBox.Text = Convert.ToString(patientInfo["birthday"]).Remove(10);
                    passportTextBox.Text = Convert.ToString(patientInfo["passport"]);
                    insurNumTextBox.Text = Convert.ToString(patientInfo["insur_num"]);
                    insurPolicyTextBox.Text = Convert.ToString(patientInfo["insur_policy"]);
                    registrationTextBox.Text = Convert.ToString(patientInfo["registration"]);
                    resPlaceTextBox.Text = Convert.ToString(patientInfo["res_place"]);
                    companyTextBox.Text = Convert.ToString(patientInfo["job_company"]);
                    postTextBox.Text = Convert.ToString(patientInfo["post"]);
                    telNumTextBox.Text = Convert.ToString(patientInfo["tel_num"]);
                    if (Convert.ToString(patientInfo["disability"]) == "")
                    disabTextBox.Text = "-";
                    else disabTextBox.Text = Convert.ToString(patientInfo["disability"]);
                    if (Convert.ToString(patientInfo["benefits_code"]) == "")
                    benCodeTextBox.Text = "-";
                    else benCodeTextBox.Text = Convert.ToString(patientInfo["benefits_code"]);
                    cardTextBox.Text = Convert.ToString(patientInfo["card_num"]);
                }
                patientInfo.Close();
                database.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void persButton_Click(object sender, EventArgs e)
        {
            this.Close();
            personal personal = new personal();
            personal.Show();

        }

        public void patientsList()
        {
            patientsComboBox.Items.Clear();

            SqlCommand patientsCommand = new SqlCommand($"select * from [patients]", database.GetConnection());

            try
            {
                database.openConnection();
                SqlDataReader patients = patientsCommand.ExecuteReader();
                while (patients.Read())
                {
                    patientsComboBox.Items.Add(patients["fullname"]);
                }
                patients.Close();
                database.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void visitButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(patientsComboBox.Text) == "") MessageBox.Show("Пожалуйста, выберите пациента.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                this.Close();
                visiting visiting = new visiting();
                visiting.Show();
            }
        }

        private void prevVisitsButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(patientsComboBox.Text) == "") MessageBox.Show("Пожалуйста, выберите пациента.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                this.Close();
                prevVisitings prevVisitings = new prevVisitings();
                prevVisitings.Show();
            }
        }

        private void fullnameSTextBox_TextChanged(object sender, EventArgs e)
        {
            patientsComboBox.Items.Clear();

            SqlCommand patientsCommand = new SqlCommand();

            if (telSTextBox.Text != "") 
            {
                patientsCommand = new SqlCommand($"select * from [patients] where fullname like '%"
                    + fullnameSTextBox.Text + "%' and tel_num like '%"
                + telSTextBox.Text + "%'", database.GetConnection());
            }
            else
            {
                patientsCommand = new SqlCommand($"select * from [patients] where fullname like '%"
                    + fullnameSTextBox.Text + "%'", database.GetConnection());
            }
            try
            {
                database.openConnection();
                SqlDataReader patients = patientsCommand.ExecuteReader();
                while (patients.Read())
                {
                    patientsComboBox.Items.Add(patients["fullname"]);
                }
                patients.Close();
                database.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
        }

        private void telSTextBox_TextChanged(object sender, EventArgs e)
        {
            patientsComboBox.Items.Clear();

            SqlCommand patientsCommand = new SqlCommand();

            if (fullnameSTextBox.Text != "")
            {
                patientsCommand = new SqlCommand($"select * from [patients] where fullname like '%"
                    + fullnameSTextBox.Text + "%' and tel_num like '%"
                + telSTextBox.Text + "%'", database.GetConnection());
            }
            else
            {
                patientsCommand = new SqlCommand($"select * from [patients] where tel_num like '%"
                + telSTextBox.Text + "%'", database.GetConnection());
            }
            try
            {
                database.openConnection();
                SqlDataReader patients = patientsCommand.ExecuteReader();
                while (patients.Read())
                {
                    patientsComboBox.Items.Add(patients["fullname"]);
                }
                patients.Close();
                database.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
