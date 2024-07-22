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
        public static List<Epenses> expenses = new List<Epenses>();
        public static List<AddcardService> Addcards = new List<AddcardService>();
        public static List<AddGroupingService> addGroupings = new List<AddGroupingService> { };

    }
}
