namespace myExpenses
{
    partial class GeneralReport
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
            BackButton = new Button();
            listGeneralReport = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listGeneralReport).BeginInit();
            SuspendLayout();
            // 
            // SumOfExpensesLabel
            // 
            SumOfExpensesLabel.Location = new Point(23, 46);
            SumOfExpensesLabel.Name = "SumOfExpensesLabel";
            SumOfExpensesLabel.Size = new Size(443, 19);
            SumOfExpensesLabel.TabIndex = 0;
            SumOfExpensesLabel.Text = "0تومان ";
            SumOfExpensesLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // SumOfExpensesTEXT
            // 
            SumOfExpensesTEXT.FlatStyle = FlatStyle.Flat;
            SumOfExpensesTEXT.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SumOfExpensesTEXT.Location = new Point(23, 76);
            SumOfExpensesTEXT.Name = "SumOfExpensesTEXT";
            SumOfExpensesTEXT.RightToLeft = RightToLeft.Yes;
            SumOfExpensesTEXT.Size = new Size(443, 20);
            SumOfExpensesTEXT.TabIndex = 1;
            SumOfExpensesTEXT.Text = "صفر تومان";
            SumOfExpensesTEXT.TextAlign = ContentAlignment.TopCenter;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(83, 31);
            BackButton.TabIndex = 3;
            BackButton.Text = "بازگشت";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // listGeneralReport
            // 
            listGeneralReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listGeneralReport.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            listGeneralReport.Location = new Point(23, 109);
            listGeneralReport.Name = "listGeneralReport";
            listGeneralReport.ReadOnly = true;
            listGeneralReport.RightToLeft = RightToLeft.Yes;
            listGeneralReport.RowTemplate.Height = 25;
            listGeneralReport.Size = new Size(443, 169);
            listGeneralReport.TabIndex = 23;
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
            // GeneralReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 290);
            ControlBox = false;
            Controls.Add(listGeneralReport);
            Controls.Add(BackButton);
            Controls.Add(SumOfExpensesTEXT);
            Controls.Add(SumOfExpensesLabel);
            Name = "GeneralReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "گزارش کلی";
            FormClosed += GeneralReport_FormClosed;
            Load += GeneralReport_Load;
            ((System.ComponentModel.ISupportInitialize)listGeneralReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label SumOfExpensesLabel;
        private Label SumOfExpensesTEXT;
        private Button BackButton;
        private DataGridView listGeneralReport;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}