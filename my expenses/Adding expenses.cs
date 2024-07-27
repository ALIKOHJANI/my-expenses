using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace myExpenses
{
    public partial class AddingExpenses : Form
    {
        public AddingExpenses()
        {
            InitializeComponent();
        }
        Expenses expenses = new Expenses();

        public Expenses Expenses { get => expenses; set => expenses = value; }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void AmountBox_TextChanged(object sender, EventArgs e)
        {
            Expenses.Amount = (int)Convert.ToInt64(AmountBox.Text);
            //if (AmountBox.Text == "" || AmountBox.Text == "0") return;
            //decimal price;
            //price = decimal.Parse(AmountBox.Text, System.Globalization.NumberStyles.Currency);
            //AmountBox.Text = price.ToString("#,#");
            //AmountBox.SelectionStart = AmountBox.Text.Length;
        }   
        private void GroupingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            expenses.Grouping = GroupingBox.Text;
            GroupingBox.SelectedIndex = GroupingBox.FindString(GroupingBox.Text);
        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
            expenses.Description = DescriptionBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Data.expenses.Add(expenses);

            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();

        }

        private void AddingExpenses_Load(object sender, EventArgs e)
        {
            foreach (var item in Data.Addcards)
            {
                CardNumberBox.Items.Add(item.cardNumber);
            }
            foreach (var item in Data.addGroupings)
            {
                GroupingBox.Items.Add(item.Name);
            }

        }

        private void AmountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void CardNumberBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            expenses.cards = CardNumberBox.Text;
        }

        private void AddingExpenses_FormClosed(object sender, FormClosedEventArgs e)
        {
          

        }
    }
}
