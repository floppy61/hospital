namespace hospital
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.patientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSetPatients = new hospital.hospitalDataSetPatients();
            this.patientsHospitalDataSet = new hospital.patientsHospitalDataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new hospital.patientsHospitalDataSetTableAdapters.patientsTableAdapter();
            this.visitingsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSetVisitings = new hospital.hospitalDataSetVisitings();
            this.visitingsHospitalDataSet = new hospital.visitingsHospitalDataSet();
            this.visitingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitingsTableAdapter = new hospital.visitingsHospitalDataSetTableAdapters.visitingsTableAdapter();
            this.doctorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSetDoctors = new hospital.hospitalDataSetDoctors();
            this.doctorsHospitalDataSet = new hospital.doctorsHospitalDataSet();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter = new hospital.doctorsHospitalDataSetTableAdapters.doctorsTableAdapter();
            this.patientsTableAdapter1 = new hospital.hospitalDataSetPatientsTableAdapters.patientsTableAdapter();
            this.doctorsTableAdapter1 = new hospital.hospitalDataSetDoctorsTableAdapters.doctorsTableAdapter();
            this.visitingsTableAdapter1 = new hospital.hospitalDataSetVisitingsTableAdapters.visitingsTableAdapter();
            this.infoLabel = new System.Windows.Forms.Label();
            this.adminsButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.doctorsButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.catOfDisButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.exitButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aboutButton = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsHospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetVisitings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingsHospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsHospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // patientsBindingSource1
            // 
            this.patientsBindingSource1.DataMember = "patients";
            this.patientsBindingSource1.DataSource = this.hospitalDataSetPatients;
            // 
            // hospitalDataSetPatients
            // 
            this.hospitalDataSetPatients.DataSetName = "hospitalDataSetPatients";
            this.hospitalDataSetPatients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsHospitalDataSet
            // 
            this.patientsHospitalDataSet.DataSetName = "patientsHospitalDataSet";
            this.patientsHospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.patientsHospitalDataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // visitingsBindingSource1
            // 
            this.visitingsBindingSource1.DataMember = "visitings";
            this.visitingsBindingSource1.DataSource = this.hospitalDataSetVisitings;
            // 
            // hospitalDataSetVisitings
            // 
            this.hospitalDataSetVisitings.DataSetName = "hospitalDataSetVisitings";
            this.hospitalDataSetVisitings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitingsHospitalDataSet
            // 
            this.visitingsHospitalDataSet.DataSetName = "visitingsHospitalDataSet";
            this.visitingsHospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitingsBindingSource
            // 
            this.visitingsBindingSource.DataMember = "visitings";
            this.visitingsBindingSource.DataSource = this.visitingsHospitalDataSet;
            // 
            // visitingsTableAdapter
            // 
            this.visitingsTableAdapter.ClearBeforeFill = true;
            // 
            // doctorsBindingSource1
            // 
            this.doctorsBindingSource1.DataMember = "doctors";
            this.doctorsBindingSource1.DataSource = this.hospitalDataSetDoctors;
            // 
            // hospitalDataSetDoctors
            // 
            this.hospitalDataSetDoctors.DataSetName = "hospitalDataSetDoctors";
            this.hospitalDataSetDoctors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorsHospitalDataSet
            // 
            this.doctorsHospitalDataSet.DataSetName = "doctorsHospitalDataSet";
            this.doctorsHospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "doctors";
            this.doctorsBindingSource.DataSource = this.doctorsHospitalDataSet;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // patientsTableAdapter1
            // 
            this.patientsTableAdapter1.ClearBeforeFill = true;
            // 
            // doctorsTableAdapter1
            // 
            this.doctorsTableAdapter1.ClearBeforeFill = true;
            // 
            // visitingsTableAdapter1
            // 
            this.visitingsTableAdapter1.ClearBeforeFill = true;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(12, 22);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(349, 25);
            this.infoLabel.TabIndex = 33;
            this.infoLabel.Text = "Разделы базы данных «МедУчИнфо»";
            // 
            // adminsButton
            // 
            this.adminsButton.Animated = true;
            this.adminsButton.AutoRoundedCorners = true;
            this.adminsButton.BorderColor = System.Drawing.Color.DimGray;
            this.adminsButton.BorderRadius = 20;
            this.adminsButton.BorderThickness = 1;
            this.adminsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adminsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adminsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adminsButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adminsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adminsButton.FillColor2 = System.Drawing.Color.DarkOrchid;
            this.adminsButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.adminsButton.ForeColor = System.Drawing.Color.White;
            this.adminsButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.adminsButton.Location = new System.Drawing.Point(17, 63);
            this.adminsButton.Name = "adminsButton";
            this.adminsButton.Size = new System.Drawing.Size(326, 42);
            this.adminsButton.TabIndex = 109;
            this.adminsButton.Text = "Администраторы и регистраторы";
            this.adminsButton.Click += new System.EventHandler(this.adminsButton_Click);
            // 
            // doctorsButton
            // 
            this.doctorsButton.Animated = true;
            this.doctorsButton.AutoRoundedCorners = true;
            this.doctorsButton.BorderColor = System.Drawing.Color.DimGray;
            this.doctorsButton.BorderRadius = 20;
            this.doctorsButton.BorderThickness = 1;
            this.doctorsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.doctorsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.doctorsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.doctorsButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.doctorsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.doctorsButton.FillColor2 = System.Drawing.Color.DarkOrchid;
            this.doctorsButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.doctorsButton.ForeColor = System.Drawing.Color.White;
            this.doctorsButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.doctorsButton.Location = new System.Drawing.Point(17, 111);
            this.doctorsButton.Name = "doctorsButton";
            this.doctorsButton.Size = new System.Drawing.Size(326, 42);
            this.doctorsButton.TabIndex = 110;
            this.doctorsButton.Text = "Доктора";
            this.doctorsButton.Click += new System.EventHandler(this.doctorsButton_Click);
            // 
            // catOfDisButton
            // 
            this.catOfDisButton.Animated = true;
            this.catOfDisButton.AutoRoundedCorners = true;
            this.catOfDisButton.BorderColor = System.Drawing.Color.DimGray;
            this.catOfDisButton.BorderRadius = 20;
            this.catOfDisButton.BorderThickness = 1;
            this.catOfDisButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.catOfDisButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.catOfDisButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.catOfDisButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.catOfDisButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.catOfDisButton.FillColor2 = System.Drawing.Color.DarkOrchid;
            this.catOfDisButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.catOfDisButton.ForeColor = System.Drawing.Color.White;
            this.catOfDisButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.catOfDisButton.Location = new System.Drawing.Point(17, 159);
            this.catOfDisButton.Name = "catOfDisButton";
            this.catOfDisButton.Size = new System.Drawing.Size(326, 42);
            this.catOfDisButton.TabIndex = 111;
            this.catOfDisButton.Text = "Категории заболеваний";
            this.catOfDisButton.Click += new System.EventHandler(this.catOfDisButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Animated = true;
            this.exitButton.AutoRoundedCorners = true;
            this.exitButton.BorderColor = System.Drawing.Color.DimGray;
            this.exitButton.BorderRadius = 20;
            this.exitButton.BorderThickness = 1;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.FillColor2 = System.Drawing.Color.DarkOrchid;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.exitButton.Location = new System.Drawing.Point(17, 292);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(326, 42);
            this.exitButton.TabIndex = 112;
            this.exitButton.Text = "Выйти из учётной записи";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // aboutButton
            // 
            this.aboutButton.Animated = true;
            this.aboutButton.AutoRoundedCorners = true;
            this.aboutButton.BorderColor = System.Drawing.Color.DimGray;
            this.aboutButton.BorderRadius = 20;
            this.aboutButton.BorderThickness = 1;
            this.aboutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.aboutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.aboutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.aboutButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.aboutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.aboutButton.FillColor2 = System.Drawing.Color.DarkOrchid;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.aboutButton.Location = new System.Drawing.Point(17, 207);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(326, 42);
            this.aboutButton.TabIndex = 114;
            this.aboutButton.Text = "О программе";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(630, 346);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.catOfDisButton);
            this.Controls.Add(this.doctorsButton);
            this.Controls.Add(this.adminsButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsHospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetVisitings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingsHospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsHospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private patientsHospitalDataSet patientsHospitalDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private patientsHospitalDataSetTableAdapters.patientsTableAdapter patientsTableAdapter;
        private visitingsHospitalDataSet visitingsHospitalDataSet;
        private System.Windows.Forms.BindingSource visitingsBindingSource;
        private visitingsHospitalDataSetTableAdapters.visitingsTableAdapter visitingsTableAdapter;
        private doctorsHospitalDataSet doctorsHospitalDataSet;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private doctorsHospitalDataSetTableAdapters.doctorsTableAdapter doctorsTableAdapter;
        private hospitalDataSetPatients hospitalDataSetPatients;
        private System.Windows.Forms.BindingSource patientsBindingSource1;
        private hospitalDataSetPatientsTableAdapters.patientsTableAdapter patientsTableAdapter1;
        private hospitalDataSetDoctors hospitalDataSetDoctors;
        private System.Windows.Forms.BindingSource doctorsBindingSource1;
        private hospitalDataSetDoctorsTableAdapters.doctorsTableAdapter doctorsTableAdapter1;
        private hospitalDataSetVisitings hospitalDataSetVisitings;
        private System.Windows.Forms.BindingSource visitingsBindingSource1;
        private hospitalDataSetVisitingsTableAdapters.visitingsTableAdapter visitingsTableAdapter1;
        private System.Windows.Forms.Label infoLabel;
        private Guna.UI2.WinForms.Guna2GradientButton adminsButton;
        private Guna.UI2.WinForms.Guna2GradientButton doctorsButton;
        private Guna.UI2.WinForms.Guna2GradientButton catOfDisButton;
        private Guna.UI2.WinForms.Guna2GradientButton exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton aboutButton;
    }
}