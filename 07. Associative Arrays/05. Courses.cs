using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(new String[] { " : " }, StringSplitOptions.None);
                if (input[0] == "end")
                {
                    break;
                }
                string name = input[0];
                string student = input[1];
                if (!courses.ContainsKey(name))
                {
                    courses[name] = new List<string>();
                }
                courses[name].Add(student);

            }
            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (string student in item.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
