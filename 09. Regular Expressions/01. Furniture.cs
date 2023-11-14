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
            var pattern = new Regex(@">>(?<name>[A-z]+)<<(?<price>\d+\.*\d*)!(?<quantity>\d+)");
            var furniture = new List<string>();
            double total = 0;
            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                if (pattern.IsMatch(input))
                {
                    var match = pattern.Match(input);
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    furniture.Add(name);
                    total += price * quantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {total:F2}");
        }
    }
}
