using System;

namespace InheritanceChallenge
{
    internal class VideoPost : Post
    {
        private string VideoURL { get; set; }
        private int Length { get; set; }

        public VideoPost () { }

        public VideoPost (string title, string sentByUser, string videoURL, int length, bool isPublic)
        {
            // Inherited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SentByUser = sentByUser;
            this.IsPublic = isPublic;

            // Own properties
            this.VideoURL = videoURL;
            this.Length = length;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SentByUser);
        }

        public void Play()
        {

        }

        public void Stop()
        {

        }
    }
}
