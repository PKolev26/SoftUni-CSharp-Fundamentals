using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }
            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                string[] info = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
                Article articleObject = new Article(info[0], info[1], info[2]);
                Console.WriteLine(articleObject.ToString());
            }

        }
    }
}
