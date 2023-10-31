namespace hospital
{
    partial class prevVisitings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prevVisitings));
            this.datetimeListBox = new System.Windows.Forms.ListBox();
            this.medinstVisitsDataSet = new hospital.medinstVisitsDataSet();
            this.visitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitsTableAdapter = new hospital.medinstVisitsDataSetTableAdapters.visitsTableAdapter();
            this.patientLabel = new System.Windows.Forms.Label();
            this.checkFRichTextBox = new System.Windows.Forms.RichTextBox();
            this.recipeRadioButton = new System.Windows.Forms.RadioButton();
            this.checkRadioButton = new System.Windows.Forms.RadioButton();
            this.backButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.excelButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.checkFButton = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.medinstVisitsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datetimeListBox
            // 
            this.datetimeListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datetimeListBox.FormattingEnabled = true;
            this.datetimeListBox.ItemHeight = 21;
            this.datetimeListBox.Location = new System.Drawing.Point(12, 58);
            this.datetimeListBox.Name = "datetimeListBox";
            this.datetimeListBox.Size = new System.Drawing.Size(169, 403);
            this.datetimeListBox.TabIndex = 2;
            this.datetimeListBox.SelectedIndexChanged += new System.EventHandler(this.datetimeListBox_SelectedIndexChanged);
            // 
            // medinstVisitsDataSet
            // 
            this.medinstVisitsDataSet.DataSetName = "medinstVisitsDataSet";
            this.medinstVisitsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitsBindingSource
            // 
            this.visitsBindingSource.DataMember = "visits";
            this.visitsBindingSource.DataSource = this.medinstVisitsDataSet;
            // 
            // visitsTableAdapter
            // 
            this.visitsTableAdapter.ClearBeforeFill = true;
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientLabel.Location = new System.Drawing.Point(66, 20);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(347, 25);
            this.patientLabel.TabIndex = 33;
            this.patientLabel.Text = "Предыдущие посещения пациента - ...";
            // 
            // checkFRichTextBox
            // 
            this.checkFRichTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkFRichTextBox.Location = new System.Drawing.Point(187, 89);
            this.checkFRichTextBox.Name = "checkFRichTextBox";
            this.checkFRichTextBox.Size = new System.Drawing.Size(655, 373);
            this.checkFRichTextBox.TabIndex = 34;
            this.checkFRichTextBox.Text = "";
            // 
            // recipeRadioButton
            // 
            this.recipeRadioButton.AutoSize = true;
            this.recipeRadioButton.Enabled = false;
            this.recipeRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeRadioButton.Location = new System.Drawing.Point(306, 58);
            this.recipeRadioButton.Name = "recipeRadioButton";
            this.recipeRadioButton.Size = new System.Drawing.Size(79, 25);
            this.recipeRadioButton.TabIndex = 35;
            this.recipeRadioButton.Text = "Рецепт";
            this.recipeRadioButton.UseVisualStyleBackColor = true;
            this.recipeRadioButton.CheckedChanged += new System.EventHandler(this.recipeRadioButton_CheckedChanged);
            // 
            // checkRadioButton
            // 
            this.checkRadioButton.AutoSize = true;
            this.checkRadioButton.Checked = true;
            this.checkRadioButton.Enabled = false;
            this.checkRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkRadioButton.Location = new System.Drawing.Point(191, 58);
            this.checkRadioButton.Name = "checkRadioButton";
            this.checkRadioButton.Size = new System.Drawing.Size(102, 25);
            this.checkRadioButton.TabIndex = 36;
            this.checkRadioButton.TabStop = true;
            this.checkRadioButton.Text = "Файл явки";
            this.checkRadioButton.UseVisualStyleBackColor = true;
            this.checkRadioButton.CheckedChanged += new System.EventHandler(this.checkRadioButton_CheckedChanged);
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
            this.backButton.Location = new System.Drawing.Point(12, 7);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(47, 45);
            this.backButton.TabIndex = 44;
            this.backButton.Text = "←";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // excelButton
            // 
            this.excelButton.Animated = true;
            this.excelButton.AutoRoundedCorners = true;
            this.excelButton.BorderColor = System.Drawing.Color.DimGray;
            this.excelButton.BorderRadius = 20;
            this.excelButton.BorderThickness = 1;
            this.excelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.excelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.excelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.excelButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.excelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.excelButton.FillColor2 = System.Drawing.Color.MediumBlue;
            this.excelButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.excelButton.ForeColor = System.Drawing.Color.White;
            this.excelButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.excelButton.Location = new System.Drawing.Point(12, 468);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(336, 42);
            this.excelButton.TabIndex = 107;
            this.excelButton.Text = "Вывод информации о посещениях в Excel";
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // checkFButton
            // 
            this.checkFButton.Animated = true;
            this.checkFButton.AutoRoundedCorners = true;
            this.checkFButton.BorderColor = System.Drawing.Color.DimGray;
            this.checkFButton.BorderRadius = 20;
            this.checkFButton.BorderThickness = 1;
            this.checkFButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkFButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkFButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkFButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkFButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkFButton.FillColor2 = System.Drawing.Color.MediumBlue;
            this.checkFButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkFButton.ForeColor = System.Drawing.Color.White;
            this.checkFButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.checkFButton.Location = new System.Drawing.Point(354, 468);
            this.checkFButton.Name = "checkFButton";
            this.checkFButton.Size = new System.Drawing.Size(488, 42);
            this.checkFButton.TabIndex = 108;
            this.checkFButton.Text = "Открыть файл в Word";
            this.checkFButton.Click += new System.EventHandler(this.checkFButton_Click);
            // 
            // prevVisitings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 522);
            this.Controls.Add(this.checkFButton);
            this.Controls.Add(this.excelButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.checkRadioButton);
            this.Controls.Add(this.recipeRadioButton);
            this.Controls.Add(this.checkFRichTextBox);
            this.Controls.Add(this.patientLabel);
            this.Controls.Add(this.datetimeListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "prevVisitings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предыдущие посещения пациента";
            this.Load += new System.EventHandler(this.prevVisitings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medinstVisitsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox datetimeListBox;
        private medinstVisitsDataSet medinstVisitsDataSet;
        private System.Windows.Forms.BindingSource visitsBindingSource;
        private medinstVisitsDataSetTableAdapters.visitsTableAdapter visitsTableAdapter;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.RichTextBox checkFRichTextBox;
        private System.Windows.Forms.RadioButton recipeRadioButton;
        private System.Windows.Forms.RadioButton checkRadioButton;
        private Guna.UI2.WinForms.Guna2GradientButton backButton;
        private Guna.UI2.WinForms.Guna2GradientButton excelButton;
        private Guna.UI2.WinForms.Guna2GradientButton checkFButton;
    }
}