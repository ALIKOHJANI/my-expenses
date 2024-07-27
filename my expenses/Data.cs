using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myExpenses
{
    public static class Data
    {
        public static List<User> Users = new List<User>();
        public static List<Expenses> expenses = new List<Expenses>();
        public static List<AddcardService> Addcards = new List<AddcardService>();
        public static List<AddGroupingService> addGroupings = new List<AddGroupingService> { };

    }
}
