using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Word = Microsoft.Office.Interop.Word;

namespace hospital
{
    public partial class visiting : Form
    {

        dataBase database = new dataBase();
        public static int ID_doctor;
        public static int ID_patient;
        public static string fullname;
        public static string birth;
        public static string doc_fullname;
        public string FRecipe;
        Word._Application Word = new Word.Application();
        public visiting()
        {
            InitializeComponent();
        }

        private void visiting_Load(object sender, EventArgs e)
        {
            this.cat_of_disTableAdapter.Fill(this.medinstCatOfDisDataSet.cat_of_dis);
            label6.Text = "Создание записи для пациента: " + fullname + " (" + birth + " г.р.)";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FRecipe = null;
            this.Close();
            main main = new main();
            main.Show();
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            complaintsTextBox.Text = null;
            patCondTextBox.Text = null;
            therapyTextBox.Text = null;
            prelDiagTextBox.Text = null;
            nextAppDateTimePicker.Value = DateTime.Now;
            FRecipe = null;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string date = Convert.ToString(DateTime.Now);
            string pathTCheck = Environment.CurrentDirectory + "\\templates\\check.docx";
            string pathFCheck = Environment.CurrentDirectory + "\\check_files\\" 
                + date.Remove(11) + DateTime.Now.ToString("HH") + "_" + DateTime.Now.ToString("mm") 
                + "_" + DateTime.Now.ToString("ss") + " " + fullname.Split()[0] + " (" + doc_fullname.Split()[0] + ") " 
                + ID_patient.ToString() + ".docx";
            string pathTRecipe = Environment.CurrentDirectory + "\\templates\\recipe.docx";
            string pathFRecipe = Environment.CurrentDirectory + "\\recipe_files\\" + date.Remove(11) 
                + DateTime.Now.ToString("HH") + "_" + DateTime.Now.ToString("mm") + "_" + DateTime.Now.ToString("ss") 
                + " " + fullname.Split()[0] + " (" + doc_fullname.Split()[0] + ") " + ID_patient.ToString() + ".docx";
            FRecipe = pathFRecipe;

            Word._Document Doc = Word.Documents.Add(pathTCheck);
            Doc.Bookmarks["fullname"].Range.Text = fullname + " (" + birth + " г.р.)";
            Doc.Bookmarks["complaints"].Range.Text = complaintsTextBox.Text;
            Doc.Bookmarks["condition"].Range.Text = patCondTextBox.Text;
            Doc.Bookmarks["therapy"].Range.Text = therapyTextBox.Text;
            Doc.Bookmarks["conclusion"].Range.Text = prelDiagTextBox.Text;
            Doc.Bookmarks["catOfDis"].Range.Text = catOfDisComboBox.Text;
            Doc.Bookmarks["date"].Range.Text = date;
            Doc.Bookmarks["next"].Range.Text = Convert.ToString(nextAppDateTimePicker.Value).Remove(16);
            Doc.Bookmarks["doctor"].Range.Text = doc_fullname;
            Doc.SaveAs(FileName: pathFCheck);
            Doc.Close();

            Doc = Word.Documents.Add(pathTRecipe);
            Doc.Bookmarks["fullname"].Range.Text = fullname + " (" + birth + " г.р.)";
            Doc.Bookmarks["therapy"].Range.Text = therapyTextBox.Text;
            Doc.Bookmarks["date"].Range.Text = date;
            Doc.Bookmarks["next"].Range.Text = Convert.ToString(nextAppDateTimePicker.Value).Remove(16);
            Doc.Bookmarks["doctor"].Range.Text = doc_fullname;
            Doc.SaveAs(FileName: pathFRecipe);
            Doc.Close();

            try
            {
                SqlCommand newVisitCommand = new SqlCommand("INSERT INTO [visits] (ID_patient, ID_doctor, datetime, check_file, " +
                    "recipe_file, next_app, ID_category) Values(@ID_patient, @ID_doctor, @datetime, @check_file, @recipe_file, @next_app, " +
                    "@ID_category)", database.GetConnection());
                newVisitCommand.Parameters.AddWithValue("ID_patient", ID_patient);
                newVisitCommand.Parameters.AddWithValue("ID_doctor", ID_doctor);
                newVisitCommand.Parameters.AddWithValue("datetime", DateTime.Now);
                newVisitCommand.Parameters.AddWithValue("check_file", "check_files\\" + date.Remove(11) + DateTime.Now.ToString("HH") 
                    + "_" + DateTime.Now.ToString("mm") + "_" + DateTime.Now.ToString("ss") + " " + fullname.Split()[0] + " (" + doc_fullname.Split()[0] + ") " 
                    + ID_patient.ToString() + ".docx");
                newVisitCommand.Parameters.AddWithValue("recipe_file", "recipe_files\\" + date.Remove(11) + DateTime.Now.ToString("HH") 
                    + "_" + DateTime.Now.ToString("mm") + "_" + DateTime.Now.ToString("ss") + " " + fullname.Split()[0] + " (" + doc_fullname.Split()[0] + ") " 
                    + ID_patient.ToString() + ".docx");
                newVisitCommand.Parameters.AddWithValue("next_app", nextAppDateTimePicker.Value);
                newVisitCommand.Parameters.AddWithValue("ID_category", catOfDisComboBox.SelectedValue);
                database.openConnection();
                newVisitCommand.ExecuteNonQuery();
                MessageBox.Show("Создана новая запись явки пациента", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                database.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void recipeButton_Click(object sender, EventArgs e)
        {
            if (FRecipe == null)
            {
                MessageBox.Show("Необходимо сохранить запись о явке.", 
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (PrintDialog pd = new PrintDialog())
                {
                    pd.ShowDialog();
                    ProcessStartInfo info = new ProcessStartInfo(FRecipe);
                    info.Verb = "PrintTo";
                    info.Arguments = pd.PrinterSettings.PrinterName;
                    info.CreateNoWindow = true;
                    info.WindowStyle = ProcessWindowStyle.Hidden;
                    Process.Start(info);
                }
            }
        }

    }
}
