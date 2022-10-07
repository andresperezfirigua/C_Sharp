using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice2
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string imageURL, string sentByUser, bool isPublic)
        {
            // Properties inheterited from Post
            Title = title;
            SentByUser = sentByUser;
            IsPublic = isPublic;
            // ImagePost property
            ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} by {3}", this.ID, this.Title, this.ImageURL, this.SentByUser);
        }
    }
}
