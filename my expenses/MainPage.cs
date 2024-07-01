﻿using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace my_expenses
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }



        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            logIn.Close();
        }

        private void AccountExitbutton_Click(object sender, EventArgs e)
        {

            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            foreach (var item in Data.Users)
            {
                NameLabel.Text = item.FirtsName + "" + item.LastName;

            }
            foreach (var item in Data.expenses)
            {
                ListOfExpenses.Items.Add(item.Amount + "" + item.Grouping);

            }

            int sum = Data.expenses.Sum(c => c.Amount);
            SumOfExpensesLabel.Text = sum.ToString();
            var digit = long.Parse(SumOfExpensesLabel.Text);
            SumOfExpensesTEXT.Text = Persian_Number_To_String.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + " " + "تومان";


        }



        private void AddingExpensesButton_Click(object sender, EventArgs e)
        {
            AddingExpenses addingExpenses = new AddingExpenses();
            addingExpenses.Show();

        }

        private void reportingbutton_Click(object sender, EventArgs e)
        {
            reporting reporting = new reporting();
            reporting.Show();
        }

        private void cardbutton_Click(object sender, EventArgs e)
        {
            Cards cards = new Cards();
            cards.Show();
        }

        private void Grouping_Click(object sender, EventArgs e)
        {
            Grouping grouping = new Grouping();
            grouping.Show();
        }

        private void ListOfExpenses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
