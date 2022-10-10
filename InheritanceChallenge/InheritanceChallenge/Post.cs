using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    internal class Post
    {
        private int currentPostID;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SentByUser { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My first post";
            SentByUser = "Andres Perez";
            IsPublic = true;
        }

        public Post(string title, string sentByUser, bool isPublic)
        {
            ID = GetNextID();
            Title = title;
            SentByUser = sentByUser;
            IsPublic = isPublic;
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

