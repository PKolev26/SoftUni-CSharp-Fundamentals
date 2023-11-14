using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new String[] { ", " }, StringSplitOptions.None);
            var valid = new List<string>();
            foreach (var current in input)
            {
                var validLength = false;
                var validSymbols = true;
                if (current.Length >= 3 && current.Length <= 16)
                {
                    validLength = true;
                }
                foreach (var symbol in current)
                {
                    if (!(char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_'))
                    {
                        validSymbols = false;
                        break;
                    }
                }
                if (validSymbols && validLength)
                {
                    valid.Add(current);
                }
            }
            foreach (var password in valid)
            {
                Console.WriteLine(password);
            }
        }
    }
}
