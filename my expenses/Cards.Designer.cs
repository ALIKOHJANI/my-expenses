namespace my_expenses
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
            CardsListBox = new ListBox();
            Cardsbutton = new Button();
            label1 = new Label();
            label2 = new Label();
            AddCardsButton = new Button();
            BackButton = new Button();
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
            // CardsListBox
            // 
            CardsListBox.FormattingEnabled = true;
            CardsListBox.ItemHeight = 15;
            CardsListBox.Location = new Point(104, 74);
            CardsListBox.Name = "CardsListBox";
            CardsListBox.Size = new Size(248, 244);
            CardsListBox.TabIndex = 1;
            CardsListBox.SelectedIndexChanged += CardsListBox_SelectedIndexChanged;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("B Nazanin", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(166, 321);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 3;
            label1.Text = "!کارت بانکی ندارید";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(119, 349);
            label2.Name = "label2";
            label2.Size = new Size(213, 23);
            label2.TabIndex = 4;
            label2.Text = "میتوانید کارت  بانکی  خود   را  اضافه کنید";
            // 
            // AddCardsButton
            // 
            AddCardsButton.BackColor = SystemColors.MenuHighlight;
            AddCardsButton.FlatStyle = FlatStyle.Popup;
            AddCardsButton.Font = new Font("B Nazanin", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddCardsButton.Location = new Point(58, 387);
            AddCardsButton.Name = "AddCardsButton";
            AddCardsButton.Size = new Size(317, 44);
            AddCardsButton.TabIndex = 5;
            AddCardsButton.Text = "افزودن کارت بانکی";
            AddCardsButton.UseVisualStyleBackColor = false;
            AddCardsButton.Click += AddCardsButton_Click;
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
            // Cards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(427, 470);
            Controls.Add(BackButton);
            Controls.Add(AddCardsButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cardsbutton);
            Controls.Add(CardsListBox);
            Controls.Add(Cardslabel);
            Name = "Cards";
            Text = "کارت های شما";
            Load += Cards_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Cardslabel;
        private ListBox CardsListBox;
        private Button Cardsbutton;
        private Label label1;
        private Label label2;
        private Button AddCardsButton;
        private Button BackButton;
    }
}