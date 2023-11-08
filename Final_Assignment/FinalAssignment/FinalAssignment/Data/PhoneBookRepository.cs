using FinalAssignment.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.Data
{
    public class PhoneBookRepository : IPhoneBookRepository
    {
        private readonly static List<PhoneBook> listPhoneBook = new List<PhoneBook>()
        {
            new PhoneBook() {Id = 1, Name = "Mai Trong Hieu", PhoneNumber = "094 331 7918", Address = "Ha Noi", Email = "tronghieu@gmail.com", Group ="Friend"},
            new PhoneBook() {Id = 2, Name = "Truong Trong Hoa", PhoneNumber = "094 233 4215", Address = "Thanh Hoa", Email = "hoatrongtrong@gmail.com", Group ="Family"},
            new PhoneBook() {Id = 3, Name = "Dang Hoai Vu", PhoneNumber = "094 412 5321", Address = "Ha Nam", Email = "hoaivu@gmail.com", Group ="Other"},
            new PhoneBook() {Id = 4, Name = "Mai Duc Huy", PhoneNumber = "042 312 1642", Address = "Ha Giang", Email = "duchuy@gmail.com", Group ="Colleague"},
            new PhoneBook() {Id = 5, Name = "Bui Ha Bach", PhoneNumber = "094 464 2135", Address = "Thanh Hoa", Email = "habach@gmail.com", Group ="Friend"},
            new PhoneBook() {Id = 6, Name = "Vo Quoc Trung", PhoneNumber = "094 456 7918", Address = "Nghe An", Email = "quoctrung@gmail.com", Group ="Colleague"},
            new PhoneBook() {Id = 7, Name = "Tran Anh Tuan", PhoneNumber = "094 123 4512", Address = "TP HCM", Email = "anhtuan@gmail.com", Group ="Other"},
            new PhoneBook() {Id = 8, Name = "Vu Quoc Trung", PhoneNumber = "094 214 4560", Address = "Hai Phong", Email = "vquoctrung@gmail.com", Group ="Family"},
        };
        public int Add(PhoneBook phoneBook)
        {
            var lastPhoneBook = listPhoneBook.OrderByDescending(x => x.Id).FirstOrDefault();
            if (lastPhoneBook != null)
            {
                phoneBook.Id = lastPhoneBook.Id + 1;
            }
            listPhoneBook.Add(phoneBook);
            return 1;
        }

        public int Delete(string name)
        {
            var phoneBookExist = listPhoneBook.FirstOrDefault(x => x.Name == name);
            if (phoneBookExist != null)
            {
                listPhoneBook.Remove(phoneBookExist);
                return 1;
            }
            return 0;
        }

        public List<PhoneBook> Find(string name)
        {
            List<PhoneBook> listFindByName = new List<PhoneBook>();
            listFindByName = listPhoneBook.Where(x => x.Name == name).ToList();
            return listFindByName;
        }

        public List<PhoneBook> GetAll()
        {
            return listPhoneBook;
        }

        public List<PhoneBook> Sort()
        {
            List<PhoneBook> listSortByName = new List<PhoneBook>();
            listSortByName = listPhoneBook.OrderBy(x => x.Name).ToList();
            return listSortByName;
        }

        public int Update(PhoneBook phoneBook, int id)
        {
           var phoneBookExist = listPhoneBook.SingleOrDefault(x => x.Id == id);
            if (phoneBookExist != null)
            {
                var index  = listPhoneBook.IndexOf(phoneBookExist);
                listPhoneBook[index].Name = phoneBook.Name;
                listPhoneBook[index].PhoneNumber = phoneBook.PhoneNumber;
                listPhoneBook[index].Address = phoneBook.Address;
                listPhoneBook[index].Email = phoneBook.Email;
                listPhoneBook[index].Group = phoneBook.Group;
                return 1;
            }
            return 0;

        }
    }
}
