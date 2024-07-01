namespace my_expenses
{
    partial class reporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reporting));
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            GroupingBox = new ComboBox();
            CardBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            Back = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "گزارش کلی", "گزارش ماهانه", "گزارش بازه دلخواه" });
            comboBox1.Location = new Point(88, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(248, 93);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 1;
            label1.Text = "نوع گذارش";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "فروردین", "اردیهشت", " خرداد", "تیر", "مرداد", "شهریور", "مهر", "ابان", "اذر ", "دی", "بهمن", "اسفند" });
            comboBox2.Location = new Point(88, 189);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(222, 23);
            comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(243, 163);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 3;
            label2.Text = "انتخواب ماه ";
            // 
            // GroupingBox
            // 
            GroupingBox.FormattingEnabled = true;
            GroupingBox.Items.AddRange(new object[] { "پوشاک", "خوراکی", "وسایل خانه", "تفریح", "حمل و نقل", "خرید روزانه", "بهداشت و سلامت", "اموزش و تحصیلات" });
            GroupingBox.Location = new Point(226, 279);
            GroupingBox.Name = "GroupingBox";
            GroupingBox.Size = new Size(138, 23);
            GroupingBox.TabIndex = 4;
            // 
            // CardBox
            // 
            CardBox.FormattingEnabled = true;
            CardBox.Location = new Point(31, 279);
            CardBox.Name = "CardBox";
            CardBox.Size = new Size(138, 23);
            CardBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(297, 253);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 6;
            label3.Text = "دسته بندی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(87, 253);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 7;
            label4.Text = "انتخواب   کارت";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("B Nazanin", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(49, 363);
            button1.Name = "button1";
            button1.Size = new Size(291, 38);
            button1.TabIndex = 8;
            button1.Text = "گزارش  گیری";
            button1.UseVisualStyleBackColor = false;
            // 
            // Back
            // 
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 9;
            Back.Text = "بازگشت";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // reporting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(395, 454);
            Controls.Add(Back);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CardBox);
            Controls.Add(GroupingBox);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            MaximizeBox = false;
            Name = "reporting";
            Text = "گزارش گیری";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox GroupingBox;
        private ComboBox CardBox;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button Back;
    }
}