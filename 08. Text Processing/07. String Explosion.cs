using System.Numerics;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new StringBuilder();
            var power = 0;
            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    power += int.Parse(item.ToString());
                }
                if (item == '>')
                {
                    result.Append(item);
                }
                else
                {
                    if (power == 0)
                    {
                        result.Append(item);
                    }
                    else
                    {
                        power--;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
