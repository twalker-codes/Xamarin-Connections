using System;
using System.Collections.Generic;
using System.Text;

namespace SocialTemplate.Models
{
    /// <summary>
    /// Type represent message entities.
    /// </summary>
    public class Message : Entity
    {
        public string SenderId { get; set; }

        public string ReceiverId { get; set; }

        public string Text { get; set; }

        public DateTime DateUtc { get; set; }

    }
}
