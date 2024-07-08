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
            ReportTypeBox = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            Back = new Button();
            SuspendLayout();
            // 
            // ReportTypeBox
            // 
            ReportTypeBox.FormattingEnabled = true;
            ReportTypeBox.Items.AddRange(new object[] { "گزارش کلی", "گزارش ماهانه", "گزارش بازه دلخواه" });
            ReportTypeBox.Location = new Point(46, 67);
            ReportTypeBox.Name = "ReportTypeBox";
            ReportTypeBox.Size = new Size(222, 23);
            ReportTypeBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(206, 41);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 1;
            label1.Text = "نوع گذارش";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("B Nazanin", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 121);
            button1.Name = "button1";
            button1.Size = new Size(256, 38);
            button1.TabIndex = 8;
            button1.Text = "گزارش  گیری";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            ClientSize = new Size(291, 236);
            Controls.Add(Back);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(ReportTypeBox);
            MaximizeBox = false;
            Name = "reporting";
            Text = "گزارش گیری";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ReportTypeBox;
        private Label label1;
        private Button button1;
        private Button Back;
    }
}