using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> map = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!map.ContainsKey(input))
                {
                    map[input] = new List<double>();
                }
                map[input].Add(grade);
            }

            foreach (var item in map)
            {

                double avg = item.Value.Sum(x => (double)x) / item.Value.Count;
                if (avg >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {avg:F2}");
                }

            }
        }
    }
}
