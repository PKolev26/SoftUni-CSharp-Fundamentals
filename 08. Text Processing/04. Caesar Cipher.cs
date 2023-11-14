using System.Numerics;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var text = new StringBuilder();
            foreach (var symbol in input)
            {
                var decode = (char)(symbol + 3);
                text.Append(decode);
            }
            Console.WriteLine(text);
        }
    }
}
