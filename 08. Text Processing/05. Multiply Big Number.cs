using System.Numerics;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            bigNum = bigNum.TrimStart(new char[] { '0' });
            char[] bigNumChars = bigNum.ToCharArray();
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("0");
                return;
            }
            List<string> num = new List<string>();
            int parse = 0;
            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                parse = (int.Parse(Convert.ToString(bigNum[i])) * number) + parse;
                num.Insert(0, (parse % 10).ToString());
                parse /= 10;
            }
            if (parse > 0)
                Console.WriteLine($"{parse}{string.Join("", num)}");
            else
                Console.WriteLine($"{string.Join("", num)}");
        }
    }
}
