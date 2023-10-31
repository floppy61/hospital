namespace hospital
{
    partial class visiting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visiting));
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.complaintsTextBox = new System.Windows.Forms.RichTextBox();
            this.patCondTextBox = new System.Windows.Forms.RichTextBox();
            this.therapyTextBox = new System.Windows.Forms.RichTextBox();
            this.nextAppDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.catOfDisComboBox = new System.Windows.Forms.ComboBox();
            this.catofdisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medinstCatOfDisDataSet = new hospital.medinstCatOfDisDataSet();
            this.cat_of_disTableAdapter = new hospital.medinstCatOfDisDataSetTableAdapters.cat_of_disTableAdapter();
            this.backButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.prelDiagTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.cleanButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.insertButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.recipeButton = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.catofdisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medinstCatOfDisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "Жалобы:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Состояние пациента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Предварительный диагноз:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Лечение и рекомендации:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Следующая явка:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(60, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Создание записи для пациента - ...";
            // 
            // complaintsTextBox
            // 
            this.complaintsTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.complaintsTextBox.Location = new System.Drawing.Point(12, 95);
            this.complaintsTextBox.Name = "complaintsTextBox";
            this.complaintsTextBox.Size = new System.Drawing.Size(927, 96);
            this.complaintsTextBox.TabIndex = 34;
            this.complaintsTextBox.Text = "";
            // 
            // patCondTextBox
            // 
            this.patCondTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patCondTextBox.Location = new System.Drawing.Point(12, 230);
            this.patCondTextBox.Name = "patCondTextBox";
            this.patCondTextBox.Size = new System.Drawing.Size(927, 96);
            this.patCondTextBox.TabIndex = 35;
            this.patCondTextBox.Text = "";
            // 
            // therapyTextBox
            // 
            this.therapyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.therapyTextBox.Location = new System.Drawing.Point(12, 366);
            this.therapyTextBox.Name = "therapyTextBox";
            this.therapyTextBox.Size = new System.Drawing.Size(927, 96);
            this.therapyTextBox.TabIndex = 36;
            this.therapyTextBox.Text = "";
            // 
            // nextAppDateTimePicker
            // 
            this.nextAppDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextAppDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextAppDateTimePicker.CustomFormat = "dd MMMM yyyy  |  HH:mm";
            this.nextAppDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextAppDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nextAppDateTimePicker.Location = new System.Drawing.Point(181, 552);
            this.nextAppDateTimePicker.Name = "nextAppDateTimePicker";
            this.nextAppDateTimePicker.Size = new System.Drawing.Size(238, 29);
            this.nextAppDateTimePicker.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Категория заболевания:";
            // 
            // catOfDisComboBox
            // 
            this.catOfDisComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.catofdisBindingSource, "ID_category", true));
            this.catOfDisComboBox.DataSource = this.catofdisBindingSource;
            this.catOfDisComboBox.DisplayMember = "category";
            this.catOfDisComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catOfDisComboBox.FormattingEnabled = true;
            this.catOfDisComboBox.Location = new System.Drawing.Point(249, 511);
            this.catOfDisComboBox.Name = "catOfDisComboBox";
            this.catOfDisComboBox.Size = new System.Drawing.Size(690, 29);
            this.catOfDisComboBox.TabIndex = 43;
            this.catOfDisComboBox.ValueMember = "ID_category";
            // 
            // catofdisBindingSource
            // 
            this.catofdisBindingSource.DataMember = "cat_of_dis";
            this.catofdisBindingSource.DataSource = this.medinstCatOfDisDataSet;
            // 
            // medinstCatOfDisDataSet
            // 
            this.medinstCatOfDisDataSet.DataSetName = "medinstCatOfDisDataSet";
            this.medinstCatOfDisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cat_of_disTableAdapter
            // 
            this.cat_of_disTableAdapter.ClearBeforeFill = true;
            // 
            // backButton
            // 
            this.backButton.Animated = true;
            this.backButton.BorderColor = System.Drawing.Color.DimGray;
            this.backButton.BorderRadius = 15;
            this.backButton.BorderThickness = 1;
            this.backButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backButton.FillColor2 = System.Drawing.Color.MediumBlue;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(47, 45);
            this.backButton.TabIndex = 45;
            this.backButton.Text = "←";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // prelDiagTextBox
            // 
            this.prelDiagTextBox.Animated = true;
            this.prelDiagTextBox.AutoRoundedCorners = true;
            this.prelDiagTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.prelDiagTextBox.BorderRadius = 15;
            this.prelDiagTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prelDiagTextBox.DefaultText = "";
            this.prelDiagTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prelDiagTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prelDiagTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prelDiagTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prelDiagTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prelDiagTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prelDiagTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.prelDiagTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prelDiagTextBox.Location = new System.Drawing.Point(269, 470);
            this.prelDiagTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.prelDiagTextBox.Name = "prelDiagTextBox";
            this.prelDiagTextBox.PasswordChar = '\0';
            this.prelDiagTextBox.PlaceholderText = "";
            this.prelDiagTextBox.SelectedText = "";
            this.prelDiagTextBox.Size = new System.Drawing.Size(670, 33);
            this.prelDiagTextBox.TabIndex = 89;
            // 
            // cleanButton
            // 
            this.cleanButton.Animated = true;
            this.cleanButton.AutoRoundedCorners = true;
            this.cleanButton.BorderColor = System.Drawing.Color.DimGray;
            this.cleanButton.BorderRadius = 15;
            this.cleanButton.BorderThickness = 1;
            this.cleanButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cleanButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cleanButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cleanButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cleanButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cleanButton.FillColor2 = System.Drawing.Color.MediumBlue;
            this.cleanButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cleanButton.ForeColor = System.Drawing.Color.White;
            this.cleanButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cleanButton.Location = new System.Drawing.Point(800, 548);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(139, 33);
            this.cleanButton.TabIndex = 90;
            this.cleanButton.Text = "Очистить всё";
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Animated = true;
            this.insertButton.AutoRoundedCorners = true;
            this.insertButton.BorderColor = System.Drawing.Color.DimGray;
            this.insertButton.BorderRadius = 15;
            this.insertButton.BorderThickness = 1;
            this.insertButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.insertButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.insertButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.insertButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.insertButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.insertButton.FillColor2 = System.Drawing.Color.MediumBlue;
            this.insertButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.insertButton.ForeColor = System.Drawing.Color.White;
            this.insertButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.insertButton.Location = new System.Drawing.Point(579, 548);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(215, 33);
            this.insertButton.TabIndex = 91;
            this.insertButton.Text = "Сохранить информацию";
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // recipeButton
            // 
            this.recipeButton.Animated = true;
            this.recipeButton.AutoRoundedCorners = true;
            this.recipeButton.BorderColor = System.Drawing.Color.DimGray;
            this.recipeButton.BorderRadius = 15;
            this.recipeButton.BorderThickness = 1;
            this.recipeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.recipeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.recipeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.recipeButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.recipeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.recipeButton.FillColor2 = System.Drawing.Color.MediumBlue;
            this.recipeButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.recipeButton.ForeColor = System.Drawing.Color.White;
            this.recipeButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.recipeButton.Location = new System.Drawing.Point(425, 548);
            this.recipeButton.Name = "recipeButton";
            this.recipeButton.Size = new System.Drawing.Size(148, 33);
            this.recipeButton.TabIndex = 92;
            this.recipeButton.Text = "Печать рецепта";
            this.recipeButton.Click += new System.EventHandler(this.recipeButton_Click);
            // 
            // visiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 594);
            this.Controls.Add(this.recipeButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.prelDiagTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.catOfDisComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nextAppDateTimePicker);
            this.Controls.Add(this.therapyTextBox);
            this.Controls.Add(this.patCondTextBox);
            this.Controls.Add(this.complaintsTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "visiting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление информации о явке пациента";
            this.Load += new System.EventHandler(this.visiting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catofdisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medinstCatOfDisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox complaintsTextBox;
        private System.Windows.Forms.RichTextBox patCondTextBox;
        private System.Windows.Forms.RichTextBox therapyTextBox;
        private System.Windows.Forms.DateTimePicker nextAppDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox catOfDisComboBox;
        private medinstCatOfDisDataSet medinstCatOfDisDataSet;
        private System.Windows.Forms.BindingSource catofdisBindingSource;
        private medinstCatOfDisDataSetTableAdapters.cat_of_disTableAdapter cat_of_disTableAdapter;
        private Guna.UI2.WinForms.Guna2GradientButton backButton;
        private Guna.UI2.WinForms.Guna2TextBox prelDiagTextBox;
        private Guna.UI2.WinForms.Guna2GradientButton cleanButton;
        private Guna.UI2.WinForms.Guna2GradientButton insertButton;
        private Guna.UI2.WinForms.Guna2GradientButton recipeButton;
    }
}