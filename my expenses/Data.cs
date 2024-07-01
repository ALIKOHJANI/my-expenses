using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_expenses
{
    public static class Data
    {
        public static List<User> Users = new List<User>();
        public static List<Epenses> expenses = new List<Epenses>();
        public static List<AddcardClass> Addcards = new List<AddcardClass>();
        public static List<AddGroupingClass> addGroupings = new List<AddGroupingClass> { };

    }
}
