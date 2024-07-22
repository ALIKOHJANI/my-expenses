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
    public partial class MonthlyReport : Form
    {
        public MonthlyReport()
        {
            InitializeComponent();
        }

        private void MonthlyReport_Load(object sender, EventArgs e)
        {
            SumOfExpensesTEXT.Text = PersianNumberToString.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + " " + "تومان";
            foreach (var item in Data.expenses)
            {
                listMonthlyReport.Rows.Add(item.Amount, item.cards, item.Grouping, item.Date);

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

        private void BackButton_Click(object sender, EventArgs e)
        {
            reporting reporting = new reporting();
            reporting.Show();
            this.Close();
        }
    }
}

