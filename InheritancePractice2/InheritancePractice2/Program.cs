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

<<<<<<< HEAD
            ImagePost imagePost2 = new ImagePost("Holi aqui otra imagen", "https://image.com/picture", "Diego", true);
            Console.WriteLine(imagePost2.ToString());
=======
            VideoPost vp1 = new VideoPost("My first video","https://myvideo.com/first",10,"Felipito",true);
            Console.WriteLine(vp1.ToString());
>>>>>>> debe68dca961385b54b3417ff67220fe9fe8d249
        }
    }
}
