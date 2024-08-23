using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialTemplate.Models
{
    /// <summary>
    /// Type represent post entities
    /// </summary>
    public class Post : Entity
    {
        public string AuthorId { get; set; }

        public DateTime DateUtc { get; set; }

        public string Text { get; set; }

        public string[] Images { get; set; }

        public int ViewCount { get; set; }

        public int CommentCount { get; set; }

        public int FavoriteCount { get; set; }

        public string AuthorPhoto { get; set; }

        public string AuthorName { get; set; }

        public string AuthorUsername { get; set; }

        public bool AuthorTicked { get; set; }

        public bool IsFavorite { get; set; }

        public string FirstImage
        {
            get => Images.Count() != 0 ? Images[0] : "no_image";
        }

    }
}
