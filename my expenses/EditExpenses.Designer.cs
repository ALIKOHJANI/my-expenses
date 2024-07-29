namespace my_expenses
{
    partial class EditExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditExpenses));
            BackButton = new Button();
            button1 = new Button();
            Descriptionlabel = new Label();
            DescriptionBox = new RichTextBox();
            CardNumberlabel = new Label();
            CardNumberBox = new ComboBox();
            label2 = new Label();
            GroupingBox = new ComboBox();
            label1 = new Label();
            AmountBox = new TextBox();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(5, 11);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(97, 33);
            BackButton.TabIndex = 19;
            BackButton.Text = "بازگشت";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("B Nazanin", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 371);
            button1.Name = "button1";
            button1.Size = new Size(290, 42);
            button1.TabIndex = 18;
            button1.Text = "ایجاد خرج جدید";
            button1.UseVisualStyleBackColor = true;
            // 
            // Descriptionlabel
            // 
            Descriptionlabel.AutoSize = true;
            Descriptionlabel.BackColor = Color.Transparent;
            Descriptionlabel.ForeColor = SystemColors.ButtonHighlight;
            Descriptionlabel.Location = new Point(221, 241);
            Descriptionlabel.Name = "Descriptionlabel";
            Descriptionlabel.Size = new Size(54, 15);
            Descriptionlabel.TabIndex = 17;
            Descriptionlabel.Text = "توضیحات";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(55, 267);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.RightToLeft = RightToLeft.Yes;
            DescriptionBox.Size = new Size(229, 96);
            DescriptionBox.TabIndex = 16;
            DescriptionBox.Text = "";
            // 
            // CardNumberlabel
            // 
            CardNumberlabel.AutoSize = true;
            CardNumberlabel.BackColor = Color.Transparent;
            CardNumberlabel.Location = new Point(221, 177);
            CardNumberlabel.Name = "CardNumberlabel";
            CardNumberlabel.Size = new Size(61, 15);
            CardNumberlabel.TabIndex = 15;
            CardNumberlabel.Text = "کارت بانکی";
            // 
            // CardNumberBox
            // 
            CardNumberBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CardNumberBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            CardNumberBox.FormattingEnabled = true;
            CardNumberBox.Location = new Point(55, 203);
            CardNumberBox.Name = "CardNumberBox";
            CardNumberBox.Size = new Size(229, 23);
            CardNumberBox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(221, 113);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 13;
            label2.Text = "دسته بندی";
            // 
            // GroupingBox
            // 
            GroupingBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            GroupingBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            GroupingBox.FormattingEnabled = true;
            GroupingBox.Items.AddRange(new object[] { "پوشاک", "خوراکی", "وسایل خانه", "تفریح", "حمل و نقل", "خرید روزانه", "بهداشت و سلامت", "اموزش و تحصیلات" });
            GroupingBox.Location = new Point(55, 143);
            GroupingBox.Name = "GroupingBox";
            GroupingBox.RightToLeft = RightToLeft.Yes;
            GroupingBox.Size = new Size(229, 23);
            GroupingBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(253, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 11;
            label1.Text = "مبلغ";
            // 
            // AmountBox
            // 
            AmountBox.Location = new Point(55, 67);
            AmountBox.Margin = new Padding(4, 5, 4, 5);
            AmountBox.MaxLength = 19;
            AmountBox.Name = "AmountBox";
            AmountBox.Size = new Size(229, 23);
            AmountBox.TabIndex = 10;
            // 
            // EditExpenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(328, 425);
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
            Name = "EditExpenses";
            Text = "EditExpenses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Button button1;
        private Label Descriptionlabel;
        private RichTextBox DescriptionBox;
        private Label CardNumberlabel;
        private ComboBox CardNumberBox;
        private Label label2;
        private ComboBox GroupingBox;
        private Label label1;
        private TextBox AmountBox;
    }
}