using my_expenses;
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

        private void Cards_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void CardsListBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CardEditing cardEditing= new CardEditing();
            if (CardsListBox.Rows.Count == 0)
            {
                MessageBox.Show("موردي براي ويرايش وجود ندارد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cardEditing.CardNumberBox.Text = CardsListBox["CardNumber", CardsListBox.CurrentRow.Index].Value.ToString();
            cardEditing.CardNameBox.Text = CardsListBox["CardName", CardsListBox.CurrentRow.Index].Value.ToString();
            cardEditing.bankComboBox.Text = CardsListBox["Bank", CardsListBox.CurrentRow.Index].Value.ToString();
            this.Close();
            if (cardEditing.ShowDialog() == DialogResult.OK)
            {
                 CardsListBox["CardNumber", CardsListBox.CurrentRow.Index].Value =cardEditing.CardNumberBox.Text ;
                 CardsListBox["CardName", CardsListBox.CurrentRow.Index].Value= cardEditing.CardNameBox.Text;
                 CardsListBox["Bank", CardsListBox.CurrentRow.Index].Value= cardEditing.bankComboBox.Text;

                
            }
        }
    }
}
