using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace hospital
{
    public partial class reg : Form
    {
        dataBase database = new dataBase();
        Word._Application Word = new Word.Application();
        public reg()
        {
            InitializeComponent();
        }

        private void reg_Load(object sender, EventArgs e)
        {

            this.doctorsTableAdapter.Fill(this.doctorsHospitalDataSet.doctors);

            patientsList();

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
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void patientsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlCommand patientInfoCommand = new SqlCommand($"select * from [patients] where fullname = '" + Convert.ToString(patientsComboBox.SelectedItem) + "'", database.GetConnection());
            try
            {
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

                printButton.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string pathCoupon = Environment.CurrentDirectory + "\\templates\\coupon.docx";
            string pathTCoupon = Environment.CurrentDirectory + "\\temp_files\\" + couponTextBox.Text + ".docx";
            Word._Document Doc = Word.Documents.Add(pathCoupon);
            Word.Visible = true;
            Doc.Bookmarks["number"].Range.Text = couponTextBox.Text;
            Doc.Bookmarks["fullname"].Range.Text = patientsComboBox.Text;
            Doc.Bookmarks["doctor"].Range.Text = doctorsComboBox.Text;
            Doc.Bookmarks["date"].Range.Text = Convert.ToString(appDateTimePicker.Value).Remove(16);
            Doc.SaveAs(FileName: pathTCoupon);
            Doc.Close();

            Process.Start(pathTCoupon);
        }

        private void patientEditButton_Click(object sender, EventArgs e)
        {
            this.Close();
            patEdit patEdit = new patEdit();
            patEdit.Show();
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
    }
}
