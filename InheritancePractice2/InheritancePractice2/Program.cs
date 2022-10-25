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

            Post thirdPost = new Post("Holi", "Pipesito", true);
            Console.WriteLine(thirdPost.ToString());

            ImagePost imagePost = new ImagePost("Holi aqui una imagen","https://image.com/picture", "Felipe", true);
            Console.WriteLine(imagePost.ToString());

            ImagePost imagePost2 = new ImagePost("Holi aqui otra imagen", "https://image.com/picture", "Diego", true);
            Console.WriteLine(imagePost2.ToString());

            VideoPost vp1 = new VideoPost("My first video","https://myvideo.com/first",20,"Felipito",true);
            Console.WriteLine(vp1.ToString());
            //vp1.Play();

            VideoPostSolved vps1 = new VideoPostSolved("My first video", "Felipito", "https://myvideo.com/first", true, 10);
            Console.WriteLine(vps1.ToString());
            vps1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            vps1.Stop();
        }
    }
}
