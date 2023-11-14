using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(new string[] { "->" }, StringSplitOptions.None);
                if (input[0] == "End")
                {
                    break;
                }
                string name = input[0].Trim();
                string employer = input[1].Trim();
                if (!company.ContainsKey(name))
                {
                    company[name] = new List<string>();
                }
                if (!company[name].Contains(employer))
                {
                    company[name].Add(employer);
                }
            }
            foreach (var item in company)
            {
                Console.WriteLine($"{item.Key}");
                foreach (string employers in item.Value)
                {
                    Console.WriteLine($"-- {employers}");
                }
            }
        }
    }
}
