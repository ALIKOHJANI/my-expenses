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
    public partial class MonthlyReport : Form
    {
        public MonthlyReport()
        {
            InitializeComponent();
        }

        private void MonthlyReport_Load(object sender, EventArgs e)
        {
            SumOfExpensesTEXT.Text = Persian_Number_To_String.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + " " + "تومان";
            foreach (var item in Data.expenses)
            {
                listMonthlyReport.Items.Add(item.Amount + ":شماره کارت" + item.cards);

            }
            foreach (var item in Data.Addcards)
            {
                CardBox.Items.Add(item.cardNumber);
            }
            foreach (var item in Data.addGroupings)
            {
                GroupingBox.Items.Add(item.Name);
            }
        }

    }
}

