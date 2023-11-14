using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            string str1 = str[0];
            string str2 = str[1];
            int sum = 0;
            int lenght = Math.Min(str1.Length, str2.Length);
            for (int i = 0; i < lenght; i++)
            {
                sum += str1[i] * str2[i];
            }
            if (str1.Length > lenght)
            {
                for (int i = lenght; i < str1.Length; i++)
                {
                    sum += str1[i];
                }
            }
            if (str2.Length > lenght)
            {
                for (int i = lenght; i < str2.Length; i++)
                {
                    sum += str2[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
