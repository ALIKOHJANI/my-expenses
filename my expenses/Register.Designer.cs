namespace myExpenses
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            FirtsNameLabel = new Label();
            LastNameLabel = new Label();
            NationalIdLabel = new Label();
            DateOfBirthLabel = new Label();
            GenderLabel = new Label();
            PhoneNumberLabel = new Label();
            PasswordLabel = new Label();
            FirtsNameBox = new TextBox();
            LastNameBox = new TextBox();
            PasswordBox = new TextBox();
            Entrybutton = new Button();
            label1 = new Label();
            GenderButtonMan = new RadioButton();
            GenderButtonWoman = new RadioButton();
            ComingBackButton = new Button();
            DateOfBirthBox = new MaskedTextBox();
            PhoneNumberBox = new MaskedTextBox();
            NationalIdBox = new TextBox();
            SuspendLayout();
            // 
            // FirtsNameLabel
            // 
            FirtsNameLabel.AutoSize = true;
            FirtsNameLabel.BackColor = Color.Transparent;
            FirtsNameLabel.ForeColor = SystemColors.ButtonHighlight;
            FirtsNameLabel.Location = new Point(227, 22);
            FirtsNameLabel.Name = "FirtsNameLabel";
            FirtsNameLabel.Size = new Size(142, 15);
            FirtsNameLabel.TabIndex = 9;
            FirtsNameLabel.Text = ":نام کوچک خود را وارد نمایید";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.BackColor = Color.Transparent;
            LastNameLabel.ForeColor = SystemColors.ButtonHighlight;
            LastNameLabel.Location = new Point(212, 56);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(157, 15);
            LastNameLabel.TabIndex = 10;
            LastNameLabel.Text = ":نام خانوادگی خود را وارد نمایید";
            // 
            // NationalIdLabel
            // 
            NationalIdLabel.AutoSize = true;
            NationalIdLabel.BackColor = Color.Transparent;
            NationalIdLabel.ForeColor = SystemColors.ButtonHighlight;
            NationalIdLabel.Location = new Point(238, 93);
            NationalIdLabel.Name = "NationalIdLabel";
            NationalIdLabel.Size = new Size(131, 15);
            NationalIdLabel.TabIndex = 11;
            NationalIdLabel.Text = ":کد ملی خود را وارد نمایید";
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.BackColor = Color.Transparent;
            DateOfBirthLabel.ForeColor = SystemColors.ButtonHighlight;
            DateOfBirthLabel.Location = new Point(227, 130);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(142, 15);
            DateOfBirthLabel.TabIndex = 12;
            DateOfBirthLabel.Text = ":تاریخ تولد خود را وارد نمایید";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.BackColor = Color.Transparent;
            GenderLabel.ForeColor = SystemColors.ButtonHighlight;
            GenderLabel.Location = new Point(238, 165);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(131, 15);
            GenderLabel.TabIndex = 13;
            GenderLabel.Text = ":جنسیت خود را وارد نمایید";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.BackColor = Color.Transparent;
            PhoneNumberLabel.ForeColor = SystemColors.Info;
            PhoneNumberLabel.Location = new Point(213, 200);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(156, 15);
            PhoneNumberLabel.TabIndex = 14;
            PhoneNumberLabel.Text = ":شماره تلفون خود را وارد نمایید";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.ForeColor = SystemColors.Control;
            PasswordLabel.Location = new Point(227, 234);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(139, 15);
            PasswordLabel.TabIndex = 15;
            PasswordLabel.Text = ":رمز عبور  خود را وارد نمایید";
            // 
            // FirtsNameBox
            // 
            FirtsNameBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            FirtsNameBox.Location = new Point(38, 19);
            FirtsNameBox.Name = "FirtsNameBox";
            FirtsNameBox.RightToLeft = RightToLeft.Yes;
            FirtsNameBox.Size = new Size(123, 23);
            FirtsNameBox.TabIndex = 0;
            FirtsNameBox.TextChanged += FirtsNameBox_TextChanged;
            FirtsNameBox.KeyPress += FirtsNameBox_KeyPress;
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(38, 53);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.RightToLeft = RightToLeft.Yes;
            LastNameBox.Size = new Size(123, 23);
            LastNameBox.TabIndex = 1;
            LastNameBox.TextChanged += LastNameBox_TextChanged;
            LastNameBox.KeyPress += LastNameBox_KeyPress;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(38, 231);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(123, 23);
            PasswordBox.TabIndex = 7;
            PasswordBox.TextChanged += PasswordBox_TextChanged;
            // 
            // Entrybutton
            // 
            Entrybutton.BackgroundImage = (Image)resources.GetObject("Entrybutton.BackgroundImage");
            Entrybutton.BackgroundImageLayout = ImageLayout.Zoom;
            Entrybutton.Location = new Point(227, 277);
            Entrybutton.Name = "Entrybutton";
            Entrybutton.Size = new Size(123, 49);
            Entrybutton.TabIndex = 8;
            Entrybutton.UseVisualStyleBackColor = true;
            Entrybutton.Click += Entrybutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(38, 257);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 16;
            label1.Click += label1_Click;
            // 
            // GenderButtonMan
            // 
            GenderButtonMan.AutoSize = true;
            GenderButtonMan.BackColor = Color.Transparent;
            GenderButtonMan.ForeColor = SystemColors.ButtonHighlight;
            GenderButtonMan.Location = new Point(38, 156);
            GenderButtonMan.Name = "GenderButtonMan";
            GenderButtonMan.Size = new Size(42, 19);
            GenderButtonMan.TabIndex = 4;
            GenderButtonMan.TabStop = true;
            GenderButtonMan.Text = "مرد";
            GenderButtonMan.UseVisualStyleBackColor = false;
            GenderButtonMan.CheckedChanged += GenderButtonMan_CheckedChanged;
            // 
            // GenderButtonWoman
            // 
            GenderButtonWoman.AutoSize = true;
            GenderButtonWoman.BackColor = Color.Transparent;
            GenderButtonWoman.ForeColor = SystemColors.ButtonHighlight;
            GenderButtonWoman.Location = new Point(38, 175);
            GenderButtonWoman.Name = "GenderButtonWoman";
            GenderButtonWoman.Size = new Size(38, 19);
            GenderButtonWoman.TabIndex = 5;
            GenderButtonWoman.TabStop = true;
            GenderButtonWoman.Text = "زن";
            GenderButtonWoman.UseVisualStyleBackColor = false;
            GenderButtonWoman.CheckedChanged += GenderButtonWoman_CheckedChanged;
            // 
            // ComingBackButton
            // 
            ComingBackButton.Location = new Point(12, 291);
            ComingBackButton.Name = "ComingBackButton";
            ComingBackButton.Size = new Size(108, 35);
            ComingBackButton.TabIndex = 16;
            ComingBackButton.Text = "بازگشت";
            ComingBackButton.UseVisualStyleBackColor = true;
            ComingBackButton.Click += ComingBackButton_Click;
            // 
            // DateOfBirthBox
            // 
            DateOfBirthBox.Location = new Point(38, 127);
            DateOfBirthBox.Mask = "0000/00/00";
            DateOfBirthBox.Name = "DateOfBirthBox";
            DateOfBirthBox.Size = new Size(123, 23);
            DateOfBirthBox.TabIndex = 3;
            DateOfBirthBox.ValidatingType = typeof(DateTime);
            DateOfBirthBox.TextChanged += DateOfBirthBox_TextChanged;
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Location = new Point(38, 200);
            PhoneNumberBox.Mask = "(0000)0000000";
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new Size(123, 23);
            PhoneNumberBox.TabIndex = 6;
            PhoneNumberBox.TextAlignChanged += PhoneNumberBox_TextChanged;
            // 
            // NationalIdBox
            // 
            NationalIdBox.Location = new Point(38, 85);
            NationalIdBox.MaxLength = 10;
            NationalIdBox.Name = "NationalIdBox";
            NationalIdBox.Size = new Size(123, 23);
            NationalIdBox.TabIndex = 2;
            NationalIdBox.TextChanged += NationalIdBox_TextChanged_1;
            NationalIdBox.KeyPress += NationalIdBox_KeyPress;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(381, 338);
            Controls.Add(NationalIdBox);
            Controls.Add(PhoneNumberBox);
            Controls.Add(DateOfBirthBox);
            Controls.Add(ComingBackButton);
            Controls.Add(GenderButtonWoman);
            Controls.Add(GenderButtonMan);
            Controls.Add(label1);
            Controls.Add(Entrybutton);
            Controls.Add(PasswordBox);
            Controls.Add(LastNameBox);
            Controls.Add(FirtsNameBox);
            Controls.Add(PasswordLabel);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(GenderLabel);
            Controls.Add(DateOfBirthLabel);
            Controls.Add(NationalIdLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirtsNameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ثبت نام";
            Load += Register_Load;
            KeyPress += Register_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }






        #endregion

        private Label FirtsNameLabel;
        private Label LastNameLabel;
        private Label NationalIdLabel;
        private Label DateOfBirthLabel;
        private Label GenderLabel;
        private Label PhoneNumberLabel;
        private Label PasswordLabel;
        private TextBox FirtsNameBox;
        private TextBox LastNameBox;
        private TextBox PasswordBox;
        private Button Entrybutton;
        private Label label1;
        private RadioButton GenderButtonMan;
        private RadioButton GenderButtonWoman;
        private Button ComingBackButton;
        private MaskedTextBox DateOfBirthBox;
        private MaskedTextBox PhoneNumberBox;
        private TextBox NationalIdBox;
    }
}