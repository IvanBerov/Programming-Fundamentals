using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(", ");
            Article article = new Article(tokens[0], tokens[1], tokens[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commArgs = Console.ReadLine().Split(": ");
                string command = commArgs[0];
                string argument = commArgs[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAutor(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
    class Article
    {
        public Article(string title,string content,string author)
        {
            Title = title;
            Content = content;     // конструктор
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; } // properties
        public string Author { get; set; }

        public void Edit (string content)
        {
            Content = content;
        }
        public void ChangeAutor(string author)
        {
            Author = author;
        }                                          // methode
        public void Rename(string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
