using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = info[0];
            int power = info[1];
            while (list.Contains(bomb))
            {
                int index = list.IndexOf(bomb);
                int left = Math.Max(0, index - power);
                int right = Math.Min(list.Count - 1, index + power);
                list.RemoveRange(left, right - left + 1);
            }
            Console.WriteLine(list.Sum());
        }
    }
}