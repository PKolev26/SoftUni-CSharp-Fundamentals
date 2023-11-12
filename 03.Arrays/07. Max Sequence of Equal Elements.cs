using System.Numerics;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int maxLength = 1;
            int maxPos = 0;
            int currentLength = 1;
            int currentPos = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxPos = currentPos;
                    }
                }
                else
                {
                    currentLength = 1;
                    currentPos = i;
                }
            }
            for (int i = maxPos; i < maxPos + maxLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}