namespace my_expenses
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
            listGeneralReport = new ListBox();
            SuspendLayout();
            // 
            // SumOfExpensesLabel
            // 
            SumOfExpensesLabel.AutoSize = true;
            SumOfExpensesLabel.Location = new Point(167, 32);
            SumOfExpensesLabel.Name = "SumOfExpensesLabel";
            SumOfExpensesLabel.Size = new Size(44, 15);
            SumOfExpensesLabel.TabIndex = 0;
            SumOfExpensesLabel.Text = "0تومان ";
            // 
            // SumOfExpensesTEXT
            // 
            SumOfExpensesTEXT.AutoSize = true;
            SumOfExpensesTEXT.FlatStyle = FlatStyle.Flat;
            SumOfExpensesTEXT.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SumOfExpensesTEXT.Location = new Point(152, 63);
            SumOfExpensesTEXT.Name = "SumOfExpensesTEXT";
            SumOfExpensesTEXT.RightToLeft = RightToLeft.Yes;
            SumOfExpensesTEXT.Size = new Size(68, 16);
            SumOfExpensesTEXT.TabIndex = 1;
            SumOfExpensesTEXT.Text = "صفر تومان";
            SumOfExpensesTEXT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // listGeneralReport
            // 
            listGeneralReport.FormattingEnabled = true;
            listGeneralReport.ItemHeight = 15;
            listGeneralReport.Location = new Point(12, 109);
            listGeneralReport.Name = "listGeneralReport";
            listGeneralReport.Size = new Size(364, 169);
            listGeneralReport.TabIndex = 2;
            // 
            // GeneralReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 290);
            Controls.Add(listGeneralReport);
            Controls.Add(SumOfExpensesTEXT);
            Controls.Add(SumOfExpensesLabel);
            Name = "GeneralReport";
            Text = "GeneralReport";
            Load += GeneralReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SumOfExpensesLabel;
        private Label SumOfExpensesTEXT;
        private ListBox listGeneralReport;
    }
}