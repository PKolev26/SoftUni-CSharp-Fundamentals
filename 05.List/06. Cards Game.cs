using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (player1.Count > 0 && player2.Count > 0)
            {
                if (player1.First() > player2.First())
                {
                    player1.Add(player2.First());
                    player1.Add(player1.First());
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }
                else if (player1.First() < player2.First())
                {
                    player2.Add(player1.First());
                    player2.Add(player2.First());
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }
                else if (player1.First() == player2.First())
                {
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }
            }
            if (player1.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {player2.Sum()}");

            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {player1.Sum()}");
            }
        }
    }
}