namespace my_expenses
{
    partial class Grouping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grouping));
            GroupingBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            addbutton = new Button();
            ErrorLabel1 = new Label();
            ErrorLabel2 = new Label();
            Back = new Button();
            GroupingListBox = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GroupingListBox).BeginInit();
            SuspendLayout();
            // 
            // GroupingBox
            // 
            GroupingBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            GroupingBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            GroupingBox.FormattingEnabled = true;
            GroupingBox.Items.AddRange(new object[] { "پوشاک", "خوراکی", "وسایل خانه", "تفریح", "حمل و نقل", "خرید روزانه", "بهداشت و سلامت", "اموزش و تحصیلات" });
            GroupingBox.Location = new Point(113, 88);
            GroupingBox.Name = "GroupingBox";
            GroupingBox.RightToLeft = RightToLeft.Yes;
            GroupingBox.Size = new Size(228, 23);
            GroupingBox.TabIndex = 0;
            GroupingBox.SelectedIndexChanged += GroupingBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(200, 62);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 1;
            label1.Text = "دسته بندی های پیش فرض";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("B Nazanin", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(228, 158);
            label2.Name = "label2";
            label2.Size = new Size(126, 26);
            label2.TabIndex = 2;
            label2.Text = "دسته بندی های شما";
            // 
            // addbutton
            // 
            addbutton.BackColor = SystemColors.ControlLightLight;
            addbutton.Font = new Font("B Nazanin", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            addbutton.Location = new Point(12, 151);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(161, 33);
            addbutton.TabIndex = 4;
            addbutton.Text = "   ایجاد دسته‌ بندی جدید   +";
            addbutton.UseVisualStyleBackColor = false;
            addbutton.Click += addbutton_Click;
            // 
            // ErrorLabel1
            // 
            ErrorLabel1.AutoSize = true;
            ErrorLabel1.BackColor = Color.Transparent;
            ErrorLabel1.Font = new Font("B Nazanin", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorLabel1.Location = new Point(137, 389);
            ErrorLabel1.Name = "ErrorLabel1";
            ErrorLabel1.Size = new Size(108, 24);
            ErrorLabel1.TabIndex = 5;
            ErrorLabel1.Text = "!دسته بندی ندارید ";
            // 
            // ErrorLabel2
            // 
            ErrorLabel2.AutoSize = true;
            ErrorLabel2.BackColor = Color.Transparent;
            ErrorLabel2.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorLabel2.Location = new Point(95, 413);
            ErrorLabel2.Name = "ErrorLabel2";
            ErrorLabel2.Size = new Size(206, 23);
            ErrorLabel2.TabIndex = 6;
            ErrorLabel2.Text = "میتوانید برای خود دسته بندی ایجاد کنید";
            // 
            // Back
            // 
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 7;
            Back.Text = "بازگشت";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // GroupingListBox
            // 
            GroupingListBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GroupingListBox.Location = new Point(12, 190);
            GroupingListBox.Name = "GroupingListBox";
            GroupingListBox.RowTemplate.Height = 25;
            GroupingListBox.Size = new Size(342, 171);
            GroupingListBox.TabIndex = 8;
            // 
            // Grouping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(366, 470);
            Controls.Add(GroupingListBox);
            Controls.Add(Back);
            Controls.Add(ErrorLabel2);
            Controls.Add(ErrorLabel1);
            Controls.Add(addbutton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GroupingBox);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Grouping";
            Text = "دسته بندی ها";
            Load += Grouping_Load;
            ((System.ComponentModel.ISupportInitialize)GroupingListBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox GroupingBox;
        private Label label1;
        private Label label2;
        private Button addbutton;
        private Label ErrorLabel1;
        private Label ErrorLabel2;
        private Button Back;
        private DataGridView GroupingListBox;
    }
}