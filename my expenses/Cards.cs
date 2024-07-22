using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myExpenses
{
    public partial class Cards : Form
    {
        public Cards()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();

        }

        private void Cardsbutton_Click(object sender, EventArgs e)
        {
            Addcard addcard = new Addcard();
            addcard.Show();
            this.Close();
        }

        private void Cards_Load(object sender, EventArgs e)
        {
            bool isValid = true;

            foreach (var item in Data.Addcards)
            {
                CardsListBox.Rows.Add(item.cardNumber, item.bank, item.name);
                isValid = false;
            }
            if (isValid)
            {

                ErrorLabel1.Text = "!کارت بانکی ندارید";
                ErrorLabel2.Text = "میتوانید کارت  بانکی  خود   را  اضافه کنید";


            }
            else
            {
                ErrorLabel1.Text = "";
                ErrorLabel2.Text = "";


            }
        }

        private void CardsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
