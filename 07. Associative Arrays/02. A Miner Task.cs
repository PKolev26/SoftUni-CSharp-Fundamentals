using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> map = new Dictionary<string, int>();
            while (input != "stop")
            {

                int count = int.Parse(Console.ReadLine());
                if (!map.ContainsKey(input))
                {
                    map[input] = 0;
                }
                map[input] += count;
                input = Console.ReadLine();
            }
            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
