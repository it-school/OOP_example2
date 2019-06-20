using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example2
{
    class Author
    {
        string name;
        string country;
        DateTime birthday;
        DateTime deathday;
        Dictionary.Sex sex;

        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; } // todo Добавить проверку корректности
        public DateTime Deathday { get => deathday; set => deathday = value; } // todo Добавить проверку корректности
        public Dictionary.Sex Sex { get => sex; set => sex = value; }

        public Author(string name, string country, DateTime birthday, DateTime deathday, Dictionary.Sex sex)
        {
            Name = name;
            Country = country;
            Birthday = birthday;
            Deathday = deathday;
            Sex = sex;
        }

        public Author(string name, string country, DateTime birthday, Dictionary.Sex sex)
        {
            Name = name;
            Country = country;
            Birthday = birthday;
            Deathday = DateTime.MinValue;
            Sex = sex;
        }

        public Author(string item)
        {
            Name = item;
            Birthday = DateTime.MinValue;
            Sex = Dictionary.Sex.notDefined;
            Deathday = DateTime.MinValue;
            Country = "";
        }

        public Author(Author author)
        {
            this.name = author.name;
            this.birthday = author.birthday;
            this.sex = author.sex;
            this.deathday = author.deathday;
            this.country = author.country;
        }

        public override string ToString()
        {
            return $"{Name}{(country.Equals("") ? "" : " (" + Country + ")")}" +
                $"{(Birthday == DateTime.MinValue ? "" : ", "+Birthday.ToShortDateString())}"+ 
                $"{(Deathday != DateTime.MinValue? " - " + Deathday.ToShortDateString() : "")}" +
                $"{(Sex == Dictionary.Sex.notDefined ? "" : ", " +Sex)}";
        }
    }
}
