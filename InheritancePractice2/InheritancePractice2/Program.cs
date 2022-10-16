using System;

namespace InheritancePractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post firstPost = new Post();
            Console.WriteLine(firstPost.ToString());
            Post secondPost = new Post("Holi","Angelito",true);
            Console.WriteLine(secondPost.ToString());

            ImagePost imagePost = new ImagePost("Holi aqui una imagen","https://image.com/picture", "Felipe", true);
            Console.WriteLine(imagePost.ToString());

            ImagePost imagePost2 = new ImagePost("Holi aqui otra imagen", "https://image.com/picture", "Diego", true);
            Console.WriteLine(imagePost2.ToString());

            VideoPost vp1 = new VideoPost("My first video","https://myvideo.com/first",20,"Felipito",true);
            Console.WriteLine(vp1.ToString());
            vp1.Play();
        }
    }
}
