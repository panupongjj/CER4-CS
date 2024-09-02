using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCS
{
    internal class session7_2
    {
    }
    class Person_7_2
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine();
        }
    }

    class properties_7_2
    {
        public void access_private_name()
        {   
            List<Person_7_2> people = new List<Person_7_2>(); //list of object Persone

            // Input details for each person
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Enter details for Person " + i + ":");
                Person_7_2 person = new Person_7_2();

                Console.Write("Name: ");
                person.Name = Console.ReadLine();

                Console.Write("Age: ");
                person.Age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Gender: ");
                person.Gender = Console.ReadLine();

                Console.Write("Address: ");
                person.Address = Console.ReadLine();

                people.Add(person);
                Console.WriteLine();
            }

            // Print details of each person
            Console.WriteLine("Person Details:");
            Console.WriteLine("---------------------");
            foreach (Person_7_2 person in people)
            {
                person.PrintDetails();
            }
        }
    }
}
