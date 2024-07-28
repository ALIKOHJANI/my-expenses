namespace my_expenses
{
    partial class EditCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCategories));
            BackButton = new Button();
            Enterbutton = new Button();
            label2 = new Label();
            DescriptionBox = new RichTextBox();
            label1 = new Label();
            NameGroupingBox = new TextBox();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(16, 10);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 11;
            BackButton.Text = "بازگشت";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // Enterbutton
            // 
            Enterbutton.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Enterbutton.Location = new Point(49, 347);
            Enterbutton.Name = "Enterbutton";
            Enterbutton.Size = new Size(280, 38);
            Enterbutton.TabIndex = 10;
            Enterbutton.Text = "ثبت دسته بندی";
            Enterbutton.UseVisualStyleBackColor = true;
            Enterbutton.Click += Enterbutton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(277, 153);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 9;
            label2.Text = "توضیحات";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionBox.Location = new Point(49, 179);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.RightToLeft = RightToLeft.Yes;
            DescriptionBox.Size = new Size(280, 96);
            DescriptionBox.TabIndex = 8;
            DescriptionBox.Text = "";
            DescriptionBox.TextChanged += DescriptionBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(190, 70);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 7;
            label1.Text = "نام دسته بندی را وارد کنید";
            // 
            // NameGroupingBox
            // 
            NameGroupingBox.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            NameGroupingBox.Location = new Point(49, 96);
            NameGroupingBox.Name = "NameGroupingBox";
            NameGroupingBox.RightToLeft = RightToLeft.Yes;
            NameGroupingBox.Size = new Size(280, 30);
            NameGroupingBox.TabIndex = 6;
            NameGroupingBox.TextChanged += NameGroupingBox_TextChanged;
            // 
            // EditCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(356, 450);
            Controls.Add(BackButton);
            Controls.Add(Enterbutton);
            Controls.Add(label2);
            Controls.Add(DescriptionBox);
            Controls.Add(label1);
            Controls.Add(NameGroupingBox);
            Name = "EditCategories";
            Text = "EditCategories";
            Load += EditCategories_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Button Enterbutton;
        private Label label2;
        private RichTextBox DescriptionBox;
        private Label label1;
        private TextBox NameGroupingBox;
    }
}