using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_expenses
{

    public partial class ForgotPassword : Form
    {
        User user = new User();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void SendSMSbutton_Click(object sender, EventArgs e)
        {
            ExpnsesServis expnsesServis = new ExpnsesServis();
            string NationalId = SendSMSBox.Text;
            bool isValid = false;
            string NewPassword = "";
            foreach (User item in Data.Users)
            {
                if (item.NationalId == NationalId)
                {
                    isValid = true;
                    NewPassword = expnsesServis.GenerateNewPassword();
                    passwordlabel.Text = NewPassword;
                    item.Password = NewPassword;

                    break;
                }

            }

        }



        private void ComingBackButton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }
    }
}
