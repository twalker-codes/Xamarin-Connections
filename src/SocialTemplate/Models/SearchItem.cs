using System;
using System.Collections.Generic;
using System.Text;

namespace SocialTemplate.Models
{
    /// <summary>
    /// Type represent search item entities
    /// </summary>
    public class SearchItem : Entity
    {
        public string Keyword { get; set; }

        public DateTime dateTimeUtc { get; set; }
    }
}
