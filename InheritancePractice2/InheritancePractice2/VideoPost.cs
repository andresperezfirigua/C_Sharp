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

        
    }
}
