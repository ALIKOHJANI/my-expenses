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
    public partial class Cards : Form
    {
        public Cards()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();

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
            foreach (var item in Data.Addcards)
            {
                CardsListBox.Items.Add(item.cardNumber+":شماره کارت");
            }
        }

        private void CardsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCardsButton_Click(object sender, EventArgs e)
        {
            Addcard addcard = new Addcard();
            addcard.Show();
            this.Close();
        }
    }
}
