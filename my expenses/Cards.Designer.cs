namespace myExpenses
{
    partial class Cards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cards));
            Cardslabel = new Label();
            Cardsbutton = new Button();
            ErrorLabel1 = new Label();
            ErrorLabel2 = new Label();
            BackButton = new Button();
            CardsListBox = new DataGridView();
            CardNumber = new DataGridViewTextBoxColumn();
            Bank = new DataGridViewTextBoxColumn();
            CardName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)CardsListBox).BeginInit();
            SuspendLayout();
            // 
            // Cardslabel
            // 
            Cardslabel.AutoSize = true;
            Cardslabel.BackColor = Color.Transparent;
            Cardslabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Cardslabel.ForeColor = SystemColors.ButtonFace;
            Cardslabel.Location = new Point(316, 38);
            Cardslabel.Name = "Cardslabel";
            Cardslabel.Size = new Size(99, 20);
            Cardslabel.TabIndex = 0;
            Cardslabel.Text = "کارت های شما";
            // 
            // Cardsbutton
            // 
            Cardsbutton.BackColor = SystemColors.ControlLightLight;
            Cardsbutton.Font = new Font("B Nazanin", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cardsbutton.Location = new Point(12, 32);
            Cardsbutton.Name = "Cardsbutton";
            Cardsbutton.Size = new Size(120, 36);
            Cardsbutton.TabIndex = 2;
            Cardsbutton.Text = "+افزودن کارت";
            Cardsbutton.UseVisualStyleBackColor = false;
            Cardsbutton.Click += Cardsbutton_Click;
            // 
            // ErrorLabel1
            // 
            ErrorLabel1.AutoSize = true;
            ErrorLabel1.BackColor = Color.Transparent;
            ErrorLabel1.Font = new Font("B Nazanin", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorLabel1.ForeColor = Color.DarkOrange;
            ErrorLabel1.Location = new Point(157, 280);
            ErrorLabel1.Name = "ErrorLabel1";
            ErrorLabel1.Size = new Size(119, 28);
            ErrorLabel1.TabIndex = 3;
            ErrorLabel1.Text = "!کارت بانکی ندارید";
            // 
            // ErrorLabel2
            // 
            ErrorLabel2.AutoSize = true;
            ErrorLabel2.BackColor = Color.Transparent;
            ErrorLabel2.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorLabel2.ForeColor = Color.DarkOrange;
            ErrorLabel2.Location = new Point(110, 308);
            ErrorLabel2.Name = "ErrorLabel2";
            ErrorLabel2.Size = new Size(213, 23);
            ErrorLabel2.TabIndex = 4;
            ErrorLabel2.Text = "میتوانید کارت  بانکی  خود   را  اضافه کنید";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(340, 6);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 6;
            BackButton.Text = "بازگشت";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // CardsListBox
            // 
            CardsListBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CardsListBox.Columns.AddRange(new DataGridViewColumn[] { CardNumber, Bank, CardName });
            CardsListBox.Location = new Point(47, 106);
            CardsListBox.Name = "CardsListBox";
            CardsListBox.RightToLeft = RightToLeft.Yes;
            CardsListBox.RowTemplate.Height = 25;
            CardsListBox.Size = new Size(343, 150);
            CardsListBox.TabIndex = 7;
            // 
            // CardNumber
            // 
            CardNumber.HeaderText = "شماره کارت";
            CardNumber.Name = "CardNumber";
            CardNumber.ReadOnly = true;
            // 
            // Bank
            // 
            Bank.HeaderText = "بانک";
            Bank.Name = "Bank";
            Bank.ReadOnly = true;
            // 
            // CardName
            // 
            CardName.HeaderText = "نام کارت";
            CardName.Name = "CardName";
            CardName.ReadOnly = true;
            // 
            // Cards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(427, 364);
            ControlBox = false;
            Controls.Add(CardsListBox);
            Controls.Add(BackButton);
            Controls.Add(ErrorLabel2);
            Controls.Add(ErrorLabel1);
            Controls.Add(Cardsbutton);
            Controls.Add(Cardslabel);
            Name = "Cards";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "کارت های شما";
            FormClosed += Cards_FormClosed;
            Load += Cards_Load;
            ((System.ComponentModel.ISupportInitialize)CardsListBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Cardslabel;
        private Button Cardsbutton;
        private Label ErrorLabel1;
        private Label ErrorLabel2;
        private Button BackButton;
        private DataGridView CardsListBox;
        private DataGridViewTextBoxColumn CardNumber;
        private DataGridViewTextBoxColumn Bank;
        private DataGridViewTextBoxColumn CardName;
    }
}