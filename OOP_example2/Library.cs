using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example2
{
    class Library
    {
        LibraryBook[] books;

        public Library()
        {
            books = new LibraryBook[0];
        }

        public Library(int n)
        {
            books = new LibraryBook[n];
        }

        public void Add(LibraryBook book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
        }

        public override string ToString()
        {
            string result = "\n\nLibrary (" + this.GetLength() + " books):\n";

            foreach (LibraryBook book in books)
                result += (book == null || book.IsDeleted == true ? "" : book.ToString()) + "\n";

            return result;
        }

        public bool Remove(int n)
        {
            if (n >= 0 && n < books.Length && !books[n].IsDeleted)
                return (books[n].IsDeleted = true);
            
            return false;
        }

        public int GetLength()
        {
            int n = 0;

            foreach (LibraryBook book in books)
                if (book != null && !book.IsDeleted)
                    n++;

            return n;
        }

        public LibraryBook BookAt(int n)
        {
            if (n < 0 || n >= books.Length)
                return null;

            return books[n];
        }

        public Library FindByTitle(string title)
        {
            Library result = new Library();

            foreach (LibraryBook book in books)
                if (book != null && book.FindByTitle(title) == true)
                    result.Add(new LibraryBook(book));

            return result;
        }

    }
}
