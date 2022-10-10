using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace InheritancePractice2
{
    internal class VideoPost : Post
    {
        private string VideoURL { get; set; }
        private int Length { get; set; }

        public Timer timer;



        public VideoPost() { }

        public VideoPost (string title, string videoURL, int length, string sentByUser, bool isPublic)
        {
            this.Title = title;
            this.VideoURL = videoURL;
            this.Length = length;
            this.SentByUser = sentByUser;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SentByUser);
        }

        public void Play()
        {
            timer = new Timer();
            timer.Elapsed += DisplayTimeEvent;
            timer.Interval = 1000;
            timer.Enabled = true;

            Console.WriteLine("Press any key to pause sequence");
            Console.ReadKey();
        }

        public void DisplayTimeEvent (object source, ElapsedEventArgs e)
        {
            Console.WriteLine(" \r{0}", DateTime.Now);
        }
    }
}
