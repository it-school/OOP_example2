using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example2
{
    class LibraryBook : Book
    {
        bool isDeleted = false;
        public LibraryBook(string title, Publisher publisher, Author[] authors) : base(title, publisher, authors)
        {
        }

        public LibraryBook(LibraryBook book) : base(book)
        {
            /*
            this.Title = book.Title;
            this.Publisher = new Publisher(book.Publisher);
            this.Authors = new Author[book.Authors.Length];
            for (int i = 0; i < book.Authors.Length; i++)
                this.Authors[i] = new Author(book.Authors[i]);
            */

            this.isDeleted = book.isDeleted;
        }

        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
    }
}
