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
            public void Edit(string newContent)
            {
                Content = newContent;
            }

            public void ChangeAuthor(string newAuthor)
            {
                Author = newAuthor;
            }

            public void Rename(string newTitle)
            {
                Title = newTitle;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }

        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            Article articleObject = new Article(info[0], info[1], info[2]);
            int commands = int.Parse(Console.ReadLine());
            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { ": " }, StringSplitOptions.None);
                switch (input[0])
                {
                    case "Edit": articleObject.Edit(input[1]); break;
                    case "ChangeAuthor": articleObject.ChangeAuthor(input[1]); break;
                    case "Rename": articleObject.Rename(input[1]); break;
                }
            }
            Console.WriteLine(articleObject.ToString());
        }
    }
}
