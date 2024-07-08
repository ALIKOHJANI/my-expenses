using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_expenses
{
    public class User
    {
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalId { get; set; }
        public string Gender { get; set; }

        public User (string firtsName, string lastName, string password, string NationalId )
        {
            this.FirtsName= firtsName;
            this.LastName= lastName;
            this.Password= password;
            this.NationalId= NationalId;

        }
        
    }
}
