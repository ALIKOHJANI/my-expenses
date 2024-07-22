namespace myExpenses
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
            StartDateTextBox = new MaskedTextBox();
            StartDate = new Label();
            EndDateTextBox = new MaskedTextBox();
            EndDateLabel = new Label();
            label3 = new Label();
            GroupingBox = new ComboBox();
            label4 = new Label();
            CardBox = new ComboBox();
            reportingButton = new Button();
            BackButton = new Button();
            listMonthlyReport = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listMonthlyReport).BeginInit();
            SuspendLayout();
            // 
            // SumOfExpensesLabel
            // 
            SumOfExpensesLabel.Location = new Point(51, 154);
            SumOfExpensesLabel.Name = "SumOfExpensesLabel";
            SumOfExpensesLabel.Size = new Size(369, 15);
            SumOfExpensesLabel.TabIndex = 1;
            SumOfExpensesLabel.Text = "0 تومان";
            SumOfExpensesLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // SumOfExpensesTEXT
            // 
            SumOfExpensesTEXT.Location = new Point(51, 188);
            SumOfExpensesTEXT.Name = "SumOfExpensesTEXT";
            SumOfExpensesTEXT.Size = new Size(369, 15);
            SumOfExpensesTEXT.TabIndex = 2;
            SumOfExpensesTEXT.Text = "صفر تومان";
            SumOfExpensesTEXT.TextAlign = ContentAlignment.TopCenter;
            // 
            // StartDateTextBox
            // 
            StartDateTextBox.Location = new Point(269, 12);
            StartDateTextBox.Mask = "0000/00/00";
            StartDateTextBox.Name = "StartDateTextBox";
            StartDateTextBox.Size = new Size(100, 23);
            StartDateTextBox.TabIndex = 4;
            StartDateTextBox.ValidatingType = typeof(DateTime);
            // 
            // StartDate
            // 
            StartDate.AutoSize = true;
            StartDate.Location = new Point(375, 15);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(45, 15);
            StartDate.TabIndex = 5;
            StartDate.Text = ":از تاریخ";
            // 
            // EndDateTextBox
            // 
            EndDateTextBox.Location = new Point(51, 12);
            EndDateTextBox.Mask = "0000/00/00";
            EndDateTextBox.Name = "EndDateTextBox";
            EndDateTextBox.Size = new Size(100, 23);
            EndDateTextBox.TabIndex = 6;
            EndDateTextBox.ValidatingType = typeof(DateTime);
            // 
            // EndDateLabel
            // 
            EndDateLabel.AutoSize = true;
            EndDateLabel.Location = new Point(157, 15);
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
            label3.Location = new Point(357, 50);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 9;
            label3.Text = "دسته بندی";
            // 
            // GroupingBox
            // 
            GroupingBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            GroupingBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            GroupingBox.FormattingEnabled = true;
            GroupingBox.Items.AddRange(new object[] { "پوشاک", "خوراکی", "وسایل خانه", "تفریح", "حمل و نقل", "خرید روزانه", "بهداشت و سلامت", "اموزش و تحصیلات" });
            GroupingBox.Location = new Point(269, 76);
            GroupingBox.Name = "GroupingBox";
            GroupingBox.RightToLeft = RightToLeft.Yes;
            GroupingBox.Size = new Size(151, 23);
            GroupingBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(107, 50);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 11;
            label4.Text = "انتخواب   کارت";
            // 
            // CardBox
            // 
            CardBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CardBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            CardBox.FormattingEnabled = true;
            CardBox.Location = new Point(51, 76);
            CardBox.Name = "CardBox";
            CardBox.Size = new Size(138, 23);
            CardBox.TabIndex = 10;
            // 
            // reportingButton
            // 
            reportingButton.Location = new Point(171, 115);
            reportingButton.Name = "reportingButton";
            reportingButton.Size = new Size(116, 36);
            reportingButton.TabIndex = 12;
            reportingButton.Text = "گزارشگیری";
            reportingButton.UseVisualStyleBackColor = true;
            reportingButton.Click += reportingButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(372, 421);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(83, 31);
            BackButton.TabIndex = 13;
            BackButton.Text = "بازگشت";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // listMonthlyReport
            // 
            listMonthlyReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listMonthlyReport.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            listMonthlyReport.Location = new Point(12, 246);
            listMonthlyReport.Name = "listMonthlyReport";
            listMonthlyReport.ReadOnly = true;
            listMonthlyReport.RightToLeft = RightToLeft.Yes;
            listMonthlyReport.RowTemplate.Height = 25;
            listMonthlyReport.Size = new Size(443, 169);
            listMonthlyReport.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "مبلغ";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "کارت";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "دسته بندی";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "تاریخ";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // SpecificTimeReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 454);
            Controls.Add(listMonthlyReport);
            Controls.Add(BackButton);
            Controls.Add(reportingButton);
            Controls.Add(label4);
            Controls.Add(CardBox);
            Controls.Add(label3);
            Controls.Add(GroupingBox);
            Controls.Add(EndDateLabel);
            Controls.Add(EndDateTextBox);
            Controls.Add(StartDate);
            Controls.Add(StartDateTextBox);
            Controls.Add(SumOfExpensesTEXT);
            Controls.Add(SumOfExpensesLabel);
            Name = "SpecificTimeReport";
            Text = "گزارش بازه مشخص";
            Load += SpecificTimeReport_Load;
            ((System.ComponentModel.ISupportInitialize)listMonthlyReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label SumOfExpensesLabel;
        private Label SumOfExpensesTEXT;
        private MaskedTextBox StartDateTextBox;
        private Label StartDate;
        private MaskedTextBox EndDateTextBox;
        private Label EndDateLabel;
        private Label label3;
        private ComboBox GroupingBox;
        private Label label4;
        private ComboBox CardBox;
        private Button reportingButton;
        private Button BackButton;
        private DataGridView listMonthlyReport;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}