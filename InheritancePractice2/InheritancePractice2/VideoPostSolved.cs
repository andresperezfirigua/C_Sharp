﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace InheritancePractice2
{
    internal class VideoPostSolved : Post
    {
        // Member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;
        // Properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }
        public VideoPostSolved() { }
        public VideoPostSolved(string title, string sentByUsername, string videoURL, bool isPublic, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SentByUser = sentByUsername;
            this.IsPublic = isPublic;

            this.VideoURL = videoURL;
            this.Length = length;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SentByUser);
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

        private void TimerCallback(object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            } else
            {
                Stop();
            }
        }
    }
}
