using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalAssignment.Entity
{
    public class PhoneBook
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if(!Regex.IsMatch(value, @"^0\d{2} \d{3} \d{4}$"))
                {
                    throw new Exception("Input is value is not correct");
                }
                phoneNumber = value;
            }
        }

        public string Email { get; set; }
        public string Address { get; set; }
        private string group;
        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                if(! new List<String> { "Family", "Colleague", "Friend", "Other" }.Contains(value))
                {
                    throw new Exception("Input value is not correct!");
                }
                group = value;
            }
        }


    }
}
