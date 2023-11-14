using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "buy")
                {
                    break;
                }
                if (!products.ContainsKey(input[0]))
                {
                    products[input[0]] = new double[2] { double.Parse(input[1]), int.Parse(input[2]) };
                }
                else
                {
                    products[input[0]][0] = double.Parse(input[1]);
                    products[input[0]][1] += int.Parse(input[2]);
                }

            }
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * (int)item.Value[1]):f2}");
            }
        }
    }
}
