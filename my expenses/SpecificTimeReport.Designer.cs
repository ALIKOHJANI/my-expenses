namespace my_expenses
{
    partial class SpecificTimeReport
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
            SumOfExpensesLabel = new Label();
            SumOfExpensesTEXT = new Label();
            listSpecificTime = new ListBox();
            StartDateTextBox = new MaskedTextBox();
            StartDate = new Label();
            EndDateTextBox = new MaskedTextBox();
            EndDateLabel = new Label();
            label3 = new Label();
            GroupingBox = new ComboBox();
            label4 = new Label();
            CardBox = new ComboBox();
            reportingButton = new Button();
            SuspendLayout();
            // 
            // SumOfExpensesLabel
            // 
            SumOfExpensesLabel.AutoSize = true;
            SumOfExpensesLabel.Location = new Point(172, 154);
            SumOfExpensesLabel.Name = "SumOfExpensesLabel";
            SumOfExpensesLabel.Size = new Size(44, 15);
            SumOfExpensesLabel.TabIndex = 1;
            SumOfExpensesLabel.Text = "0 تومان";
            // 
            // SumOfExpensesTEXT
            // 
            SumOfExpensesTEXT.AutoSize = true;
            SumOfExpensesTEXT.Location = new Point(155, 187);
            SumOfExpensesTEXT.Name = "SumOfExpensesTEXT";
            SumOfExpensesTEXT.Size = new Size(61, 15);
            SumOfExpensesTEXT.TabIndex = 2;
            SumOfExpensesTEXT.Text = "صفر تومان";
            // 
            // listSpecificTime
            // 
            listSpecificTime.FormattingEnabled = true;
            listSpecificTime.ItemHeight = 15;
            listSpecificTime.Location = new Point(12, 216);
            listSpecificTime.Name = "listSpecificTime";
            listSpecificTime.Size = new Size(369, 199);
            listSpecificTime.TabIndex = 3;
            // 
            // StartDateTextBox
            // 
            StartDateTextBox.Location = new Point(230, 12);
            StartDateTextBox.Mask = "0000/00/00";
            StartDateTextBox.Name = "StartDateTextBox";
            StartDateTextBox.Size = new Size(100, 23);
            StartDateTextBox.TabIndex = 4;
            StartDateTextBox.ValidatingType = typeof(DateTime);
            // 
            // StartDate
            // 
            StartDate.AutoSize = true;
            StartDate.Location = new Point(336, 15);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(45, 15);
            StartDate.TabIndex = 5;
            StartDate.Text = ":از تاریخ";
            // 
            // EndDateTextBox
            // 
            EndDateTextBox.Location = new Point(12, 12);
            EndDateTextBox.Mask = "0000/00/00";
            EndDateTextBox.Name = "EndDateTextBox";
            EndDateTextBox.Size = new Size(100, 23);
            EndDateTextBox.TabIndex = 6;
            EndDateTextBox.ValidatingType = typeof(DateTime);
            // 
            // EndDateLabel
            // 
            EndDateLabel.AutoSize = true;
            EndDateLabel.Location = new Point(141, 15);
            EndDateLabel.Name = "EndDateLabel";
            EndDateLabel.Size = new Size(44, 15);
            EndDateLabel.TabIndex = 7;
            EndDateLabel.Text = ":تا تاریخ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(318, 50);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 9;
            label3.Text = "دسته بندی";
            // 
            // GroupingBox
            // 
            GroupingBox.FormattingEnabled = true;
            GroupingBox.Items.AddRange(new object[] { "پوشاک", "خوراکی", "وسایل خانه", "تفریح", "حمل و نقل", "خرید روزانه", "بهداشت و سلامت", "اموزش و تحصیلات" });
            GroupingBox.Location = new Point(230, 76);
            GroupingBox.Name = "GroupingBox";
            GroupingBox.Size = new Size(151, 23);
            GroupingBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 50);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 11;
            label4.Text = "انتخواب   کارت";
            // 
            // CardBox
            // 
            CardBox.FormattingEnabled = true;
            CardBox.Location = new Point(12, 76);
            CardBox.Name = "CardBox";
            CardBox.Size = new Size(138, 23);
            CardBox.TabIndex = 10;
            // 
            // reportingButton
            // 
            reportingButton.Location = new Point(132, 115);
            reportingButton.Name = "reportingButton";
            reportingButton.Size = new Size(116, 36);
            reportingButton.TabIndex = 12;
            reportingButton.Text = "گزارشگیری";
            reportingButton.UseVisualStyleBackColor = true;
            reportingButton.Click += reportingButton_Click;
            // 
            // SpecificTimeReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 427);
            Controls.Add(reportingButton);
            Controls.Add(label4);
            Controls.Add(CardBox);
            Controls.Add(label3);
            Controls.Add(GroupingBox);
            Controls.Add(EndDateLabel);
            Controls.Add(EndDateTextBox);
            Controls.Add(StartDate);
            Controls.Add(StartDateTextBox);
            Controls.Add(listSpecificTime);
            Controls.Add(SumOfExpensesTEXT);
            Controls.Add(SumOfExpensesLabel);
            Name = "SpecificTimeReport";
            Text = "گزارش بازه مشخص";
            Load += SpecificTimeReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label SumOfExpensesLabel;
        private Label SumOfExpensesTEXT;
        private ListBox listSpecificTime;
        private MaskedTextBox StartDateTextBox;
        private Label StartDate;
        private MaskedTextBox EndDateTextBox;
        private Label EndDateLabel;
        private Label label3;
        private ComboBox GroupingBox;
        private Label label4;
        private ComboBox CardBox;
        private Button reportingButton;
    }
}