namespace hospital
{
    partial class reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reg));
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.doctorsComboBox = new System.Windows.Forms.ComboBox();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsHospitalDataSet = new hospital.doctorsHospitalDataSet();
            this.doctorsTableAdapter = new hospital.doctorsHospitalDataSetTableAdapters.doctorsTableAdapter();
            this.appDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.postTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.companyTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.resPlaceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.registrationTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.benCodeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.disabTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.telNumTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.cardTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.insurPolicyTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.insurNumTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passportTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.patientsComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.birthdayTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fullnameSTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.telSTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.aboutButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.couponTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.patientEditButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.printButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.exitButton = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsHospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(477, 523);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 25);
            this.label14.TabIndex = 67;
            this.label14.Text = "Номер талона:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(12, 531);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 25);
            this.label15.TabIndex = 68;
            this.label15.Text = "Доктор:";
            // 
            // doctorsComboBox
            // 
            this.doctorsComboBox.DataSource = this.doctorsBindingSource;
            this.doctorsComboBox.DisplayMember = "fullname";
            this.doctorsComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorsComboBox.FormattingEnabled = true;
            this.doctorsComboBox.Location = new System.Drawing.Point(12, 564);
            this.doctorsComboBox.Name = "doctorsComboBox";
            this.doctorsComboBox.Size = new System.Drawing.Size(789, 33);
            this.doctorsComboBox.TabIndex = 69;
            this.doctorsComboBox.ValueMember = "fullname";
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "doctors";
            this.doctorsBindingSource.DataSource = this.doctorsHospitalDataSet;
            // 
            // doctorsHospitalDataSet
            // 
            this.doctorsHospitalDataSet.DataSetName = "doctorsHospitalDataSet";
            this.doctorsHospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // appDateTimePicker
            // 
            this.appDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appDateTimePicker.CustomFormat = "dd MMMM yyyy  |  HH:mm";
            this.appDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appDateTimePicker.Location = new System.Drawing.Point(378, 607);
            this.appDateTimePicker.Name = "appDateTimePicker";
            this.appDateTimePicker.Size = new System.Drawing.Size(238, 29);
            this.appDateTimePicker.TabIndex = 71;
            // 
            // postTextBox
            // 
            this.postTextBox.Animated = true;
            this.postTextBox.AutoRoundedCorners = true;
            this.postTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.postTextBox.BorderRadius = 15;
            this.postTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.postTextBox.DefaultText = "";
            this.postTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.postTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.postTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.postTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.postTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.postTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.postTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.postTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.postTextBox.Location = new System.Drawing.Point(206, 441);
            this.postTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.PasswordChar = '\0';
            this.postTextBox.PlaceholderText = "";
            this.postTextBox.ReadOnly = true;
            this.postTextBox.SelectedText = "";
            this.postTextBox.Size = new System.Drawing.Size(595, 33);
            this.postTextBox.TabIndex = 102;
            // 
            // companyTextBox
            // 
            this.companyTextBox.Animated = true;
            this.companyTextBox.AutoRoundedCorners = true;
            this.companyTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.companyTextBox.BorderRadius = 15;
            this.companyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyTextBox.DefaultText = "";
            this.companyTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.companyTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.companyTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.companyTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.companyTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.companyTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.companyTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.companyTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.companyTextBox.Location = new System.Drawing.Point(206, 398);
            this.companyTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.PasswordChar = '\0';
            this.companyTextBox.PlaceholderText = "";
            this.companyTextBox.ReadOnly = true;
            this.companyTextBox.SelectedText = "";
            this.companyTextBox.Size = new System.Drawing.Size(595, 33);
            this.companyTextBox.TabIndex = 101;
            // 
            // resPlaceTextBox
            // 
            this.resPlaceTextBox.Animated = true;
            this.resPlaceTextBox.AutoRoundedCorners = true;
            this.resPlaceTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.resPlaceTextBox.BorderRadius = 15;
            this.resPlaceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resPlaceTextBox.DefaultText = "";
            this.resPlaceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.resPlaceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.resPlaceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resPlaceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resPlaceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resPlaceTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.resPlaceTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.resPlaceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resPlaceTextBox.Location = new System.Drawing.Point(206, 355);
            this.resPlaceTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.resPlaceTextBox.Name = "resPlaceTextBox";
            this.resPlaceTextBox.PasswordChar = '\0';
            this.resPlaceTextBox.PlaceholderText = "";
            this.resPlaceTextBox.ReadOnly = true;
            this.resPlaceTextBox.SelectedText = "";
            this.resPlaceTextBox.Size = new System.Drawing.Size(595, 33);
            this.resPlaceTextBox.TabIndex = 100;
            // 
            // registrationTextBox
            // 
            this.registrationTextBox.Animated = true;
            this.registrationTextBox.AutoRoundedCorners = true;
            this.registrationTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.registrationTextBox.BorderRadius = 15;
            this.registrationTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.registrationTextBox.DefaultText = "";
            this.registrationTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.registrationTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.registrationTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.registrationTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.registrationTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.registrationTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.registrationTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.registrationTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.registrationTextBox.Location = new System.Drawing.Point(206, 312);
            this.registrationTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.registrationTextBox.Name = "registrationTextBox";
            this.registrationTextBox.PasswordChar = '\0';
            this.registrationTextBox.PlaceholderText = "";
            this.registrationTextBox.ReadOnly = true;
            this.registrationTextBox.SelectedText = "";
            this.registrationTextBox.Size = new System.Drawing.Size(595, 33);
            this.registrationTextBox.TabIndex = 99;
            // 
            // benCodeTextBox
            // 
            this.benCodeTextBox.Animated = true;
            this.benCodeTextBox.AutoRoundedCorners = true;
            this.benCodeTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.benCodeTextBox.BorderRadius = 15;
            this.benCodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.benCodeTextBox.DefaultText = "";
            this.benCodeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.benCodeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.benCodeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.benCodeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.benCodeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.benCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.benCodeTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.benCodeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.benCodeTextBox.Location = new System.Drawing.Point(624, 269);
            this.benCodeTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.benCodeTextBox.Name = "benCodeTextBox";
            this.benCodeTextBox.PasswordChar = '\0';
            this.benCodeTextBox.PlaceholderText = "";
            this.benCodeTextBox.ReadOnly = true;
            this.benCodeTextBox.SelectedText = "";
            this.benCodeTextBox.Size = new System.Drawing.Size(177, 33);
            this.benCodeTextBox.TabIndex = 98;
            // 
            // disabTextBox
            // 
            this.disabTextBox.Animated = true;
            this.disabTextBox.AutoRoundedCorners = true;
            this.disabTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.disabTextBox.BorderRadius = 15;
            this.disabTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.disabTextBox.DefaultText = "";
            this.disabTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.disabTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.disabTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.disabTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.disabTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.disabTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.disabTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.disabTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.disabTextBox.Location = new System.Drawing.Point(624, 226);
            this.disabTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.disabTextBox.Name = "disabTextBox";
            this.disabTextBox.PasswordChar = '\0';
            this.disabTextBox.PlaceholderText = "";
            this.disabTextBox.ReadOnly = true;
            this.disabTextBox.SelectedText = "";
            this.disabTextBox.Size = new System.Drawing.Size(177, 33);
            this.disabTextBox.TabIndex = 97;
            // 
            // telNumTextBox
            // 
            this.telNumTextBox.Animated = true;
            this.telNumTextBox.AutoRoundedCorners = true;
            this.telNumTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.telNumTextBox.BorderRadius = 15;
            this.telNumTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telNumTextBox.DefaultText = "";
            this.telNumTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.telNumTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.telNumTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.telNumTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.telNumTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.telNumTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.telNumTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.telNumTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.telNumTextBox.Location = new System.Drawing.Point(624, 183);
            this.telNumTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.telNumTextBox.Name = "telNumTextBox";
            this.telNumTextBox.PasswordChar = '\0';
            this.telNumTextBox.PlaceholderText = "";
            this.telNumTextBox.ReadOnly = true;
            this.telNumTextBox.SelectedText = "";
            this.telNumTextBox.Size = new System.Drawing.Size(177, 33);
            this.telNumTextBox.TabIndex = 96;
            // 
            // cardTextBox
            // 
            this.cardTextBox.Animated = true;
            this.cardTextBox.AutoRoundedCorners = true;
            this.cardTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.cardTextBox.BorderRadius = 15;
            this.cardTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cardTextBox.DefaultText = "";
            this.cardTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cardTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cardTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cardTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cardTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cardTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cardTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardTextBox.Location = new System.Drawing.Point(624, 140);
            this.cardTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.PasswordChar = '\0';
            this.cardTextBox.PlaceholderText = "";
            this.cardTextBox.ReadOnly = true;
            this.cardTextBox.SelectedText = "";
            this.cardTextBox.Size = new System.Drawing.Size(177, 33);
            this.cardTextBox.TabIndex = 95;
            // 
            // insurPolicyTextBox
            // 
            this.insurPolicyTextBox.Animated = true;
            this.insurPolicyTextBox.AutoRoundedCorners = true;
            this.insurPolicyTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.insurPolicyTextBox.BorderRadius = 15;
            this.insurPolicyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.insurPolicyTextBox.DefaultText = "";
            this.insurPolicyTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.insurPolicyTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.insurPolicyTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.insurPolicyTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.insurPolicyTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.insurPolicyTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.insurPolicyTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.insurPolicyTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.insurPolicyTextBox.Location = new System.Drawing.Point(206, 269);
            this.insurPolicyTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.insurPolicyTextBox.Name = "insurPolicyTextBox";
            this.insurPolicyTextBox.PasswordChar = '\0';
            this.insurPolicyTextBox.PlaceholderText = "";
            this.insurPolicyTextBox.ReadOnly = true;
            this.insurPolicyTextBox.SelectedText = "";
            this.insurPolicyTextBox.Size = new System.Drawing.Size(251, 33);
            this.insurPolicyTextBox.TabIndex = 94;
            // 
            // insurNumTextBox
            // 
            this.insurNumTextBox.Animated = true;
            this.insurNumTextBox.AutoRoundedCorners = true;
            this.insurNumTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.insurNumTextBox.BorderRadius = 15;
            this.insurNumTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.insurNumTextBox.DefaultText = "";
            this.insurNumTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.insurNumTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.insurNumTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.insurNumTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.insurNumTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.insurNumTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.insurNumTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.insurNumTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.insurNumTextBox.Location = new System.Drawing.Point(206, 226);
            this.insurNumTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.insurNumTextBox.Name = "insurNumTextBox";
            this.insurNumTextBox.PasswordChar = '\0';
            this.insurNumTextBox.PlaceholderText = "";
            this.insurNumTextBox.ReadOnly = true;
            this.insurNumTextBox.SelectedText = "";
            this.insurNumTextBox.Size = new System.Drawing.Size(251, 33);
            this.insurNumTextBox.TabIndex = 93;
            // 
            // passportTextBox
            // 
            this.passportTextBox.Animated = true;
            this.passportTextBox.AutoRoundedCorners = true;
            this.passportTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.passportTextBox.BorderRadius = 15;
            this.passportTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passportTextBox.DefaultText = "";
            this.passportTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passportTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passportTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passportTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passportTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passportTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.passportTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.passportTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passportTextBox.Location = new System.Drawing.Point(206, 183);
            this.passportTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.PasswordChar = '\0';
            this.passportTextBox.PlaceholderText = "";
            this.passportTextBox.ReadOnly = true;
            this.passportTextBox.SelectedText = "";
            this.passportTextBox.Size = new System.Drawing.Size(251, 33);
            this.passportTextBox.TabIndex = 92;
            // 
            // patientsComboBox
            // 
            this.patientsComboBox.AutoRoundedCorners = true;
            this.patientsComboBox.BackColor = System.Drawing.Color.Transparent;
            this.patientsComboBox.BorderColor = System.Drawing.Color.DimGray;
            this.patientsComboBox.BorderRadius = 17;
            this.patientsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.patientsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientsComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patientsComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patientsComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.patientsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.patientsComboBox.ItemHeight = 30;
            this.patientsComboBox.Location = new System.Drawing.Point(12, 96);
            this.patientsComboBox.Name = "patientsComboBox";
            this.patientsComboBox.Size = new System.Drawing.Size(789, 36);
            this.patientsComboBox.TabIndex = 91;
            this.patientsComboBox.SelectedValueChanged += new System.EventHandler(this.patientsComboBox_SelectedValueChanged);
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.Animated = true;
            this.birthdayTextBox.AutoRoundedCorners = true;
            this.birthdayTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.birthdayTextBox.BorderRadius = 15;
            this.birthdayTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.birthdayTextBox.DefaultText = "";
            this.birthdayTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.birthdayTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.birthdayTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.birthdayTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.birthdayTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.birthdayTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.birthdayTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.birthdayTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.birthdayTextBox.Location = new System.Drawing.Point(206, 140);
            this.birthdayTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.PasswordChar = '\0';
            this.birthdayTextBox.PlaceholderText = "";
            this.birthdayTextBox.ReadOnly = true;
            this.birthdayTextBox.SelectedText = "";
            this.birthdayTextBox.Size = new System.Drawing.Size(251, 33);
            this.birthdayTextBox.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 89;
            this.label1.Text = "Поиск по ФИО:";
            // 
            // fullnameSTextBox
            // 
            this.fullnameSTextBox.Animated = true;
            this.fullnameSTextBox.AutoRoundedCorners = true;
            this.fullnameSTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.fullnameSTextBox.BorderRadius = 15;
            this.fullnameSTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullnameSTextBox.DefaultText = "";
            this.fullnameSTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullnameSTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullnameSTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullnameSTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullnameSTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullnameSTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.fullnameSTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fullnameSTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullnameSTextBox.Location = new System.Drawing.Point(206, 55);
            this.fullnameSTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fullnameSTextBox.Name = "fullnameSTextBox";
            this.fullnameSTextBox.PasswordChar = '\0';
            this.fullnameSTextBox.PlaceholderText = "";
            this.fullnameSTextBox.SelectedText = "";
            this.fullnameSTextBox.Size = new System.Drawing.Size(595, 33);
            this.fullnameSTextBox.TabIndex = 88;
            this.fullnameSTextBox.TextChanged += new System.EventHandler(this.fullnameSTextBox_TextChanged);
            // 
            // telSTextBox
            // 
            this.telSTextBox.Animated = true;
            this.telSTextBox.AutoRoundedCorners = true;
            this.telSTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.telSTextBox.BorderRadius = 15;
            this.telSTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telSTextBox.DefaultText = "";
            this.telSTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.telSTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.telSTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.telSTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.telSTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.telSTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.telSTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.telSTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.telSTextBox.Location = new System.Drawing.Point(470, 12);
            this.telSTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.telSTextBox.Name = "telSTextBox";
            this.telSTextBox.PasswordChar = '\0';
            this.telSTextBox.PlaceholderText = "";
            this.telSTextBox.SelectedText = "";
            this.telSTextBox.Size = new System.Drawing.Size(331, 33);
            this.telSTextBox.TabIndex = 87;
            this.telSTextBox.TextChanged += new System.EventHandler(this.telSTextBox_TextChanged);
            // 
            // aboutButton
            // 
            this.aboutButton.Animated = true;
            this.aboutButton.AutoRoundedCorners = true;
            this.aboutButton.BorderColor = System.Drawing.Color.DimGray;
            this.aboutButton.BorderRadius = 15;
            this.aboutButton.BorderThickness = 1;
            this.aboutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.aboutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.aboutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.aboutButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.aboutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.aboutButton.FillColor2 = System.Drawing.Color.MediumBlue;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.aboutButton.Location = new System.Drawing.Point(12, 12);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(166, 33);
            this.aboutButton.TabIndex = 86;
            this.aboutButton.Text = "О программе";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(207, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 25);
            this.label2.TabIndex = 85;
            this.label2.Text = "Поиск по номеру телефона:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(465, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 25);
            this.label13.TabIndex = 84;
            this.label13.Text = "Номер карточки:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(465, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 25);
            this.label12.TabIndex = 83;
            this.label12.Text = "Код льгот:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(465, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 25);
            this.label11.TabIndex = 82;
            this.label11.Text = "Инвалидность:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(465, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 25);
            this.label10.TabIndex = 81;
            this.label10.Text = "Номер телефона:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(15, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 80;
            this.label9.Text = "Должность:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 79;
            this.label8.Text = "Организация:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(15, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 25);
            this.label7.TabIndex = 78;
            this.label7.Text = "Адрес проживания:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 25);
            this.label6.TabIndex = 77;
            this.label6.Text = "Адрес регистрации:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 76;
            this.label5.Text = "Полис ОМС:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 75;
            this.label4.Text = "СНИЛС:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 74;
            this.label3.Text = "Паспорт:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(15, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 25);
            this.label16.TabIndex = 73;
            this.label16.Text = "Дата рождения:";
            // 
            // couponTextBox
            // 
            this.couponTextBox.Animated = true;
            this.couponTextBox.AutoRoundedCorners = true;
            this.couponTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.couponTextBox.BorderRadius = 15;
            this.couponTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.couponTextBox.DefaultText = "";
            this.couponTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.couponTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.couponTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.couponTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.couponTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.couponTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.couponTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.couponTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.couponTextBox.Location = new System.Drawing.Point(624, 523);
            this.couponTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.couponTextBox.Name = "couponTextBox";
            this.couponTextBox.PasswordChar = '\0';
            this.couponTextBox.PlaceholderText = "";
            this.couponTextBox.SelectedText = "";
            this.couponTextBox.Size = new System.Drawing.Size(177, 33);
            this.couponTextBox.TabIndex = 103;
            // 
            // patientEditButton
            // 
            this.patientEditButton.Animated = true;
            this.patientEditButton.AutoRoundedCorners = true;
            this.patientEditButton.BorderColor = System.Drawing.Color.DimGray;
            this.patientEditButton.BorderRadius = 15;
            this.patientEditButton.BorderThickness = 1;
            this.patientEditButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.patientEditButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.patientEditButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.patientEditButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.patientEditButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.patientEditButton.FillColor2 = System.Drawing.Color.MediumBlue;
            this.patientEditButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.patientEditButton.ForeColor = System.Drawing.Color.White;
            this.patientEditButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.patientEditButton.Location = new System.Drawing.Point(12, 482);
            this.patientEditButton.Name = "patientEditButton";
            this.patientEditButton.Size = new System.Drawing.Size(789, 33);
            this.patientEditButton.TabIndex = 104;
            this.patientEditButton.Text = "Редактирование информации о пациентах";
            this.patientEditButton.Click += new System.EventHandler(this.patientEditButton_Click);
            // 
            // printButton
            // 
            this.printButton.Animated = true;
            this.printButton.AutoRoundedCorners = true;
            this.printButton.BorderColor = System.Drawing.Color.DimGray;
            this.printButton.BorderRadius = 15;
            this.printButton.BorderThickness = 1;
            this.printButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.printButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.printButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.printButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.printButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.printButton.Enabled = false;
            this.printButton.FillColor2 = System.Drawing.Color.MediumBlue;
            this.printButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.printButton.Location = new System.Drawing.Point(624, 603);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(177, 33);
            this.printButton.TabIndex = 105;
            this.printButton.Text = "Выдать талон";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Animated = true;
            this.exitButton.AutoRoundedCorners = true;
            this.exitButton.BorderColor = System.Drawing.Color.DimGray;
            this.exitButton.BorderRadius = 15;
            this.exitButton.BorderThickness = 1;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.FillColor2 = System.Drawing.Color.MediumBlue;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.exitButton.Location = new System.Drawing.Point(12, 603);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(221, 33);
            this.exitButton.TabIndex = 106;
            this.exitButton.Text = "Выйти из учётной записи";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 648);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.patientEditButton);
            this.Controls.Add(this.couponTextBox);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.resPlaceTextBox);
            this.Controls.Add(this.registrationTextBox);
            this.Controls.Add(this.benCodeTextBox);
            this.Controls.Add(this.disabTextBox);
            this.Controls.Add(this.telNumTextBox);
            this.Controls.Add(this.cardTextBox);
            this.Controls.Add(this.insurPolicyTextBox);
            this.Controls.Add(this.insurNumTextBox);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(this.patientsComboBox);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullnameSTextBox);
            this.Controls.Add(this.telSTextBox);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.appDateTimePicker);
            this.Controls.Add(this.doctorsComboBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель регистратора «МедУчИнфо»";
            this.Load += new System.EventHandler(this.reg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsHospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox doctorsComboBox;
        private doctorsHospitalDataSet doctorsHospitalDataSet;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private doctorsHospitalDataSetTableAdapters.doctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.DateTimePicker appDateTimePicker;
        private Guna.UI2.WinForms.Guna2TextBox postTextBox;
        private Guna.UI2.WinForms.Guna2TextBox companyTextBox;
        private Guna.UI2.WinForms.Guna2TextBox resPlaceTextBox;
        private Guna.UI2.WinForms.Guna2TextBox registrationTextBox;
        private Guna.UI2.WinForms.Guna2TextBox benCodeTextBox;
        private Guna.UI2.WinForms.Guna2TextBox disabTextBox;
        private Guna.UI2.WinForms.Guna2TextBox telNumTextBox;
        private Guna.UI2.WinForms.Guna2TextBox cardTextBox;
        private Guna.UI2.WinForms.Guna2TextBox insurPolicyTextBox;
        private Guna.UI2.WinForms.Guna2TextBox insurNumTextBox;
        private Guna.UI2.WinForms.Guna2TextBox passportTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox patientsComboBox;
        private Guna.UI2.WinForms.Guna2TextBox birthdayTextBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox fullnameSTextBox;
        private Guna.UI2.WinForms.Guna2TextBox telSTextBox;
        private Guna.UI2.WinForms.Guna2GradientButton aboutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox couponTextBox;
        private Guna.UI2.WinForms.Guna2GradientButton patientEditButton;
        private Guna.UI2.WinForms.Guna2GradientButton printButton;
        private Guna.UI2.WinForms.Guna2GradientButton exitButton;
    }
}