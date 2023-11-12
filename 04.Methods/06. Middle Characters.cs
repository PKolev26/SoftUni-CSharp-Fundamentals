using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Middle(string input)
        {
            int index = input.Length / 2;

            if (input.Length % 2 == 0)
            {
                Console.WriteLine($"{input[index - 1]}{input[index]}");
            }
            else
            {
                Console.WriteLine(input[index]);
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Middle(input);
        }
    }
}