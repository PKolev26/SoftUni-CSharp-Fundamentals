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
            var result = new List<string>();
            double income = 0;
            var regex = new Regex(@"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|[^|$%.]*?(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.*\d*)\$");
            string input = Console.ReadLine();
            while (input != "end of shift")
            {
                if (regex.IsMatch(input))
                {
                    var regexInput = regex.Match(input);
                    string name = regexInput.Groups["name"].Value;
                    string product = regexInput.Groups["product"].Value;
                    int count = int.Parse(regexInput.Groups["count"].Value);
                    double price = double.Parse(regexInput.Groups["price"].Value);
                    double total = count * price;
                    result.Add($"{name}: {product} - {total:F2}");
                    income += total;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("\n", result));
            Console.WriteLine($"Total income: {income:F2}");
        }
    }
}
