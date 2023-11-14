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
            string result = "";
            char character = '\0';
            int count = 0;
            foreach (char c in input)
            {
                if (c != character)
                {
                    result += c;
                    character = c;
                    count = 1;
                }
                else
                {
                    count++;
                }
                if (count > 1)
                {
                    continue;
                }
            }
            Console.WriteLine(result);
        }
    }
}
