using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').Reverse().ToArray();
            string str = string.Join(" ", input);
            string[] output = str.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.WriteLine(string.Join(" ", output));
        }
    }
}