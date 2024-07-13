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
            GroupingListBox = new ListBox();
            addbutton = new Button();
            label3 = new Label();
            label4 = new Label();
            Back = new Button();
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
            // GroupingListBox
            // 
            GroupingListBox.FormattingEnabled = true;
            GroupingListBox.ItemHeight = 15;
            GroupingListBox.Location = new Point(95, 187);
            GroupingListBox.Name = "GroupingListBox";
            GroupingListBox.Size = new Size(206, 199);
            GroupingListBox.TabIndex = 3;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("B Nazanin", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(137, 389);
            label3.Name = "label3";
            label3.Size = new Size(108, 24);
            label3.TabIndex = 5;
            label3.Text = "!دسته بندی ندارید ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(95, 413);
            label4.Name = "label4";
            label4.Size = new Size(206, 23);
            label4.TabIndex = 6;
            label4.Text = "میتوانید برای خود دسته بندی ایجاد کنید";
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
            // Grouping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(366, 470);
            Controls.Add(Back);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(addbutton);
            Controls.Add(GroupingListBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GroupingBox);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Grouping";
            Text = "دسته بندی ها";
            Load += Grouping_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox GroupingBox;
        private Label label1;
        private Label label2;
        private ListBox GroupingListBox;
        private Button addbutton;
        private Label label3;
        private Label label4;
        private Button Back;
    }
}