using System.Numerics;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int Vowels(string input)
            {
                int br = 0;
                foreach (var item in input)
                {
                    if ("aeiou".IndexOf(item) != -1)
                    {
                        br++;
                    }
                }
                return br;
            }
            static void Main(string[] args)
            {
                string input = Console.ReadLine().ToLower();
                Console.WriteLine(Vowels(input));
            }
        }
    }
}