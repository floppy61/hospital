namespace hospital
{
    partial class disEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(disEdit));
            this.label6 = new System.Windows.Forms.Label();
            this.catDisDataGridView = new System.Windows.Forms.DataGridView();
            this.iDcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catofdisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medinstCatDisDataSet = new hospital.medinstCatDisDataSet();
            this.cat_of_disTableAdapter = new hospital.medinstCatDisDataSetTableAdapters.cat_of_disTableAdapter();
            this.catDisBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.backButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.categoryTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.categorySTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.deleteButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.newRowButton = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.catDisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catofdisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medinstCatDisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catDisBindingNavigator)).BeginInit();
            this.catDisBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(73, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(345, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Категории заболеваний (база данных)";
            // 
            // catDisDataGridView
            // 
            this.catDisDataGridView.AutoGenerateColumns = false;
            this.catDisDataGridView.BackgroundColor = System.Drawing.Color.LightBlue;
            this.catDisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catDisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDcategoryDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.catDisDataGridView.DataSource = this.catofdisBindingSource;
            this.catDisDataGridView.Location = new System.Drawing.Point(12, 101);
            this.catDisDataGridView.Name = "catDisDataGridView";
            this.catDisDataGridView.Size = new System.Drawing.Size(406, 243);
            this.catDisDataGridView.TabIndex = 39;
            this.catDisDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catDisDataGridView_CellContentClick);
            this.catDisDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.catDisDataGridView_DataError);
            // 
            // iDcategoryDataGridViewTextBoxColumn
            // 
            this.iDcategoryDataGridViewTextBoxColumn.DataPropertyName = "ID_category";
            this.iDcategoryDataGridViewTextBoxColumn.HeaderText = "ID_category";
            this.iDcategoryDataGridViewTextBoxColumn.Name = "iDcategoryDataGridViewTextBoxColumn";
            this.iDcategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // catofdisBindingSource
            // 
            this.catofdisBindingSource.DataMember = "cat_of_dis";
            this.catofdisBindingSource.DataSource = this.medinstCatDisDataSet;
            // 
            // medinstCatDisDataSet
            // 
            this.medinstCatDisDataSet.DataSetName = "medinstCatDisDataSet";
            this.medinstCatDisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cat_of_disTableAdapter
            // 
            this.cat_of_disTableAdapter.ClearBeforeFill = true;
            // 
            // catDisBindingNavigator
            // 
            this.catDisBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.catDisBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.catDisBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.catDisBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.catDisBindingNavigator.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.catDisBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.catDisBindingNavigator.Location = new System.Drawing.Point(52, 347);
            this.catDisBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.catDisBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.catDisBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.catDisBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.catDisBindingNavigator.Name = "catDisBindingNavigator";
            this.catDisBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.catDisBindingNavigator.Size = new System.Drawing.Size(299, 32);
            this.catDisBindingNavigator.TabIndex = 40;
            this.catDisBindingNavigator.Text = "bindingNavigator1";
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
            this.backButton.Location = new System.Drawing.Point(12, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(47, 45);
            this.backButton.TabIndex = 107;
            this.backButton.Text = "←";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Animated = true;
            this.categoryTextBox.AutoRoundedCorners = true;
            this.categoryTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.categoryTextBox.BorderRadius = 15;
            this.categoryTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoryTextBox.DefaultText = "";
            this.categoryTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categoryTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categoryTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.categoryTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.categoryTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryTextBox.Location = new System.Drawing.Point(12, 411);
            this.categoryTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.PasswordChar = '\0';
            this.categoryTextBox.PlaceholderText = "";
            this.categoryTextBox.SelectedText = "";
            this.categoryTextBox.Size = new System.Drawing.Size(406, 33);
            this.categoryTextBox.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 108;
            this.label2.Text = "Категория:";
            // 
            // refreshButton
            // 
            this.refreshButton.Animated = true;
            this.refreshButton.AutoRoundedCorners = true;
            this.refreshButton.BorderColor = System.Drawing.Color.DimGray;
            this.refreshButton.BorderRadius = 16;
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
            this.refreshButton.Location = new System.Drawing.Point(12, 452);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(105, 34);
            this.refreshButton.TabIndex = 112;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // categorySTextBox
            // 
            this.categorySTextBox.Animated = true;
            this.categorySTextBox.AutoRoundedCorners = true;
            this.categorySTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.categorySTextBox.BorderRadius = 15;
            this.categorySTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categorySTextBox.DefaultText = "";
            this.categorySTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categorySTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categorySTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categorySTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categorySTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorySTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.categorySTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.categorySTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorySTextBox.Location = new System.Drawing.Point(90, 60);
            this.categorySTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.categorySTextBox.Name = "categorySTextBox";
            this.categorySTextBox.PasswordChar = '\0';
            this.categorySTextBox.PlaceholderText = "";
            this.categorySTextBox.SelectedText = "";
            this.categorySTextBox.Size = new System.Drawing.Size(328, 33);
            this.categorySTextBox.TabIndex = 113;
            this.categorySTextBox.TextChanged += new System.EventHandler(this.categorySTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 114;
            this.label1.Text = "Поиск:";
            // 
            // saveButton
            // 
            this.saveButton.Animated = true;
            this.saveButton.AutoRoundedCorners = true;
            this.saveButton.BorderColor = System.Drawing.Color.DimGray;
            this.saveButton.BorderRadius = 16;
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
            this.saveButton.Location = new System.Drawing.Point(123, 452);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(201, 34);
            this.saveButton.TabIndex = 115;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Animated = true;
            this.deleteButton.AutoRoundedCorners = true;
            this.deleteButton.BorderColor = System.Drawing.Color.DimGray;
            this.deleteButton.BorderRadius = 16;
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
            this.deleteButton.Location = new System.Drawing.Point(330, 452);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 34);
            this.deleteButton.TabIndex = 116;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // newRowButton
            // 
            this.newRowButton.Animated = true;
            this.newRowButton.AutoRoundedCorners = true;
            this.newRowButton.BorderColor = System.Drawing.Color.DimGray;
            this.newRowButton.BorderRadius = 16;
            this.newRowButton.BorderThickness = 1;
            this.newRowButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.newRowButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.newRowButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.newRowButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.newRowButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.newRowButton.FillColor2 = System.Drawing.Color.DarkViolet;
            this.newRowButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newRowButton.ForeColor = System.Drawing.Color.White;
            this.newRowButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.newRowButton.Location = new System.Drawing.Point(12, 492);
            this.newRowButton.Name = "newRowButton";
            this.newRowButton.Size = new System.Drawing.Size(406, 34);
            this.newRowButton.TabIndex = 117;
            this.newRowButton.Text = "Создать новую запись";
            this.newRowButton.Click += new System.EventHandler(this.newRowButton_Click);
            // 
            // disEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(432, 535);
            this.Controls.Add(this.newRowButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categorySTextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.catDisBindingNavigator);
            this.Controls.Add(this.catDisDataGridView);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "disEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Категории заболеваний (БД)";
            this.Load += new System.EventHandler(this.disEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catDisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catofdisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medinstCatDisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catDisBindingNavigator)).EndInit();
            this.catDisBindingNavigator.ResumeLayout(false);
            this.catDisBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView catDisDataGridView;
        private medinstCatDisDataSet medinstCatDisDataSet;
        private System.Windows.Forms.BindingSource catofdisBindingSource;
        private medinstCatDisDataSetTableAdapters.cat_of_disTableAdapter cat_of_disTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator catDisBindingNavigator;
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
        private Guna.UI2.WinForms.Guna2GradientButton backButton;
        private Guna.UI2.WinForms.Guna2TextBox categoryTextBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton refreshButton;
        private Guna.UI2.WinForms.Guna2TextBox categorySTextBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton saveButton;
        private Guna.UI2.WinForms.Guna2GradientButton deleteButton;
        private Guna.UI2.WinForms.Guna2GradientButton newRowButton;
    }
}