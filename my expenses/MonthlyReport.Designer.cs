namespace my_expenses
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
            number = new Label();
            InWords = new Label();
            ListMonthlyReports = new ListBox();
            SuspendLayout();
            // 
            // number
            // 
            number.AutoSize = true;
            number.Font = new Font("B Nazanin", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            number.Location = new Point(196, 19);
            number.Name = "number";
            number.Size = new Size(47, 24);
            number.TabIndex = 0;
            number.Text = "تومان 0";
            number.TextAlign = ContentAlignment.TopCenter;
            // 
            // InWords
            // 
            InWords.AutoSize = true;
            InWords.Font = new Font("B Nazanin", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            InWords.Location = new Point(196, 52);
            InWords.Name = "InWords";
            InWords.Size = new Size(64, 24);
            InWords.TabIndex = 1;
            InWords.Text = "صفر تومان";
            InWords.TextAlign = ContentAlignment.TopCenter;
            // 
            // ListMonthlyReports
            // 
            ListMonthlyReports.FormattingEnabled = true;
            ListMonthlyReports.ItemHeight = 15;
            ListMonthlyReports.Location = new Point(35, 99);
            ListMonthlyReports.Name = "ListMonthlyReports";
            ListMonthlyReports.Size = new Size(377, 184);
            ListMonthlyReports.TabIndex = 2;
            // 
            // MonthlyReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 299);
            Controls.Add(ListMonthlyReports);
            Controls.Add(InWords);
            Controls.Add(number);
            Name = "MonthlyReport";
            Text = "MonthlyReport";
            Load += MonthlyReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label number;
        private Label InWords;
        private ListBox ListMonthlyReports;
    }
}