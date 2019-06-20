using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example2
{
    class Book
    {
        string title;
        Author []authors;
        Publisher publisher;

        public string Title { get => title; set => title = value; }
        internal Publisher Publisher { get => publisher; set => publisher = value; }
        internal Author[] Authors { get => authors; set => authors = value; }
/*
        public Book(Book book) : this(book.title, book.publisher, book.authors)
        {

        }
        */
        public Book(Book book) 
        {
            //
            this.title = book.title;
            this.publisher = new Publisher(book.publisher);
            this.authors = new Author[book.authors.Length];
            for (int i = 0; i < book.authors.Length; i++)
            {
                this.authors[i] = new Author(book.authors[i]);
            }
        }
        
        public Book() : this("", null, new Author[0])
        {

        }

        public Book(string title, Publisher publisher, Author[] authors)
        {
            Title = title;
            Publisher = publisher;
            Authors = authors;
        }

        public Book(string title, Publisher publisher, string authors)
        {
            Title = title;
            Publisher = publisher;

            string []author = authors.Split(new char[] { ',', '/', ';', '\\', '`', '~', '*' });
            for (int i = 0; i < author.Length; i++)
                author[i] = author[i].Trim();

            Authors = new Author[author.Length];

            int k = 0;
            foreach (string item in author)
            {
                Authors[k++] = new Author(item);
            }
        }

        public bool FindByTitle(string title)
        {
            if (this.title.ToLower().Contains(title.ToLower()))
                return true;

            return false;
        } 

        public override string ToString()
        {
            if (this == null)
                return "No such book";

            string result = "";

            result += '"' + Title. ToUpper() + '"';

            if (Authors != null)
                foreach (Author author in Authors)
                    result += "\n" + author.ToString();

            result +=  "\n" + (Publisher != null ? Publisher.ToString() : "");
            return result;
        }
    }
}
