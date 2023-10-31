namespace hospital
{
    partial class auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(auth));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.helloLabel = new System.Windows.Forms.Label();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.cleanButton = new Guna.UI2.WinForms.Guna2Button();
            this.seeButton = new Guna.UI2.WinForms.Guna2Button();
            this.aboutButton = new Guna.UI2.WinForms.Guna2Button();
            this.gifPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gifPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(262, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Animated = true;
            this.loginTextBox.AutoRoundedCorners = true;
            this.loginTextBox.BorderRadius = 13;
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
            this.loginTextBox.Location = new System.Drawing.Point(80, 218);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PasswordChar = '\0';
            this.loginTextBox.PlaceholderText = "";
            this.loginTextBox.SelectedText = "";
            this.loginTextBox.Size = new System.Drawing.Size(183, 29);
            this.loginTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Animated = true;
            this.passwordTextBox.AutoRoundedCorners = true;
            this.passwordTextBox.BorderRadius = 13;
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
            this.passwordTextBox.Location = new System.Drawing.Point(341, 218);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderText = "";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(183, 29);
            this.passwordTextBox.TabIndex = 10;
            // 
            // helloLabel
            // 
            this.helloLabel.BackColor = System.Drawing.Color.Transparent;
            this.helloLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helloLabel.Location = new System.Drawing.Point(32, 44);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(288, 208);
            this.helloLabel.TabIndex = 12;
            this.helloLabel.Text = "Добро пожаловать в систему учёта пациентов «МедУчИнфо»!";
            // 
            // loginButton
            // 
            this.loginButton.Animated = true;
            this.loginButton.AutoRoundedCorners = true;
            this.loginButton.BorderColor = System.Drawing.Color.DimGray;
            this.loginButton.BorderRadius = 14;
            this.loginButton.BorderThickness = 1;
            this.loginButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(118, 255);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(319, 31);
            this.loginButton.TabIndex = 13;
            this.loginButton.Text = "Войти";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Animated = true;
            this.cleanButton.AutoRoundedCorners = true;
            this.cleanButton.BorderColor = System.Drawing.Color.DimGray;
            this.cleanButton.BorderRadius = 14;
            this.cleanButton.BorderThickness = 1;
            this.cleanButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cleanButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cleanButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cleanButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cleanButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cleanButton.ForeColor = System.Drawing.Color.White;
            this.cleanButton.Location = new System.Drawing.Point(12, 255);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(100, 31);
            this.cleanButton.TabIndex = 14;
            this.cleanButton.Text = "Очистить";
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // seeButton
            // 
            this.seeButton.Animated = true;
            this.seeButton.AutoRoundedCorners = true;
            this.seeButton.BackColor = System.Drawing.Color.Transparent;
            this.seeButton.BorderColor = System.Drawing.Color.DimGray;
            this.seeButton.BorderRadius = 14;
            this.seeButton.BorderThickness = 1;
            this.seeButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.seeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.seeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.seeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.seeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.seeButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.seeButton.ForeColor = System.Drawing.Color.White;
            this.seeButton.Location = new System.Drawing.Point(532, 216);
            this.seeButton.Name = "seeButton";
            this.seeButton.Size = new System.Drawing.Size(40, 31);
            this.seeButton.TabIndex = 15;
            this.seeButton.Text = "👁";
            this.seeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.seeButton_MouseDown);
            this.seeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.seeButton_MouseUp);
            // 
            // aboutButton
            // 
            this.aboutButton.Animated = true;
            this.aboutButton.AutoRoundedCorners = true;
            this.aboutButton.BackColor = System.Drawing.Color.Transparent;
            this.aboutButton.BorderColor = System.Drawing.Color.DimGray;
            this.aboutButton.BorderRadius = 14;
            this.aboutButton.BorderThickness = 1;
            this.aboutButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aboutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.aboutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.aboutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.aboutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.Location = new System.Drawing.Point(443, 255);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(130, 31);
            this.aboutButton.TabIndex = 16;
            this.aboutButton.Text = "О программе";
            this.aboutButton.UseTransparentBackground = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // gifPictureBox
            // 
            this.gifPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.gifPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("gifPictureBox.Image")));
            this.gifPictureBox.ImageRotate = 0F;
            this.gifPictureBox.Location = new System.Drawing.Point(-9, -23);
            this.gifPictureBox.Name = "gifPictureBox";
            this.gifPictureBox.Size = new System.Drawing.Size(867, 291);
            this.gifPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gifPictureBox.TabIndex = 17;
            this.gifPictureBox.TabStop = false;
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(586, 303);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.seeButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gifPictureBox);
            this.Controls.Add(this.helloLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация в «МедУчИнфо»";
            this.Load += new System.EventHandler(this.auth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gifPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox loginTextBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private System.Windows.Forms.Label helloLabel;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2Button cleanButton;
        private Guna.UI2.WinForms.Guna2Button seeButton;
        private Guna.UI2.WinForms.Guna2Button aboutButton;
        private Guna.UI2.WinForms.Guna2PictureBox gifPictureBox;
    }
}

