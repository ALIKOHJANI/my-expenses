using System.Globalization;

namespace myExpenses
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

        }

        private void AccountExitbutton_Click(object sender, EventArgs e)
        {

            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            foreach (var item in Data.Users)
            {
                NameLabel.Text = item.FirtsName + " " + item.LastName;

            }
            foreach (var item in Data.expenses)
            {

                PersianCalendar pc = new PersianCalendar();
                DateTime dateTime = item.Date;
                string PersianDate = string.Format("{0}/{1}/{2}", pc.GetYear(dateTime), pc.GetMonth(dateTime), pc.GetDayOfMonth(dateTime));
                dataGridView1.Rows.Add(item.Amount, item.cards, item.Grouping, PersianDate);

            }

            int sum = Data.expenses.Sum(c => c.Amount);
            SumOfExpensesLabel.Text = sum.ToString();
            SumOfExpensesTEXT.Text = PersianNumberToString.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + "" + "تومان";


        }



        private void AddingExpensesButton_Click(object sender, EventArgs e)
        {

            AddcardService addcardClass = new AddcardService();
            bool isValid = true;
            if (Data.Addcards.Count == 0)
            {
                MessageBox.Show("کارتی ثبت نشده!لطفا کارت  اضافه کنید");
            }
            else
            {

                AddingExpenses addingExpenses = new AddingExpenses();
                addingExpenses.Show();
                this.Hide();
            }

        }

        private void reportingbutton_Click(object sender, EventArgs e)
        {
            reporting reporting = new reporting();
            reporting.Show();
            this.Hide();
        }

        private void cardbutton_Click(object sender, EventArgs e)
        {
            Cards cards = new Cards();
            cards.Show();
            this.Hide();

        }

        private void Grouping_Click(object sender, EventArgs e)
        {
            Grouping grouping = new Grouping();
            grouping.Show();
            this.Hide();
        }

        private void ListOfExpenses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SumOfExpensesLabel_TextChanged(object sender, EventArgs e)
        {
            //SumOfExpensesLabel.Text = Convert.ToInt32(SumOfExpensesLabel.Text.Replace(",", "")).ToString("n0");


        }
    }
}
