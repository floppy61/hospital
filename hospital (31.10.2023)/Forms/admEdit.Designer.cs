namespace hospital
{
    partial class admEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admEdit));
            this.admRegDataGridView = new System.Windows.Forms.DataGridView();
            this.iDadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurpolicyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acctypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admregBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medinstAdmRegDataSet = new hospital.medinstAdmRegDataSet();
            this.adm_regTableAdapter = new hospital.medinstAdmRegDataSetTableAdapters.adm_regTableAdapter();
            this.admRegBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label6 = new System.Windows.Forms.Label();
            this.backButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.fullnameSTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.loginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.insurPolicyTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.insurNumTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passportTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.telNumTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fullnameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.typeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.saveButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.deleteButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.refreshButton = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.admRegDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admregBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medinstAdmRegDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admRegBindingNavigator)).BeginInit();
            this.admRegBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // admRegDataGridView
            // 
            this.admRegDataGridView.AutoGenerateColumns = false;
            this.admRegDataGridView.BackgroundColor = System.Drawing.Color.LightBlue;
            this.admRegDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admRegDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDadminDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.telnumDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.insurnumDataGridViewTextBoxColumn,
            this.insurpolicyDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.acctypeDataGridViewTextBoxColumn});
            this.admRegDataGridView.DataSource = this.admregBindingSource;
            this.admRegDataGridView.Location = new System.Drawing.Point(12, 98);
            this.admRegDataGridView.Name = "admRegDataGridView";
            this.admRegDataGridView.Size = new System.Drawing.Size(1061, 260);
            this.admRegDataGridView.TabIndex = 0;
            this.admRegDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admRegDataGridView_CellContentClick);
            this.admRegDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.admRegDataGridView_DataError);
            // 
            // iDadminDataGridViewTextBoxColumn
            // 
            this.iDadminDataGridViewTextBoxColumn.DataPropertyName = "ID_admin";
            this.iDadminDataGridViewTextBoxColumn.HeaderText = "ID_admin";
            this.iDadminDataGridViewTextBoxColumn.Name = "iDadminDataGridViewTextBoxColumn";
            this.iDadminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // telnumDataGridViewTextBoxColumn
            // 
            this.telnumDataGridViewTextBoxColumn.DataPropertyName = "tel_num";
            this.telnumDataGridViewTextBoxColumn.HeaderText = "tel_num";
            this.telnumDataGridViewTextBoxColumn.Name = "telnumDataGridViewTextBoxColumn";
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "passport";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            // 
            // insurnumDataGridViewTextBoxColumn
            // 
            this.insurnumDataGridViewTextBoxColumn.DataPropertyName = "insur_num";
            this.insurnumDataGridViewTextBoxColumn.HeaderText = "insur_num";
            this.insurnumDataGridViewTextBoxColumn.Name = "insurnumDataGridViewTextBoxColumn";
            // 
            // insurpolicyDataGridViewTextBoxColumn
            // 
            this.insurpolicyDataGridViewTextBoxColumn.DataPropertyName = "insur_policy";
            this.insurpolicyDataGridViewTextBoxColumn.HeaderText = "insur_policy";
            this.insurpolicyDataGridViewTextBoxColumn.Name = "insurpolicyDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // acctypeDataGridViewTextBoxColumn
            // 
            this.acctypeDataGridViewTextBoxColumn.DataPropertyName = "acc_type";
            this.acctypeDataGridViewTextBoxColumn.HeaderText = "acc_type";
            this.acctypeDataGridViewTextBoxColumn.Name = "acctypeDataGridViewTextBoxColumn";
            // 
            // admregBindingSource
            // 
            this.admregBindingSource.DataMember = "adm_reg";
            this.admregBindingSource.DataSource = this.medinstAdmRegDataSet;
            // 
            // medinstAdmRegDataSet
            // 
            this.medinstAdmRegDataSet.DataSetName = "medinstAdmRegDataSet";
            this.medinstAdmRegDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adm_regTableAdapter
            // 
            this.adm_regTableAdapter.ClearBeforeFill = true;
            // 
            // admRegBindingNavigator
            // 
            this.admRegBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.admRegBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.admRegBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.admRegBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.admRegBindingNavigator.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.admRegBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.admRegBindingNavigator.Location = new System.Drawing.Point(9, 544);
            this.admRegBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.admRegBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.admRegBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.admRegBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.admRegBindingNavigator.Name = "admRegBindingNavigator";
            this.admRegBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.admRegBindingNavigator.Size = new System.Drawing.Size(299, 32);
            this.admRegBindingNavigator.TabIndex = 1;
            this.admRegBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 29);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 29);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 29);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 29);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 29);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 29);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 29);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(67, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(427, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Администраторы и регистраторы (база данных)";
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
            this.backButton.FillColor2 = System.Drawing.Color.DarkViolet;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.backButton.Location = new System.Drawing.Point(12, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(47, 45);
            this.backButton.TabIndex = 107;
            this.backButton.Text = "←";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            this.fullnameSTextBox.Location = new System.Drawing.Point(164, 57);
            this.fullnameSTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fullnameSTextBox.Name = "fullnameSTextBox";
            this.fullnameSTextBox.PasswordChar = '\0';
            this.fullnameSTextBox.PlaceholderText = "";
            this.fullnameSTextBox.SelectedText = "";
            this.fullnameSTextBox.Size = new System.Drawing.Size(909, 33);
            this.fullnameSTextBox.TabIndex = 118;
            this.fullnameSTextBox.TextChanged += new System.EventHandler(this.fullnameSTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(12, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 25);
            this.label14.TabIndex = 117;
            this.label14.Text = "Поиск по ФИО:";
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayPicker.Location = new System.Drawing.Point(381, 413);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(294, 33);
            this.birthdayPicker.TabIndex = 142;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(468, 544);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 25);
            this.label13.TabIndex = 140;
            this.label13.Text = "Тип аккаунта:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Animated = true;
            this.loginTextBox.AutoRoundedCorners = true;
            this.loginTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.loginTextBox.BorderRadius = 15;
            this.loginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextBox.DefaultText = "";
            this.loginTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.loginTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.loginTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTextBox.Location = new System.Drawing.Point(781, 454);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PasswordChar = '\0';
            this.loginTextBox.PlaceholderText = "";
            this.loginTextBox.SelectedText = "";
            this.loginTextBox.Size = new System.Drawing.Size(294, 33);
            this.loginTextBox.TabIndex = 139;
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
            this.insurPolicyTextBox.Location = new System.Drawing.Point(781, 413);
            this.insurPolicyTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.insurPolicyTextBox.Name = "insurPolicyTextBox";
            this.insurPolicyTextBox.PasswordChar = '\0';
            this.insurPolicyTextBox.PlaceholderText = "";
            this.insurPolicyTextBox.SelectedText = "";
            this.insurPolicyTextBox.Size = new System.Drawing.Size(294, 33);
            this.insurPolicyTextBox.TabIndex = 138;
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
            this.insurNumTextBox.Location = new System.Drawing.Point(781, 372);
            this.insurNumTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.insurNumTextBox.Name = "insurNumTextBox";
            this.insurNumTextBox.PasswordChar = '\0';
            this.insurNumTextBox.PlaceholderText = "";
            this.insurNumTextBox.SelectedText = "";
            this.insurNumTextBox.Size = new System.Drawing.Size(294, 33);
            this.insurNumTextBox.TabIndex = 137;
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
            this.passportTextBox.Location = new System.Drawing.Point(381, 497);
            this.passportTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.PasswordChar = '\0';
            this.passportTextBox.PlaceholderText = "";
            this.passportTextBox.SelectedText = "";
            this.passportTextBox.Size = new System.Drawing.Size(294, 33);
            this.passportTextBox.TabIndex = 136;
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
            this.telNumTextBox.Location = new System.Drawing.Point(381, 454);
            this.telNumTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.telNumTextBox.Name = "telNumTextBox";
            this.telNumTextBox.PasswordChar = '\0';
            this.telNumTextBox.PlaceholderText = "";
            this.telNumTextBox.SelectedText = "";
            this.telNumTextBox.Size = new System.Drawing.Size(294, 33);
            this.telNumTextBox.TabIndex = 135;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Animated = true;
            this.fullnameTextBox.AutoRoundedCorners = true;
            this.fullnameTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.fullnameTextBox.BorderRadius = 15;
            this.fullnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullnameTextBox.DefaultText = "";
            this.fullnameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullnameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullnameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullnameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullnameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullnameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.fullnameTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fullnameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullnameTextBox.Location = new System.Drawing.Point(381, 372);
            this.fullnameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.PasswordChar = '\0';
            this.fullnameTextBox.PlaceholderText = "";
            this.fullnameTextBox.SelectedText = "";
            this.fullnameTextBox.Size = new System.Drawing.Size(294, 33);
            this.fullnameTextBox.TabIndex = 131;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Animated = true;
            this.passwordTextBox.AutoRoundedCorners = true;
            this.passwordTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.passwordTextBox.BorderRadius = 15;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.Location = new System.Drawing.Point(781, 497);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderText = "";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(294, 33);
            this.passwordTextBox.TabIndex = 130;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(693, 497);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 25);
            this.label11.TabIndex = 129;
            this.label11.Text = "Пароль:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(693, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 128;
            this.label10.Text = "Логин:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(693, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 127;
            this.label9.Text = "ОМС:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(693, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 126;
            this.label8.Text = "СНИЛС:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(210, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 125;
            this.label7.Text = "Паспорт:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(210, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 124;
            this.label1.Text = "Номер телефона:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(210, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 120;
            this.label2.Text = "ФИО:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(210, 413);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 25);
            this.label12.TabIndex = 119;
            this.label12.Text = "Дата рождения:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.AutoRoundedCorners = true;
            this.typeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.typeComboBox.BorderColor = System.Drawing.Color.DimGray;
            this.typeComboBox.BorderRadius = 17;
            this.typeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.typeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.typeComboBox.ItemHeight = 30;
            this.typeComboBox.Items.AddRange(new object[] {
            "admin",
            "reg"});
            this.typeComboBox.Location = new System.Drawing.Point(603, 538);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(247, 36);
            this.typeComboBox.TabIndex = 143;
            // 
            // saveButton
            // 
            this.saveButton.Animated = true;
            this.saveButton.AutoRoundedCorners = true;
            this.saveButton.BorderColor = System.Drawing.Color.DimGray;
            this.saveButton.BorderRadius = 15;
            this.saveButton.BorderThickness = 1;
            this.saveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveButton.FillColor2 = System.Drawing.Color.DarkViolet;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.saveButton.Location = new System.Drawing.Point(12, 433);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(189, 33);
            this.saveButton.TabIndex = 147;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Animated = true;
            this.deleteButton.AutoRoundedCorners = true;
            this.deleteButton.BorderColor = System.Drawing.Color.DimGray;
            this.deleteButton.BorderRadius = 15;
            this.deleteButton.BorderThickness = 1;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor2 = System.Drawing.Color.DarkViolet;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.deleteButton.Location = new System.Drawing.Point(12, 497);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(189, 33);
            this.deleteButton.TabIndex = 146;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Animated = true;
            this.refreshButton.AutoRoundedCorners = true;
            this.refreshButton.BorderColor = System.Drawing.Color.DimGray;
            this.refreshButton.BorderRadius = 15;
            this.refreshButton.BorderThickness = 1;
            this.refreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refreshButton.FillColor2 = System.Drawing.Color.DarkViolet;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.refreshButton.Location = new System.Drawing.Point(12, 372);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(189, 33);
            this.refreshButton.TabIndex = 145;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click_1);
            // 
            // admEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1085, 586);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.insurPolicyTextBox);
            this.Controls.Add(this.insurNumTextBox);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(this.telNumTextBox);
            this.Controls.Add(this.fullnameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fullnameSTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.admRegBindingNavigator);
            this.Controls.Add(this.admRegDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "admEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администраторы и регистраторы (БД)";
            this.Load += new System.EventHandler(this.admEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admRegDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admregBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medinstAdmRegDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admRegBindingNavigator)).EndInit();
            this.admRegBindingNavigator.ResumeLayout(false);
            this.admRegBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView admRegDataGridView;
        private medinstAdmRegDataSet medinstAdmRegDataSet;
        private System.Windows.Forms.BindingSource admregBindingSource;
        private medinstAdmRegDataSetTableAdapters.adm_regTableAdapter adm_regTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurpolicyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acctypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator admRegBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GradientButton backButton;
        private Guna.UI2.WinForms.Guna2TextBox fullnameSTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox loginTextBox;
        private Guna.UI2.WinForms.Guna2TextBox insurPolicyTextBox;
        private Guna.UI2.WinForms.Guna2TextBox insurNumTextBox;
        private Guna.UI2.WinForms.Guna2TextBox passportTextBox;
        private Guna.UI2.WinForms.Guna2TextBox telNumTextBox;
        private Guna.UI2.WinForms.Guna2TextBox fullnameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox typeComboBox;
        private Guna.UI2.WinForms.Guna2GradientButton saveButton;
        private Guna.UI2.WinForms.Guna2GradientButton deleteButton;
        private Guna.UI2.WinForms.Guna2GradientButton refreshButton;
    }
}