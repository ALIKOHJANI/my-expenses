﻿using myExpenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace my_expenses
{
    public partial class EditExpenses : Form
    {
        public EditExpenses()
        {
            InitializeComponent();
        }




        public void BackButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        public void Delete_Click(object sender, EventArgs e)
        {
            foreach (var item in Data.expenses)
            {
                if (item.Date == item.Date && item.cards == CardNumberBox.Text)
                {
                    Data.expenses.Remove(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage MainPage = new MainPage();
           
        }
    }
}
