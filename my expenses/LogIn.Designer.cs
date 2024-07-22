namespace myExpenses
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            NationalIdLabel = new Label();
            logInButton = new Button();
            PasswordBax = new TextBox();
            PasswordLabel = new Label();
            RegisterButton = new Button();
            ForgotPasswordButton = new Button();
            NationalIdBox = new TextBox();
            SuspendLayout();
            // 
            // NationalIdLabel
            // 
            NationalIdLabel.Anchor = AnchorStyles.None;
            NationalIdLabel.BackColor = Color.Transparent;
            NationalIdLabel.CausesValidation = false;
            NationalIdLabel.FlatStyle = FlatStyle.Flat;
            NationalIdLabel.ForeColor = SystemColors.Info;
            NationalIdLabel.ImageAlign = ContentAlignment.MiddleRight;
            NationalIdLabel.ImeMode = ImeMode.NoControl;
            NationalIdLabel.Location = new Point(136, 14);
            NationalIdLabel.Name = "NationalIdLabel";
            NationalIdLabel.Size = new Size(122, 20);
            NationalIdLabel.TabIndex = 4;
            NationalIdLabel.Text = ":شماره ملی خود را وارد کنید";
            NationalIdLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // logInButton
            // 
            logInButton.Location = new Point(12, 117);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(90, 34);
            logInButton.TabIndex = 2;
            logInButton.Text = "ورود";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // PasswordBax
            // 
            PasswordBax.Location = new Point(12, 47);
            PasswordBax.Name = "PasswordBax";
            PasswordBax.PasswordChar = '*';
            PasswordBax.Size = new Size(114, 27);
            PasswordBax.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.None;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.CausesValidation = false;
            PasswordLabel.FlatStyle = FlatStyle.Flat;
            PasswordLabel.ForeColor = SystemColors.InactiveBorder;
            PasswordLabel.ImageAlign = ContentAlignment.MiddleRight;
            PasswordLabel.ImeMode = ImeMode.NoControl;
            PasswordLabel.Location = new Point(137, 55);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(121, 20);
            PasswordLabel.TabIndex = 16;
            PasswordLabel.Text = "رمز خود را وارد کنید";
            PasswordLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(170, 117);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(90, 34);
            RegisterButton.TabIndex = 4;
            RegisterButton.Text = "ثبت نام";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // ForgotPasswordButton
            // 
            ForgotPasswordButton.Location = new Point(90, 80);
            ForgotPasswordButton.Name = "ForgotPasswordButton";
            ForgotPasswordButton.Size = new Size(90, 34);
            ForgotPasswordButton.TabIndex = 3;
            ForgotPasswordButton.Text = "فراموشی رمز عبور";
            ForgotPasswordButton.UseVisualStyleBackColor = true;
            ForgotPasswordButton.Click += ForgotPasswordButton_Click;
            // 
            // NationalIdBox
            // 
            NationalIdBox.Location = new Point(12, 11);
            NationalIdBox.MaxLength = 10;
            NationalIdBox.Name = "NationalIdBox";
            NationalIdBox.Size = new Size(114, 27);
            NationalIdBox.TabIndex = 0;
            NationalIdBox.KeyPress += NationalIdBox_KeyPress;
            // 
            // LogIn
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.Disable;
            BackColor = SystemColors.InactiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(268, 171);
            Controls.Add(NationalIdBox);
            Controls.Add(ForgotPasswordButton);
            Controls.Add(RegisterButton);
            Controls.Add(PasswordBax);
            Controls.Add(PasswordLabel);
            Controls.Add(logInButton);
            Controls.Add(NationalIdLabel);
            Font = new Font("B Roya", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.InfoText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label NationalIdLabel;
        private Button logInButton;
        private TextBox PasswordBax;
        private Label PasswordLabel;
        private Button RegisterButton;
        private Button ForgotPasswordButton;
        private TextBox NationalIdBox;
    }
}