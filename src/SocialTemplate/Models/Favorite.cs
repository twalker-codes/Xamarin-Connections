using System;
using System.Collections.Generic;
using System.Text;

namespace SocialTemplate.Models
{
    /// <summary>
    /// Type represent favorite entity.
    /// </summary>
    public class Favorite : Entity
    {
        public string PostId { get; set; }

        public string PersonId { get; set; }
    }
}
