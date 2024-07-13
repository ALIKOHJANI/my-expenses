namespace my_expenses
{
    partial class Addcard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addcard));
            bankComboBox = new ComboBox();
            label1 = new Label();
            CardNumberBox = new TextBox();
            label2 = new Label();
            CardNameBox = new TextBox();
            label3 = new Label();
            Entrybutton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // bankComboBox
            // 
            bankComboBox.FormattingEnabled = true;
            bankComboBox.Items.AddRange(new object[] { "ملی", "ملت", "سپه", "تجارت", "پارسیان", "پاسارگاد", "سامان", "سینا", "اینده", "اقتصاد نوین", "رفاه", "رسالت", "مهر اقتصاد", "صادرات", "شهر", "ارمان", "قوامین", "ایران زمین", "کشاورزی", "کوثر", "نور", "توسعه و تعاون", "تات", "پست بانک", "مهر ایران", "مرکزی", "خاورمیانه", "کارافرین", "حکمت ایرنیان", "گردشگری", "دی", "انصار", "مسکن", "بلو بانک", "سرمایه" });
            bankComboBox.Location = new Point(12, 84);
            bankComboBox.Name = "bankComboBox";
            bankComboBox.Size = new Size(256, 23);
            bankComboBox.TabIndex = 0;
            bankComboBox.SelectedIndexChanged += bankComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(238, 61);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 1;
            label1.Text = "بانک";
            // 
            // CardNumberBox
            // 
            CardNumberBox.Location = new Point(12, 193);
            CardNumberBox.Name = "CardNumberBox";
            CardNumberBox.Size = new Size(256, 23);
            CardNumberBox.TabIndex = 2;
            CardNumberBox.TextChanged += CardNumberBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(204, 170);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "شماره کارت";
            // 
            // CardNameBox
            // 
            CardNameBox.Location = new Point(12, 270);
            CardNameBox.Name = "CardNameBox";
            CardNameBox.Size = new Size(256, 23);
            CardNameBox.TabIndex = 4;
            CardNameBox.TextAlign = HorizontalAlignment.Right;
            CardNameBox.TextChanged += CardNameBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(164, 247);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 5;
            label3.Text = "نام کارت را وارد کنید";
            // 
            // Entrybutton
            // 
            Entrybutton.Location = new Point(12, 331);
            Entrybutton.Name = "Entrybutton";
            Entrybutton.Size = new Size(256, 38);
            Entrybutton.TabIndex = 6;
            Entrybutton.Text = "ثبت کارت";
            Entrybutton.UseVisualStyleBackColor = true;
            Entrybutton.Click += Entrybutton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 7;
            backButton.Text = "بازگشت";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // Addcard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(282, 400);
            Controls.Add(backButton);
            Controls.Add(Entrybutton);
            Controls.Add(label3);
            Controls.Add(CardNameBox);
            Controls.Add(label2);
            Controls.Add(CardNumberBox);
            Controls.Add(label1);
            Controls.Add(bankComboBox);
            Name = "Addcard";
            Text = "اضافه کردن کارت";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox bankComboBox;
        private Label label1;
        private TextBox CardNumberBox;
        private Label label2;
        private TextBox CardNameBox;
        private Label label3;
        private Button Entrybutton;
        private Button backButton;
    }
}