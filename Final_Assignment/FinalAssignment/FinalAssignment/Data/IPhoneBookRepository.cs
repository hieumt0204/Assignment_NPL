using FinalAssignment.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.Data
{
    public interface IPhoneBookRepository
    {
        public List<PhoneBook> GetAll();
        public int Add(PhoneBook phoneBook);
        public int Update(PhoneBook phoneBook, int id);
        public int Delete(string name);
        public List<PhoneBook> Sort();
        public List<PhoneBook> Find(string name);
    }
}
