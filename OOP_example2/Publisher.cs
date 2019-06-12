using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example2
{
    class Publisher
    {
        public string Title { get; }
        public string Country { get; }

        public Publisher(string title, string country)
        {
            Title = title;
            Country = country;
        }

        public override string ToString()
        {
            return $"Publisher: {Title} ({Country})";
        }
    }
}
