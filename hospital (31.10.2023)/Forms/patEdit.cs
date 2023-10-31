using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
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

    public partial class patEdit : Form
    {
        int selectedRow;
        public static int ID_patient;
        dataBase database = new dataBase();
        public patEdit()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            reg reg = new reg();
            reg.Show();
        }

        private void patEdit_Load(object sender, EventArgs e)
        {

            this.patientsTableAdapter.Fill(this.medinstPatDataSet.patients);

            patientsBindingNavigator.BindingSource = patientsBindingSource;
        }

        private void lineEditButton_Click(object sender, EventArgs e)
        {
            this.Close();
            patientAdd pAdd = new patientAdd();
            pAdd.Show();
        }

        private void patientsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Произошла ошибка... (" + e.Context.ToString() + ")\nДля попытки вернуться назад нажмите Escape.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Ошибка.\nВведённые данные не могут быть сохранены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Ошибка.\nСмена ячейки при неверно введённых ранее данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("Ошибка анализа новых данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("Ошибка. Не удалось зафиксировать изменения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if ((e.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[e.RowIndex].ErrorText = "Ошибка"; view.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Ошибка";
                e.ThrowException = false;
            }
        }

        public new void Update()
        {
            this.patientsTableAdapter.Update(this.medinstPatDataSet.patients);
            this.patientsTableAdapter.Fill(this.medinstPatDataSet.patients);
        }
        public void Clean()
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

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            fullnameSTextBox.Text = null;
            Clean();
            Update();
        }

        private void fullnameSTextBox_TextChanged(object sender, EventArgs e)
        {
            Clean();
            patientsBindingSource.Filter = $"fullname LIKE '%{fullnameSTextBox.Text}%'";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand updateCommand = new SqlCommand("UPDATE [patients] SET fullname = '" + fullnameTextBox.Text + "', birthday = '" + birthdayPicker.Value
                    + "', passport = '" + passportTextBox.Text + "', insur_num = '" + insurNumTextBox.Text + "', insur_policy = '" + insurPolicyTextBox.Text 
                    + "', registration = '" + registrationTextBox.Text + "', res_place = '" + resPlaceTextBox.Text + "', job_company = '" + companyTextBox.Text 
                    + "', post = '" + postTextBox.Text + "', tel_num = '" + telNumTextBox.Text + "', disability = '" + disabTextBox.Text
                    + "', benefits_code = '" + benCodeTextBox.Text + "', card_num = '" + cardTextBox.Text + "' WHERE ID_patient = '" + ID_patient + "'", database.GetConnection());
                database.openConnection();
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("Выбранная запись была обновлена!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                database.closeConnection();
                Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void patientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = patientsDataGridView.Rows[selectedRow];
                ID_patient = Convert.ToInt32(row.Cells[0].Value);
                fullnameTextBox.Text = row.Cells[1].Value.ToString();
                birthdayPicker.Value = Convert.ToDateTime(row.Cells[2].Value);
                passportTextBox.Text = row.Cells[3].Value.ToString();
                insurNumTextBox.Text = row.Cells[4].Value.ToString();
                insurPolicyTextBox.Text = row.Cells[5].Value.ToString();
                registrationTextBox.Text = row.Cells[6].Value.ToString();
                resPlaceTextBox.Text = row.Cells[7].Value.ToString();
                companyTextBox.Text = row.Cells[8].Value.ToString();
                postTextBox.Text = row.Cells[9].Value.ToString();
                telNumTextBox.Text = row.Cells[10].Value.ToString();
                disabTextBox.Text = row.Cells[11].Value.ToString();
                benCodeTextBox.Text = row.Cells[12].Value.ToString();
                cardTextBox.Text = row.Cells[13].Value.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данную запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM [patients] WHERE ID_patient = '" + ID_patient + "'", database.GetConnection());
                    database.openConnection();
                    deleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Выбранная запись была удалена!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    database.closeConnection();
                    Clean();
                    Update();
                }
                catch (Exception)
                {
                    MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
