using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Word = Microsoft.Office.Interop.Word;

namespace hospital
{
    public partial class prevVisitings : Form
    {
        dataBase database = new dataBase();
        public static int ID_patient_current;
        public static string fullname;
        public static string birth;
        public static string doc_fullname;

        public static string pathFCheck;
        public static string pathFRecipe;

        public static string pathTFCheck;
        public static string pathTFRecipe;

        public static string type_f;
        public static string docxFile;
        public prevVisitings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Выводит в Excel-файл информацию о всех посещениях выбранного пациента 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excelButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            excel.Workbooks.Add();
            excel.Columns.ColumnWidth = 33;
            excel.Cells[1, 1].EntireRow.Font.Bold = true;
            excel.Range["A1"].Value = "ФИО доктора";
            excel.Range["B1"].Value = "ФИО пациента";
            excel.Range["C1"].Value = "Дата рождения";
            excel.Range["D1"].Value = "Паспорт";
            excel.Range["E1"].Value = "Номер телефона";
            excel.Range["F1"].Value = "Дата приёма";
            excel.Range["G1"].Value = "Файл обследования";
            excel.Range["H1"].Value = "Файл рецепта";
            excel.Range["I1"].Value = "Дата следующего приёма";
            excel.Range["J1"].Value = "Категория заболевания";

            int count = 2;
            int ID_doctor = 0;
            int ID_category = 0;

            string excelQuery = $"Select * from [visits] where ID_patient = '" + Convert.ToInt32(ID_patient_current) + "'";

            try
            {
                database.openConnection();
                SqlCommand visitsCommand = new SqlCommand(excelQuery, database.GetConnection());
                SqlDataReader visits = visitsCommand.ExecuteReader();

                while (visits.Read())
                {
                    ID_doctor = Convert.ToInt32(visits["ID_doctor"]);
                    ID_category = Convert.ToInt32(visits["ID_category"]);

                    string patientQuery = $"Select * from [patients] where ID_patient = '" + Convert.ToString(ID_patient_current) + "'";
                    string doctorQuery = $"Select * from [doctors] where ID_doctor = '" + Convert.ToString(ID_doctor) + "'";
                    string catOfDisQuery = $"Select * from [cat_of_dis] where ID_category = '" + Convert.ToString(ID_category) + "'";

                    SqlCommand doctorCommand = new SqlCommand(doctorQuery, database.GetConnection());
                    SqlDataReader doctor = doctorCommand.ExecuteReader();
                    doctor.Read();
                    excel.Cells[count, 1] = Convert.ToString(doctor["fullname"]);
                    doctor.Close();

                    SqlCommand patientCommand = new SqlCommand(patientQuery, database.GetConnection());
                    SqlDataReader patient = patientCommand.ExecuteReader();
                    patient.Read();
                    excel.Cells[count, 2] = Convert.ToString(patient["fullname"]);
                    excel.Cells[count, 3] = Convert.ToString(patient["birthday"]).Remove(10);
                    excel.Cells[count, 4] = Convert.ToString(patient["passport"]);
                    excel.Cells[count, 5] = Convert.ToString(patient["tel_num"]);
                    patient.Close();

                    excel.Cells[count, 6] = Convert.ToString(visits["datetime"]);
                    excel.Cells[count, 7] = Convert.ToString(visits["check_file"]);
                    excel.Cells[count, 8] = Convert.ToString(visits["recipe_file"]);
                    excel.Cells[count, 9] = Convert.ToString(visits["next_app"]);

                    SqlCommand categoryCommand = new SqlCommand(catOfDisQuery, database.GetConnection());
                    SqlDataReader category = categoryCommand.ExecuteReader();
                    category.Read();
                    excel.Cells[count, 10] = Convert.ToString(category["category"]);
                    category.Close();

                    count++;
                }
                visits.Close();
                database.closeConnection();

                ((Microsoft.Office.Interop.Excel.Range)excel.get_Range("A1:J" + (count - 1))).Cells.Borders.LineStyle = 
                    Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void prevVisitings_Load(object sender, EventArgs e)
        {
            checkRadioButton.Checked = true;
            patientLabel.Text = "Предыдущие посещения пациента: " + fullname + " (" + birth + " г.р.)";
            
            Directory
        .GetFiles(Environment.CurrentDirectory + "\\check_files\\", "*" + ID_patient_current.ToString() 
        + ".docx", SearchOption.AllDirectories)
        .ToList()
        .ForEach(files => datetimeListBox.Items.Insert(0, Path.GetFileName(files).Remove(19)));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            main main = new main();
            main.Show();
        }
        /// <summary>
        /// Открывает необходимый файл формата Word 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkFButton_Click(object sender, EventArgs e)
        {
            if (checkRadioButton.Checked == true)
            {
                Process.Start(pathFCheck);
            }
            else if (recipeRadioButton.Checked == true)
            {
                Process.Start(pathFRecipe);
            }
        }

        private void datetimeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkRadioButton.Enabled = true;
            recipeRadioButton.Enabled = true;
            checkFButton.Enabled = true;

            checkRadioButton.Checked = true;

            string[] filesCheck = Directory.GetFiles(Environment.CurrentDirectory 
                + "\\check_files\\", datetimeListBox.SelectedItem + "*", SearchOption.AllDirectories);
            pathFCheck = filesCheck[0];
            string[] filesRecipe = Directory.GetFiles(Environment.CurrentDirectory 
                + "\\recipe_files\\", datetimeListBox.SelectedItem + "*", SearchOption.AllDirectories);
            pathFRecipe = filesRecipe[0];

            docxFile = pathFCheck;

            pathTFCheck = pathFCheck.Replace("check_files", "temp_files\\check_f");
            pathTFRecipe = pathFRecipe.Replace("recipe_files", "temp_files\\recipe_f");

            type_f = pathTFCheck;

            checkFRich();
        }
        /// <summary>
        /// Переводит выбранный DOCX-файл 
        /// в формат RTF для его дальнейшего отображения в RichTextBox
        /// </summary>
        public void checkFRich()
        {
            Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Object docxFileName = docxFile;
            Object missing = Type.Missing;
            app.Documents.Open(ref docxFileName, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing);

            Object lookComments = false;
            Object password = String.Empty;
            Object AddToRecentFiles = true;
            Object WritePassword = String.Empty;
            Object ReadOnlyRecommended = false;
            Object EmbedTrueTypeFonts = false;
            Object SaveFormsData = false;
            Object SaveAsAOCELetter = false;

            string rtfFile = type_f;
            rtfFile = rtfFile.Replace("docx", "rtf");
            Object rtfFileName = rtfFile;

            Object wdFormatRTF = Word.WdSaveFormat.wdFormatRTF;

            if (File.Exists(rtfFile) == false)
                app.ActiveDocument.SaveAs(ref rtfFileName,
                    ref wdFormatRTF, ref lookComments, ref password, ref AddToRecentFiles, ref WritePassword, ref ReadOnlyRecommended,
                    ref EmbedTrueTypeFonts, ref missing, ref SaveFormsData, ref SaveAsAOCELetter, ref missing,
                    ref missing, ref missing, ref missing, ref missing);

            Object @false = false;

            app.ActiveDocument.Close(ref @false, ref missing, ref missing);

            app.Quit(ref @false, ref missing, ref missing);

            checkFRichTextBox.LoadFile((String)rtfFileName);
        }

        private void recipeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (recipeRadioButton.Checked == true)
            {
                docxFile = pathFRecipe;
                type_f = pathTFRecipe;
                checkFRich();
            }
        }

        private void checkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRadioButton.Checked == true)
            {
                docxFile = pathFCheck;
                type_f = pathTFCheck;
                checkFRich();
            }
        }
    }
}
