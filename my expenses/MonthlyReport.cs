using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private void MonthlyReport_FormClosed(object sender, FormClosedEventArgs e)
        {


        }
        
        private void reportingButton_Click(object sender, EventArgs e)
        {
            foreach (var item in Data.expenses)
            {

                (DateTime start, DateTime end) = ConvertDateTime.GetGregorianDates(ChooseTheMonth.Text);

                if (item.Date <= start && item.Date >= end)
                {
                    if (item.cards == CardBox.Text)
                    {
                        SumOfExpensesTEXT.Text = PersianNumberToString.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + " " + "تومان";
                        PersianCalendar pc = new PersianCalendar();
                        DateTime dateTime = item.Date;
                        string PersianDate = string.Format("{0}/{1}/{2}", pc.GetYear(dateTime), pc.GetMonth(dateTime), pc.GetDayOfMonth(dateTime));
                        listMonthlyReport.Rows.Add(item.Amount, item.cards, item.Grouping, PersianDate);
                    }
                    else
                    {
                         
                    }
                    if (item.Grouping == GroupingBox.Text)
                    {
                        SumOfExpensesTEXT.Text = PersianNumberToString.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + " " + "تومان";
                        PersianCalendar pc = new PersianCalendar();
                        DateTime dateTime = item.Date;
                        string PersianDate = string.Format("{0}/{1}/{2}", pc.GetYear(dateTime), pc.GetMonth(dateTime), pc.GetDayOfMonth(dateTime));
                        listMonthlyReport.Rows.Add(item.Amount, item.cards, item.Grouping, PersianDate);
                    }
                    else
                    {
                    }
                }
            }
        }
    }
}

