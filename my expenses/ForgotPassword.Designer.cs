namespace my_expenses
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            SendSMSLabel = new Label();
            SendSMSBox = new TextBox();
            SendSMSbutton = new Button();
            ComingBackButton = new Button();
            passwordBox = new TextBox();
            SuspendLayout();
            // 
            // SendSMSLabel
            // 
            SendSMSLabel.AutoSize = true;
            SendSMSLabel.BackColor = Color.Transparent;
            SendSMSLabel.ForeColor = Color.White;
            SendSMSLabel.Location = new Point(158, 49);
            SendSMSLabel.Name = "SendSMSLabel";
            SendSMSLabel.Size = new Size(123, 15);
            SendSMSLabel.TabIndex = 0;
            SendSMSLabel.Text = ":کد ملی  خود را واردکنید";
            // 
            // SendSMSBox
            // 
            SendSMSBox.Location = new Point(12, 46);
            SendSMSBox.Name = "SendSMSBox";
            SendSMSBox.Size = new Size(131, 23);
            SendSMSBox.TabIndex = 1;
            SendSMSBox.KeyPress += SendSMSBox_KeyPress;
            // 
            // SendSMSbutton
            // 
            SendSMSbutton.BackColor = Color.Transparent;
            SendSMSbutton.ForeColor = Color.Black;
            SendSMSbutton.Location = new Point(76, 75);
            SendSMSbutton.Name = "SendSMSbutton";
            SendSMSbutton.Size = new Size(151, 23);
            SendSMSbutton.TabIndex = 2;
            SendSMSbutton.Text = "بازیابی رمز";
            SendSMSbutton.UseVisualStyleBackColor = false;
            SendSMSbutton.Click += SendSMSbutton_Click;
            // 
            // ComingBackButton
            // 
            ComingBackButton.Location = new Point(231, 154);
            ComingBackButton.Name = "ComingBackButton";
            ComingBackButton.Size = new Size(75, 23);
            ComingBackButton.TabIndex = 4;
            ComingBackButton.Text = "بازگشت";
            ComingBackButton.UseVisualStyleBackColor = true;
            ComingBackButton.Click += ComingBackButton_Click;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(12, 145);
            passwordBox.Name = "passwordBox";
            passwordBox.ReadOnly = true;
            passwordBox.Size = new Size(131, 23);
            passwordBox.TabIndex = 5;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(309, 180);
            Controls.Add(passwordBox);
            Controls.Add(ComingBackButton);
            Controls.Add(SendSMSbutton);
            Controls.Add(SendSMSBox);
            Controls.Add(SendSMSLabel);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فراموشی رمز";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SendSMSLabel;
        private TextBox SendSMSBox;
        private Button SendSMSbutton;
        private Button ComingBackButton;
        private TextBox passwordBox;
    }
}