using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management.Common;

namespace Management.Model
{
    public class User
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = Validations.CleanName(value); }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = Validations.CleanName(value); }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string Email { get; set; }
        public string FavouriteFood { get; set; }
    }
}
