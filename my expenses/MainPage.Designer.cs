namespace my_expenses
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            ExpenseLabel = new Label();
            AccountExitbutton = new Button();
            pictureBox1 = new PictureBox();
            NameLabel = new Label();
            SumOfExpensesLabel = new Label();
            SumOfExpensesTEXT = new Label();
            AddingExpensesButton = new Button();
            label1 = new Label();
            ListOfExpenses = new ListBox();
            reportingbutton = new Button();
            cardbutton = new Button();
            GroupingB = new Button();
            Homebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ExpenseLabel
            // 
            ExpenseLabel.AutoSize = true;
            ExpenseLabel.BackColor = Color.Transparent;
            ExpenseLabel.Location = new Point(445, 82);
            ExpenseLabel.Name = "ExpenseLabel";
            ExpenseLabel.Size = new Size(87, 15);
            ExpenseLabel.TabIndex = 0;
            ExpenseLabel.Text = "خرج های این ماه";
            // 
            // AccountExitbutton
            // 
            AccountExitbutton.Location = new Point(0, 0);
            AccountExitbutton.Name = "AccountExitbutton";
            AccountExitbutton.Size = new Size(100, 23);
            AccountExitbutton.TabIndex = 1;
            AccountExitbutton.Text = "خروج از حساب ";
            AccountExitbutton.UseVisualStyleBackColor = true;
            AccountExitbutton.Click += AccountExitbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(538, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(485, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(47, 15);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "نام کاربر";
            // 
            // SumOfExpensesLabel
            // 
            SumOfExpensesLabel.AutoSize = true;
            SumOfExpensesLabel.BackColor = Color.Transparent;
            SumOfExpensesLabel.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SumOfExpensesLabel.Location = new Point(281, 82);
            SumOfExpensesLabel.Name = "SumOfExpensesLabel";
            SumOfExpensesLabel.Size = new Size(31, 36);
            SumOfExpensesLabel.TabIndex = 4;
            SumOfExpensesLabel.Text = "0";
            // 
            // SumOfExpensesTEXT
            // 
            SumOfExpensesTEXT.AutoSize = true;
            SumOfExpensesTEXT.BackColor = Color.Transparent;
            SumOfExpensesTEXT.Font = new Font("Zilla Slab", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SumOfExpensesTEXT.Location = new Point(235, 118);
            SumOfExpensesTEXT.Name = "SumOfExpensesTEXT";
            SumOfExpensesTEXT.Size = new Size(110, 29);
            SumOfExpensesTEXT.TabIndex = 5;
            SumOfExpensesTEXT.Text = "صفر تومان";
            // 
            // AddingExpensesButton
            // 
            AddingExpensesButton.Location = new Point(177, 163);
            AddingExpensesButton.Name = "AddingExpensesButton";
            AddingExpensesButton.Size = new Size(226, 50);
            AddingExpensesButton.TabIndex = 6;
            AddingExpensesButton.Text = "افزودن خرج";
            AddingExpensesButton.UseVisualStyleBackColor = true;
            AddingExpensesButton.Click += AddingExpensesButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("B Nazanin", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(509, 219);
            label1.Name = "label1";
            label1.Size = new Size(84, 24);
            label1.TabIndex = 7;
            label1.Text = "خرج های اخیر";
            // 
            // ListOfExpenses
            // 
            ListOfExpenses.FormattingEnabled = true;
            ListOfExpenses.ItemHeight = 15;
            ListOfExpenses.Location = new Point(114, 219);
            ListOfExpenses.Name = "ListOfExpenses";
            ListOfExpenses.Size = new Size(389, 169);
            ListOfExpenses.TabIndex = 8;
            ListOfExpenses.SelectedIndexChanged += ListOfExpenses_SelectedIndexChanged;
            // 
            // reportingbutton
            // 
            reportingbutton.Location = new Point(42, 409);
            reportingbutton.Name = "reportingbutton";
            reportingbutton.Size = new Size(102, 25);
            reportingbutton.TabIndex = 9;
            reportingbutton.Text = "گزارش";
            reportingbutton.UseVisualStyleBackColor = true;
            reportingbutton.Click += reportingbutton_Click;
            // 
            // cardbutton
            // 
            cardbutton.Location = new Point(168, 409);
            cardbutton.Name = "cardbutton";
            cardbutton.Size = new Size(102, 25);
            cardbutton.TabIndex = 10;
            cardbutton.Text = "کارت ها";
            cardbutton.UseVisualStyleBackColor = true;
            cardbutton.Click += cardbutton_Click;
            // 
            // GroupingB
            // 
            GroupingB.Location = new Point(314, 409);
            GroupingB.Name = "GroupingB";
            GroupingB.Size = new Size(102, 25);
            GroupingB.TabIndex = 11;
            GroupingB.Text = "دست بندی ها";
            GroupingB.UseVisualStyleBackColor = true;
            GroupingB.Click += Grouping_Click;
            // 
            // Homebutton
            // 
            Homebutton.Location = new Point(446, 409);
            Homebutton.Name = "Homebutton";
            Homebutton.Size = new Size(102, 25);
            Homebutton.TabIndex = 12;
            Homebutton.Text = "خانه";
            Homebutton.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(596, 509);
            Controls.Add(Homebutton);
            Controls.Add(GroupingB);
            Controls.Add(cardbutton);
            Controls.Add(reportingbutton);
            Controls.Add(ListOfExpenses);
            Controls.Add(label1);
            Controls.Add(AddingExpensesButton);
            Controls.Add(SumOfExpensesTEXT);
            Controls.Add(SumOfExpensesLabel);
            Controls.Add(NameLabel);
            Controls.Add(pictureBox1);
            Controls.Add(AccountExitbutton);
            Controls.Add(ExpenseLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            FormClosing += MainPage_FormClosing;
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ExpenseLabel;
        private Button AccountExitbutton;
        private PictureBox pictureBox1;
        private Label NameLabel;
        private Label SumOfExpensesLabel;
        private Label SumOfExpensesTEXT;
        private Button AddingExpensesButton;
        private Label label1;
        private ListBox ListOfExpenses;
        private Button reportingbutton;
        private Button cardbutton;
        private Button GroupingB;
        private Button Homebutton;
    }
}