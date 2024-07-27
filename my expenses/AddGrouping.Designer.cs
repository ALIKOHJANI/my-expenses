namespace myExpenses
{
    partial class AddGrouping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGrouping));
            NameGroupingBox = new TextBox();
            label1 = new Label();
            DescriptionBox = new RichTextBox();
            label2 = new Label();
            Enterbutton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // NameGroupingBox
            // 
            NameGroupingBox.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            NameGroupingBox.Location = new Point(45, 98);
            NameGroupingBox.Name = "NameGroupingBox";
            NameGroupingBox.RightToLeft = RightToLeft.Yes;
            NameGroupingBox.Size = new Size(280, 30);
            NameGroupingBox.TabIndex = 0;
            NameGroupingBox.TextChanged += NameGroupingBox_TextChanged;
            NameGroupingBox.KeyPress += NameGroupingBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(186, 72);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 1;
            label1.Text = "نام دسته بندی را وارد کنید";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionBox.Location = new Point(45, 181);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.RightToLeft = RightToLeft.Yes;
            DescriptionBox.Size = new Size(280, 96);
            DescriptionBox.TabIndex = 2;
            DescriptionBox.Text = "";
            DescriptionBox.TextChanged += DescriptionBox_TextChanged;
            DescriptionBox.KeyPress += DescriptionBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(273, 155);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 3;
            label2.Text = "توضیحات";
            // 
            // Enterbutton
            // 
            Enterbutton.Font = new Font("B Nazanin", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Enterbutton.Location = new Point(45, 349);
            Enterbutton.Name = "Enterbutton";
            Enterbutton.Size = new Size(280, 38);
            Enterbutton.TabIndex = 4;
            Enterbutton.Text = "ثبت دسته بندی";
            Enterbutton.UseVisualStyleBackColor = true;
            Enterbutton.Click += Enterbutton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 5;
            BackButton.Text = "بازگشت";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // AddGrouping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(339, 450);
            ControlBox = false;
            Controls.Add(BackButton);
            Controls.Add(Enterbutton);
            Controls.Add(label2);
            Controls.Add(DescriptionBox);
            Controls.Add(label1);
            Controls.Add(NameGroupingBox);
            MaximizeBox = false;
            Name = "AddGrouping";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ایجاد دسته‌ بندی جدید";
            FormClosed += AddGrouping_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameGroupingBox;
        private Label label1;
        private RichTextBox DescriptionBox;
        private Label label2;
        private Button Enterbutton;
        private Button BackButton;
    }
}