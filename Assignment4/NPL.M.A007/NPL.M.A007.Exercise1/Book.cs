using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A007.Exercise1_
{
    public class Book
    {
        private string bookName;
        private int isbnNumber;
        private string authorName;
        private string publisherName;

        public Book() { }
        public Book(string bookName, int isbnNumber, string authorName, string publisherName)
        {
            this.bookName = bookName;
            this.isbnNumber = isbnNumber;
            this.authorName = authorName;
            this.publisherName = publisherName;
        }
        public string GetBookInformation()
        {
            return $"ISBN number:{this.isbnNumber}\nBook Name : {this.bookName}\nAuthor Name:{this.authorName}\nPublisher Name:{this.publisherName}";
        }

    }
}
