using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example2
{
    class Program
    {
        enum colors
        {
            red = 1,
            orange, 
            yellow,
            green,
            lightblue,
            blue,
            violet
        }

        enum EnumName
        {
            Pavel = 3,
            Oleg = 2,
            Anna = 10,
            Andrew,
            Gena = 5,
            Elena
        };

        enum daysOfWeek
        {
            sun = 7,
            mon = 1,
            tue,
            wed,
            thu,
            fri,
            sat,
        }

        static String[] days = {
            "",
            "mon",
            "tue",
            "wed",
            "thu",
            "fri",
            "sat",
            "sun",
        };

        static void Main(string[] args)
        {
            colors carColor = colors.yellow;
            string[] colors2 = {"red", "green", "white" };
            string currentcolor = "gray";

            Array colorss = Enum.GetValues(typeof(colors));
            foreach (colors name in colorss)
                Console.WriteLine(name);
            /*
            Console.WriteLine("Enum EnumName: ");
            EnumName names;
            Array mas = Enum.GetValues(typeof(EnumName));
            foreach (EnumName name in mas)
                Console.WriteLine(name);

            names = EnumName.Oleg;
            Console.WriteLine($"\nEnumName.Oleg value: {EnumName.Oleg}");
            Console.WriteLine($"\nEnumName.Oleg index: {(int)EnumName.Oleg}");


            Console.WriteLine($"\nIndex of \'sat\': {(int)daysOfWeek.sat}");
            Console.WriteLine($"Value of array with index of \'sat\': {days[(int)daysOfWeek.sat]}");
            Console.WriteLine($"\nIndex of \'sun\': {(int)daysOfWeek.sun}");
            Console.WriteLine($"Value of array with index of \'sun\': {days[(int)daysOfWeek.sun]}");
            */
            //nsClass1 cl1 = new nsClass1();


            Author author1 = new Author("Jack London", "USA", new DateTime(1876, 1, 12), new DateTime(1916, 11, 22), Dictionary.Sex.male);
            Author author3 = new Author("Lina Kostenko", "Ukraine", new DateTime(1930, 3, 19), Dictionary.Sex.female);
            Console.WriteLine(author1);
            Console.WriteLine(author3);


            Author author5 = new Author("I.Ilph", "Russian empire", new DateTime(1897, 10, 15), new DateTime(1937, 04, 13), Dictionary.Sex.male);
            Author author6 = new Author("E.Petrov", "Russian empire", new DateTime(1903, 10, 15), new DateTime(1942, 04, 13), Dictionary.Sex.male);
                                 
            Publisher publisher1 = new Publisher("BHV", "Ukraine");

            Book book1 = new Book("White tooth", publisher1, "Jack London, Lina Kostenko");
            Console.WriteLine(book1);

            
            Book book2 = new Book("12 chairs", publisher1, new Author[] { author5, author6});
            Console.WriteLine(book2);
        }    
    }
}
