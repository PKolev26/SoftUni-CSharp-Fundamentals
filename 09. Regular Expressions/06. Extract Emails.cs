using System.Numerics;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.RegularExpressions;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[^\.\-_]\b[a-zA-Z0-9]+([-._a-zA-Z0-9]+)*[@][\w]+(([-]|[.])([\w]+))+";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matchedEmails = regex.Matches(input);
            foreach (Match email in matchedEmails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
