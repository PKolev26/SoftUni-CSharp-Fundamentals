using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            string[] file = input[input.Length - 1].Split('.');
            Console.WriteLine($"File name: {file[0]}\nFile extension: {file[1]}");
        }
    }
}
