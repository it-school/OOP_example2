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

        public override string ToString()
        {
            string result = "";

            result += '"' + Title.ToUpper() + '"';

            foreach (Author author in Authors)
            {
                result += "\n" + author.ToString();
            }

            result +=  "\n" + Publisher;
            return result;
        }
    }
}
