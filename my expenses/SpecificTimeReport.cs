using System.Globalization;

namespace my_expenses
{
    public partial class SpecificTimeReport : Form
    {
        public SpecificTimeReport()
        {
            InitializeComponent();
        }

        private void SpecificTimeReport_Load(object sender, EventArgs e)
        {
            foreach (var item in Data.Addcards)
            {
                CardBox.Items.Add(item.cardNumber);
            }
            foreach (var item in Data.addGroupings)
            {
                GroupingBox.Items.Add(item.Name);
            }

        }

        private void reportingButton_Click(object sender, EventArgs e)
        {

            PersianCalendar pc = new PersianCalendar();

            DateTime dts = new DateTime(Convert.ToChar(StartDateTextBox));
            DateTime dte = new DateTime(Convert.ToChar(EndDateTextBox));
            foreach (var item in Data.expenses)
            {
                if (item.Date >= dts && item.Date <= dte)
                {
                    listSpecificTime.Items.Add(":مبلغ" + item.Amount + ":شماره کارت" + item.cards);
                    int sum = Data.expenses.Sum(c => c.Amount);
                    SumOfExpensesLabel.Text = sum.ToString();
                    SumOfExpensesTEXT.Text = Persian_Number_To_String.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + " " + "تومان";

                }
            }

        }
    }
}
