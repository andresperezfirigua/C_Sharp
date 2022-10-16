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

        private Timer timer;
        private int elapsedSeconds { get; set; }



        public VideoPost() { }

        public VideoPost (string title, string videoURL, int length, string sentByUser, bool isPublic)
        {
            this.ID = GetNextID();
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

            if(Console.ReadKey().Key != null)
            {
                this.Stop();
            }
        }

        public void Stop()
        {
            Console.WriteLine("Stopped at {0}s", elapsedSeconds);
        }

        public void DisplayTimeEvent (object source, ElapsedEventArgs e)
        {
            if(elapsedSeconds != Length)
            {
                Console.WriteLine(" \r{0}", ++elapsedSeconds);
            } else
            {
                this.Stop();
                timer.Stop();
                timer.Dispose();
            }
        }
    }
}
