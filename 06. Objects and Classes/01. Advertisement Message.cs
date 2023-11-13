using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        public class Ad
        {
            Random random = new Random();
            private string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            private string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            private string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            private string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            public void Advert(int n)
            {
                for (int i = 0; i < n; i++)
                {
                    string phrase = phrases[random.Next(phrases.Length)];
                    string ev = events[random.Next(events.Length)];
                    string author = authors[random.Next(authors.Length)];
                    string city = cities[random.Next(cities.Length)];
                    Console.WriteLine($"{phrase} {ev} {author} – {city}.");
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Ad ad = new Ad();
            ad.Advert(n);
        }
    }
}
