namespace my_expenses
{
    partial class AddingExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingExpenses));
            AmountBox = new TextBox();
            label1 = new Label();
            GroupingBox = new ComboBox();
            label2 = new Label();
            CardNumberBox = new ComboBox();
            CardNumberlabel = new Label();
            DescriptionBox = new RichTextBox();
            Descriptionlabel = new Label();
            button1 = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // AmountBox
            // 
            AmountBox.Location = new Point(194, 77);
            AmountBox.Margin = new Padding(4, 5, 4, 5);
            AmountBox.Name = "AmountBox";
            AmountBox.Size = new Size(229, 30);
            AmountBox.TabIndex = 0;
            AmountBox.TextChanged += AmountBox_TextChanged;
            AmountBox.KeyPress += AmountBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(392, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 23);
            label1.TabIndex = 1;
            label1.Text = "مبلغ";
            // 
            // GroupingBox
            // 
            GroupingBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            GroupingBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            GroupingBox.FormattingEnabled = true;
            GroupingBox.Items.AddRange(new object[] { "پوشاک", "خوراکی", "وسایل خانه", "تفریح", "حمل و نقل", "خرید روزانه", "بهداشت و سلامت", "اموزش و تحصیلات" });
            GroupingBox.Location = new Point(194, 153);
            GroupingBox.Name = "GroupingBox";
            GroupingBox.RightToLeft = RightToLeft.Yes;
            GroupingBox.Size = new Size(229, 31);
            GroupingBox.TabIndex = 2;
            GroupingBox.SelectedIndexChanged += GroupingBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(360, 123);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 3;
            label2.Text = "دسته بندی";
            // 
            // CardNumberBox
            // 
            CardNumberBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CardNumberBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            CardNumberBox.FormattingEnabled = true;
            CardNumberBox.Location = new Point(194, 213);
            CardNumberBox.Name = "CardNumberBox";
            CardNumberBox.Size = new Size(229, 31);
            CardNumberBox.TabIndex = 4;
            // 
            // CardNumberlabel
            // 
            CardNumberlabel.AutoSize = true;
            CardNumberlabel.BackColor = Color.Transparent;
            CardNumberlabel.Location = new Point(360, 187);
            CardNumberlabel.Name = "CardNumberlabel";
            CardNumberlabel.Size = new Size(62, 23);
            CardNumberlabel.TabIndex = 5;
            CardNumberlabel.Text = "کارت بانکی";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(194, 277);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(229, 96);
            DescriptionBox.TabIndex = 6;
            DescriptionBox.Text = "";
            DescriptionBox.TextChanged += DescriptionBox_TextChanged;
            // 
            // Descriptionlabel
            // 
            Descriptionlabel.AutoSize = true;
            Descriptionlabel.BackColor = Color.Transparent;
            Descriptionlabel.Location = new Point(360, 251);
            Descriptionlabel.Name = "Descriptionlabel";
            Descriptionlabel.Size = new Size(54, 23);
            Descriptionlabel.TabIndex = 7;
            Descriptionlabel.Text = "توضیحات";
            // 
            // button1
            // 
            button1.Font = new Font("B Nazanin", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(62, 379);
            button1.Name = "button1";
            button1.Size = new Size(290, 42);
            button1.TabIndex = 8;
            button1.Text = "ایجاد خرج جدید";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(97, 33);
            BackButton.TabIndex = 9;
            BackButton.Text = "بازگشت";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // AddingExpenses
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(435, 433);
            Controls.Add(BackButton);
            Controls.Add(button1);
            Controls.Add(Descriptionlabel);
            Controls.Add(DescriptionBox);
            Controls.Add(CardNumberlabel);
            Controls.Add(CardNumberBox);
            Controls.Add(label2);
            Controls.Add(GroupingBox);
            Controls.Add(label1);
            Controls.Add(AmountBox);
            Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddingExpenses";
            Text = "اضافه کردن خرج";
            Load += AddingExpenses_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AmountBox;
        private Label label1;
        private ComboBox GroupingBox;
        private Label label2;
        private ComboBox CardNumberBox;
        private Label CardNumberlabel;
        private RichTextBox DescriptionBox;
        private Label Descriptionlabel;
        private Button button1;
        private Button BackButton;
    }
}