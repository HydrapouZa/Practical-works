using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac12
{
    class Book
    {
        private readonly int ISBN;
        private string bookName;
        private string autorName;
        public Book(int ISBN, string bookName, string autorName) {
            this.ISBN = ISBN;
            this.bookName = bookName;
            this.autorName = autorName;
        }
        public string BookName { get { return bookName; } set { bookName = value; } }
        public string AutorName { get { return autorName; } set { autorName = value; } }

        public void COutInfo()
        {
            Console.WriteLine($"Номер книги: {ISBN}, название: {bookName}, автор: {autorName}");
        }
    }
}
