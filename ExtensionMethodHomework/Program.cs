using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "Mike";
            person.LastName = "B.";

            person.SetDefaultAge().PrintInfo();

            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int DefaultAge { get; set; } = 18;
    }

    public static class PersonModelExtensionMethods
    {
        public static PersonModel SetDefaultAge(this PersonModel person)
        {
            person.Age = person.DefaultAge;
            return person;
        }

        public static PersonModel PrintInfo(this PersonModel person)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age}");
            return person;
        }
    }
}
