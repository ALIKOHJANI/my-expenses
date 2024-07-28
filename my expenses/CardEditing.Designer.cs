namespace my_expenses
{
    partial class CardEditing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardEditing));
            backButton = new Button();
            Entrybutton = new Button();
            label3 = new Label();
            CardNameBox = new TextBox();
            label2 = new Label();
            CardNumberBox = new TextBox();
            label1 = new Label();
            bankComboBox = new ComboBox();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 7);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 15;
            backButton.Text = "بازگشت";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // Entrybutton
            // 
            Entrybutton.Location = new Point(12, 326);
            Entrybutton.Name = "Entrybutton";
            Entrybutton.Size = new Size(256, 38);
            Entrybutton.TabIndex = 14;
            Entrybutton.Text = "ثبت کارت";
            Entrybutton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(164, 242);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 13;
            label3.Text = "نام کارت را وارد کنید";
            // 
            // CardNameBox
            // 
            CardNameBox.Location = new Point(12, 265);
            CardNameBox.Name = "CardNameBox";
            CardNameBox.RightToLeft = RightToLeft.Yes;
            CardNameBox.Size = new Size(256, 23);
            CardNameBox.TabIndex = 12;
            CardNameBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(204, 165);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 11;
            label2.Text = "شماره کارت";
            // 
            // CardNumberBox
            // 
            CardNumberBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CardNumberBox.Location = new Point(12, 188);
            CardNumberBox.MaxLength = 16;
            CardNumberBox.Name = "CardNumberBox";
            CardNumberBox.Size = new Size(256, 23);
            CardNumberBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(238, 56);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 9;
            label1.Text = "بانک";
            // 
            // bankComboBox
            // 
            bankComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            bankComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            bankComboBox.FormattingEnabled = true;
            bankComboBox.Items.AddRange(new object[] { "ملی", "ملت", "سپه", "تجارت", "پارسیان", "پاسارگاد", "سامان", "سینا", "اینده", "اقتصاد نوین", "رفاه", "رسالت", "مهر اقتصاد", "صادرات", "شهر", "ارمان", "قوامین", "ایران زمین", "کشاورزی", "کوثر", "نور", "توسعه و تعاون", "تات", "پست بانک", "مهر ایران", "مرکزی", "خاورمیانه", "کارافرین", "حکمت ایرنیان", "گردشگری", "دی", "انصار", "مسکن", "بلو بانک", "سرمایه" });
            bankComboBox.Location = new Point(12, 79);
            bankComboBox.Name = "bankComboBox";
            bankComboBox.RightToLeft = RightToLeft.Yes;
            bankComboBox.Size = new Size(256, 23);
            bankComboBox.TabIndex = 8;
            // 
            // CardEditing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(289, 379);
            Controls.Add(backButton);
            Controls.Add(Entrybutton);
            Controls.Add(label3);
            Controls.Add(CardNameBox);
            Controls.Add(label2);
            Controls.Add(CardNumberBox);
            Controls.Add(label1);
            Controls.Add(bankComboBox);
            Name = "CardEditing";
            Text = "CardEditing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Button Entrybutton;
        private Label label3;
        private TextBox CardNameBox;
        private Label label2;
        private TextBox CardNumberBox;
        private Label label1;
        private ComboBox bankComboBox;
    }
}