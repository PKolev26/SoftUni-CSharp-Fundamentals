using System.Numerics;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                string number = "";
                for (int j = 1; j < text[i].Length - 1; j++)
                {

                    number += text[i][j];

                }
                if (text[i][0] < 97)
                {
                    sum += decimal.Parse(number.ToString()) / (char.ToUpper(text[i][0]) - 64);
                }
                else
                {
                    sum += decimal.Parse(number.ToString()) * (char.ToUpper(text[i][0]) - 64);
                }
                if (text[i][text[i].Length - 1] < 97)
                {
                    sum -= (char.ToUpper(text[i][text[i].Length - 1]) - 64);
                }
                else
                {
                    sum += (char.ToUpper(text[i][text[i].Length - 1]) - 64);
                }

            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
