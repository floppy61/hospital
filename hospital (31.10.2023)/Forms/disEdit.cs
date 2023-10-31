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
    public partial class disEdit : Form
    {
        int selectedRow;
        public static int ID_category;
        dataBase database = new dataBase();
        public disEdit()
        {
            InitializeComponent();
        }

        private void disEdit_Load(object sender, EventArgs e)
        {
            this.cat_of_disTableAdapter.Fill(this.medinstCatDisDataSet.cat_of_dis);
            catDisBindingNavigator.BindingSource = catofdisBindingSource;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            admin admin = new admin();
            admin.Show();
        }

        private void catDisDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
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
            this.cat_of_disTableAdapter.Update(this.medinstCatDisDataSet.cat_of_dis);
            this.cat_of_disTableAdapter.Fill(this.medinstCatDisDataSet.cat_of_dis);
        }
        public void Clean()
        {
            categoryTextBox.Text = null;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            categorySTextBox.Text = null;
            Clean();
            Update();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand updateCommand = new SqlCommand("UPDATE [cat_of_dis] SET category = '" + categoryTextBox.Text + "' WHERE ID_category = '" + ID_category + "'", database.GetConnection());
                database.openConnection();
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("Выбранная категория была обновлена!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                database.closeConnection();
                Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void catDisDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = catDisDataGridView.Rows[selectedRow];
                ID_category = Convert.ToInt32(row.Cells[0].Value);
                categoryTextBox.Text = row.Cells[1].Value.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM [cat_of_dis] WHERE ID_category = '" + ID_category + "'", database.GetConnection());
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

        private void newRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand newRowCommand = new SqlCommand("INSERT INTO [cat_of_dis] (category) Values(@category)", database.GetConnection());
                newRowCommand.Parameters.AddWithValue("category", categoryTextBox.Text);
                database.openConnection();
                newRowCommand.ExecuteNonQuery();
                MessageBox.Show("Добавлена новая категория заболеваний", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void categorySTextBox_TextChanged(object sender, EventArgs e)
        {
            Clean();
            catofdisBindingSource.Filter = $"category LIKE '%{categorySTextBox.Text}%'";
        }
    }
}
