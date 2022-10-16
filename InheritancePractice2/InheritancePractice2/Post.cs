using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice2
{
    internal class Post
    {
        private static int currentPostID { get; set; }
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SentByUser { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            this.ID = 0;
            this.Title = "My first post";
            this.SentByUser = "Andres Perez";
            this.IsPublic = true;
        }

        public Post (string title, string sentByUser, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SentByUser = sentByUser;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostID;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} by {2}", this.ID, this.Title, this.SentByUser);
        }
    }
}
