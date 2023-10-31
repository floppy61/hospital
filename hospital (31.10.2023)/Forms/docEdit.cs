using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace hospital
{
    public partial class docEdit : Form
    {
        int selectedRow;
        public static int ID_doctor;
        dataBase database = new dataBase();
        public docEdit()
        {
            InitializeComponent();
        }

        private void docEdit_Load(object sender, EventArgs e)
        {

            this.doctorsTableAdapter.Fill(this.medinstDocDataSet.doctors);
            doctorsBindingNavigator.BindingSource = doctorsBindingSource;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            admin admin = new admin();
            admin.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            fullnameSTextBox.Text = null;
            Clean();
            Update();
        }

        private void lineEditButton_Click(object sender, EventArgs e)
        {
            this.Close();
            doctorAdd dAdd = new doctorAdd();
            dAdd.Show();
        }

        private void doctorsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
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

        private void doctorsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = doctorsDataGridView.Rows[selectedRow];
                ID_doctor = Convert.ToInt32(row.Cells[0].Value);
                fullnameTextBox.Text = row.Cells[1].Value.ToString();
                birthdayPicker.Value = Convert.ToDateTime(row.Cells[2].Value);
                specTextBox.Text = row.Cells[3].Value.ToString();
                postTextBox.Text = row.Cells[4].Value.ToString();
                cabNumTextBox.Text = row.Cells[5].Value.ToString();
                telNumTextBox.Text = row.Cells[6].Value.ToString();
                passportTextBox.Text = row.Cells[7].Value.ToString();
                insurNumTextBox.Text = row.Cells[8].Value.ToString();
                insurPolicyTextBox.Text = row.Cells[9].Value.ToString();
                loginTextBox.Text = row.Cells[10].Value.ToString();
                passwordTextBox.Text = row.Cells[11].Value.ToString();
                photoTextBox.Text = row.Cells[12].Value.ToString();
            }
        }
        public new void Update()
        {
            this.doctorsTableAdapter.Update(this.medinstDocDataSet.doctors);
            this.doctorsTableAdapter.Fill(this.medinstDocDataSet.doctors);
        }
        public void Clean()
        {
            fullnameTextBox.Text = null;
            birthdayPicker.Value = DateTime.Now;
            specTextBox.Text = null;
            postTextBox.Text = null;
            cabNumTextBox.Text = null;
            telNumTextBox.Text = null;
            passportTextBox.Text = null;
            insurNumTextBox.Text = null;
            insurPolicyTextBox.Text = null;
            loginTextBox.Text = null;
            passwordTextBox.Text = null;
            photoTextBox.Text = null;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данную учётную запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM [doctors] WHERE ID_doctor = '" + ID_doctor + "'", database.GetConnection());
                    database.openConnection();
                    deleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Выбранная учётная запись доктора была удалена!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand updateCommand = new SqlCommand("UPDATE [doctors] SET fullname = '" + fullnameTextBox.Text + "', birthday = '" + birthdayPicker.Value 
                    + "', specialization = '" + specTextBox.Text + "', post = '" + postTextBox.Text + "', cab_num = '" + cabNumTextBox.Text + 
                    "', tel_num = '" + telNumTextBox.Text + "', passport = '" + passportTextBox.Text + "', insur_num = '" + insurNumTextBox.Text +
                    "', insur_policy = '" + insurPolicyTextBox.Text + "', login = '" + loginTextBox.Text + "', password = '" + passwordTextBox.Text +
                    "', photo = '" + photoTextBox.Text + "' WHERE ID_doctor = '" + ID_doctor + "'", database.GetConnection());
                database.openConnection();
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("Выбранная учётная запись доктора была обновлена!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                database.closeConnection();
                Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fullnameSTextBox_TextChanged(object sender, EventArgs e)
        {
            Clean();
            doctorsBindingSource.Filter = $"fullname LIKE '%{fullnameSTextBox.Text}%'";
        }

        //int rowIndex = doctorsBindingSource.Find("ID_doctor", fullnameSTextBox.Text);
        //doctorsDataGridView.Rows[rowIndex].Selected = true; 
    }
}

