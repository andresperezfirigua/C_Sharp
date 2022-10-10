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

            ImagePost imagePost = new ImagePost();
            Console.WriteLine(imagePost.ToString());

            VideoPost vp1 = new VideoPost("My first video","https://myvideo.com/first",10,"Felipito",true);
            Console.WriteLine(vp1.ToString());
        }
    }
}
