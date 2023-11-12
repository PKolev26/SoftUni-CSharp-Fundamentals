using System.Numerics;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = arr.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            int left = 0;
            for (int i = 0; i < n; i++)
            {
                int right = sum - left - arr[i];
                if (left == right)
                {
                    Console.WriteLine(i);
                    return;
                }
                left += arr[i];
            }
            Console.WriteLine("no");
        }
    }
}