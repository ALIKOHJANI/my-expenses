﻿namespace myExpenses
{
    public class Expenses
    {
        public Int64 Amount { get; set; }
        public string cards { get; set; }
        public string Grouping { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Expenses()
        {
            Date=DateTime.Now;
        }
    }
}
