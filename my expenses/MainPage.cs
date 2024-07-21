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
             dataGridView1.Rows.Add(item.Amount,item.cards,item.Grouping,item.Date);

            }

            int sum = Data.expenses.Sum(c => c.Amount);
            SumOfExpensesLabel.Text = sum.ToString();
            SumOfExpensesTEXT.Text = Persian_Number_To_String.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + "" + "تومان";


        }



        private void AddingExpensesButton_Click(object sender, EventArgs e)
        {
            AddcardClass addcardClass = new AddcardClass();
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
                                                                                                                                                                                                                                 //foreach (Data.Addcards.Count=0)
                                                                                                                                                                                                                                 //{
                                                                                                                                                                                                                                 //    if (string.IsNullOrEmpty(item.cardNumber))
                                                                                                                                                                                                                                 //    {
                                                                                                                                                                                                                                 //      
                                                                                                                                                                                                                                 //    }
                                                                                                                                                                                                                                 //    else
                                                                                                                                                                                                                                 //    {
                                                                                                                                                                                                                                 //        MessageBox.Show("کارتی ثبت نشده!لطفا کارت  اضافه کنید");
                                                                                                                                                                                                                                 //    }
                                                                                                                                                                                                                                 //}

                                                                                                                                                                                                                                 ;

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
    }
}
