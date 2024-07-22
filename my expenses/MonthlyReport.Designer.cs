namespace myExpenses
{
    partial class MonthlyReport
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            CardBox = new ComboBox();
            label3 = new Label();
            GroupingBox = new ComboBox();
            SumOfExpensesTEXT = new Label();
            SumOfExpensesLabel = new Label();
            BackButton = new Button();
            listMonthlyReport = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listMonthlyReport).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { " فروردین", " اردیبهشت", " خرداد", " تیر", " مرداد", " شهریور", " مهر", " آبان", " آذر", " دی", " بهمن", " اسفند" });
            comboBox1.Location = new Point(197, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.Yes;
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 22);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "انتخواب ماه";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(114, 66);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 15;
            label4.Text = "انتخواب   کارت";
            // 
            // CardBox
            // 
            CardBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CardBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            CardBox.FormattingEnabled = true;
            CardBox.Location = new Point(58, 92);
            CardBox.Name = "CardBox";
            CardBox.Size = new Size(138, 23);
            CardBox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(338, 66);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 13;
            label3.Text = "دسته بندی";
            // 
            // GroupingBox
            // 
            GroupingBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            GroupingBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            GroupingBox.FormattingEnabled = true;
            GroupingBox.Items.AddRange(new object[] { "پوشاک", "خوراکی", "وسایل خانه", "تفریح", "حمل و نقل", "خرید روزانه", "بهداشت و سلامت", "اموزش و تحصیلات" });
            GroupingBox.Location = new Point(250, 92);
            GroupingBox.Name = "GroupingBox";
            GroupingBox.RightToLeft = RightToLeft.Yes;
            GroupingBox.Size = new Size(151, 23);
            GroupingBox.TabIndex = 12;
            // 
            // SumOfExpensesTEXT
            // 
            SumOfExpensesTEXT.FlatStyle = FlatStyle.Flat;
            SumOfExpensesTEXT.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SumOfExpensesTEXT.Location = new Point(58, 151);
            SumOfExpensesTEXT.Name = "SumOfExpensesTEXT";
            SumOfExpensesTEXT.Size = new Size(343, 16);
            SumOfExpensesTEXT.TabIndex = 18;
            SumOfExpensesTEXT.Text = "صفر تومان";
            SumOfExpensesTEXT.TextAlign = ContentAlignment.TopCenter;
            // 
            // SumOfExpensesLabel
            // 
            SumOfExpensesLabel.Location = new Point(58, 136);
            SumOfExpensesLabel.Name = "SumOfExpensesLabel";
            SumOfExpensesLabel.Size = new Size(343, 15);
            SumOfExpensesLabel.TabIndex = 17;
            SumOfExpensesLabel.Text = "0";
            SumOfExpensesLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(58, 19);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(83, 31);
            BackButton.TabIndex = 19;
            BackButton.Text = "بازگشت";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // listMonthlyReport
            // 
            listMonthlyReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listMonthlyReport.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            listMonthlyReport.Location = new Point(12, 235);
            listMonthlyReport.Name = "listMonthlyReport";
            listMonthlyReport.ReadOnly = true;
            listMonthlyReport.RightToLeft = RightToLeft.Yes;
            listMonthlyReport.RowTemplate.Height = 25;
            listMonthlyReport.Size = new Size(443, 169);
            listMonthlyReport.TabIndex = 23;
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
            // MonthlyReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 466);
            Controls.Add(listMonthlyReport);
            Controls.Add(BackButton);
            Controls.Add(SumOfExpensesTEXT);
            Controls.Add(SumOfExpensesLabel);
            Controls.Add(label4);
            Controls.Add(CardBox);
            Controls.Add(label3);
            Controls.Add(GroupingBox);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "MonthlyReport";
            Text = "گزارش ماهانه";
            Load += MonthlyReport_Load;
            ((System.ComponentModel.ISupportInitialize)listMonthlyReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label4;
        private ComboBox CardBox;
        private Label label3;
        private ComboBox GroupingBox;
        private Label SumOfExpensesTEXT;
        private Label SumOfExpensesLabel;
        private Button BackButton;
        private DataGridView listMonthlyReport;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}