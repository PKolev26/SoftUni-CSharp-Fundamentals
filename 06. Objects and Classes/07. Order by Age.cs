using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);
                if (!people.ContainsKey(id))
                {
                    people[id] = new Person();
                }
                people[id].Name = name;
                people[id].Age = age;
            }
            foreach (var person in people.Values.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {people.First(p => p.Value == person).Key} is {person.Age} years old.");
            }
        }
    }
}
