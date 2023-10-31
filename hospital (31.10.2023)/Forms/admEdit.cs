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
    public partial class admEdit : Form
    {
        int selectedRow;
        public static int ID_admin;
        dataBase database = new dataBase();
        public admEdit()
        {
            InitializeComponent();
        }

        private void admEdit_Load(object sender, EventArgs e)
        {
            this.adm_regTableAdapter.Fill(this.medinstAdmRegDataSet.adm_reg);

            admRegBindingNavigator.BindingSource = admregBindingSource;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            admin admin = new admin();
            admin.Show();
        }

        private void admRegDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
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
            this.adm_regTableAdapter.Update(this.medinstAdmRegDataSet.adm_reg);
            this.adm_regTableAdapter.Fill(this.medinstAdmRegDataSet.adm_reg);
        }
        public void Clean()
        {
            fullnameTextBox.Text = null;
            birthdayPicker.Value = DateTime.Now;
            telNumTextBox.Text = null;
            passportTextBox.Text = null;
            insurNumTextBox.Text = null;
            insurPolicyTextBox.Text = null;
            loginTextBox.Text = null;
            passwordTextBox.Text = null;
            typeComboBox.SelectedItem = null;
        }
        private void fullnameSTextBox_TextChanged(object sender, EventArgs e)
        {
            Clean();
            admregBindingSource.Filter = $"fullname LIKE '%{fullnameSTextBox.Text}%'";
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            fullnameSTextBox.Text = null;
            Clean();
            Update();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand updateCommand = new SqlCommand("UPDATE [adm_reg] SET fullname = '" + fullnameTextBox.Text + "', birthday = '" + birthdayPicker.Value
                    + "', tel_num = '" + telNumTextBox.Text + "', passport = '" + passportTextBox.Text + "', insur_num = '" + insurNumTextBox.Text +
                    "', insur_policy = '" + insurPolicyTextBox.Text + "', login = '" + loginTextBox.Text + "', password = '" + passwordTextBox.Text +
                   "', acc_type = '" + typeComboBox.SelectedItem + "' WHERE ID_admin = '" + ID_admin + "'", database.GetConnection());
                database.openConnection();
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("Выбранная учётная запись была обновлена!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                database.closeConnection();
                Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void admRegDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = admRegDataGridView.Rows[selectedRow];
                ID_admin = Convert.ToInt32(row.Cells[0].Value);
                fullnameTextBox.Text = row.Cells[1].Value.ToString();
                birthdayPicker.Value = Convert.ToDateTime(row.Cells[2].Value);
                telNumTextBox.Text = row.Cells[3].Value.ToString();
                passportTextBox.Text = row.Cells[4].Value.ToString();
                insurNumTextBox.Text = row.Cells[5].Value.ToString();
                insurPolicyTextBox.Text = row.Cells[6].Value.ToString();
                loginTextBox.Text = row.Cells[7].Value.ToString();
                passwordTextBox.Text = row.Cells[8].Value.ToString();
                typeComboBox.SelectedItem = row.Cells[9].Value.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данную учётную запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM [adm_reg] WHERE ID_admin = '" + ID_admin + "'", database.GetConnection());
                    database.openConnection();
                    deleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Выбранная учётная запись была удалена!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
