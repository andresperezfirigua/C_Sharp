using System;
using System.Timers;

namespace InheritanceChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post firstPost = new Post();
            Console.WriteLine(firstPost.ToString());
            Post secondPost = new Post("Holi", "Angelito", true);
            Console.WriteLine(secondPost.ToString());

            ImagePost imagePost = new ImagePost("Holi aqui una imagen", "https://image.com/picture", "Felipe", true);
            Console.WriteLine(imagePost.ToString());

            ImagePost imagePost2 = new ImagePost("Holi aqui otra imagen", "https://image.com/picture", "Diego", true);
            Console.WriteLine(imagePost2.ToString());

            VideoPost vp1 = new VideoPost("My first video","Sebastian","https://myvideo/first", 1000,true);
            Console.WriteLine(vp1.ToString());

            Timer timer = new Timer();
        }
    }
}
