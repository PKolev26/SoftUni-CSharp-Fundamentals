using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (!map.ContainsKey(c))
                {
                    if (c == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        map[c] = 1;
                    }
                }
                else
                {
                    map[c]++;
                }

            }
            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
