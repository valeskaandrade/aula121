using System;
using Publicacao.Entities;
using System.Collections.Generic; // para usar o List
namespace Publicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //aula 121 - stringbuilder
            Console.WriteLine("Quantos Posts: ");
            int p = int.Parse(Console.ReadLine());

            List<Post> posts = new List<Post>();

            for (int i= 1; i <= p; i++)
            {
                Console.Write("Moment: ");
                DateTime moment = DateTime.Parse(Console.ReadLine());

                Console.Write("Title: ");
                string title = Console.ReadLine();

                Console.Write("Content: ");
                string content = Console.ReadLine();

                Console.Write("Likes: ");
                int likes = int.Parse(Console.ReadLine());

                Post post = new Post(moment,title,content,likes);
                
                Console.Write("Quantos Comentários: ");
                int c = int.Parse(Console.ReadLine());
                for (int j = 1; j <= c; j++)
                {
                    Console.Write($"Comentário {j}: ");
                    
                    Comment comment = new Comment(Console.ReadLine());
                    post.AddComment(comment);
                }
                posts.Add(post);
            }
            foreach (Post po in posts)
            {
                Console.WriteLine(po.ToString()); 
            }
        }
    }
}
