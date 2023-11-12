using System.Numerics;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Print(char start, char end)
            {

                if (start > end)
                {
                    char temp = start;
                    start = end;
                    end = temp;
                }

                for (char c = start += (char)1; c < end; c++)
                {
                    Console.Write(c + " ");
                }
            }
            static void Main(string[] args)
            {
                char start = Console.ReadLine()[0];
                char end = Console.ReadLine()[0];
                Print(start, end);
            }
        }
    }
}