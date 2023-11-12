using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        private static bool Polindrome(int n)
        {
            string s = n.ToString();
            int first = 0;
            int last = s.Length - 1;
            while (first < last)
            {
                if (s[first] != s[last])
                {
                    return false;
                }
                first += 1;
                last -= 1;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                if (command == "END")
                {
                    break;
                }
                else
                {
                    int n = int.Parse(command);
                    if (Polindrome(n) == true)
                    {
                        Console.WriteLine("true");

                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                command = Console.ReadLine();

            }
        }
    }
}