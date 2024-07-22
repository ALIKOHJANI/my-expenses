namespace myExpenses
{
    public class Epenses
    {
        public int Amount { get; set; }
        public string cards { get; set; }
        public string Grouping { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Epenses()
        {
            Date=DateTime.Now;
        }
    }
}
