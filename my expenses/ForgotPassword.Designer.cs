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
            passwordlabel = new Label();
            ComingBackButton = new Button();
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
            // passwordlabel
            // 
            passwordlabel.AutoSize = true;
            passwordlabel.BackColor = Color.Transparent;
            passwordlabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordlabel.ForeColor = Color.Transparent;
            passwordlabel.Location = new Point(22, 120);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(113, 21);
            passwordlabel.TabIndex = 3;
            passwordlabel.Text = "رمز بازیابی شده";
            passwordlabel.TextAlign = ContentAlignment.TopCenter;
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
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(309, 180);
            Controls.Add(ComingBackButton);
            Controls.Add(passwordlabel);
            Controls.Add(SendSMSbutton);
            Controls.Add(SendSMSBox);
            Controls.Add(SendSMSLabel);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SendSMSLabel;
        private TextBox SendSMSBox;
        private Button SendSMSbutton;
        private Label passwordlabel;
        private Button ComingBackButton;
    }
}