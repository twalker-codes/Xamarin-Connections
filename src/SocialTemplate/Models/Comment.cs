using System;
using System.Collections.Generic;
using System.Text;

namespace SocialTemplate.Models
{
    /// <summary>
    /// Type represent comment entities.
    /// </summary>
    public class Comment : Entity
    {
        public DateTime DateUtc { get; set; }

        public string Text { get; set; }

        public string PostId { get; set; }

        public string AuthorId { get; set; }

        public string AuthorPhoto { get; set; }

        public string AuthorName { get; set; }

        public string AuthorUsername { get; set; }

        public bool AuthorTicked { get; set; }


    }
}
