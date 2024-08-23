using System;
using System.Collections.Generic;
using System.Text;

namespace SocialTemplate.Models
{
    /// <summary>
    /// Type represent notification entities.
    /// </summary>
    public class Notify : Entity
    {
        public string PersonId { get; set; }

        public string Text { get; set; }

        public DateTime DateUtc { get; set; }

        public bool HasIcon { get; set; }

        public bool IsQuestion { get; set; }

        public NotifyIcon NotifyIcon { get; set; }

        public string PersonPhoto { get; set; }

        public string PersonName { get; set; }

        public bool PersonTicked { get; set; }

        public static Notify OnlyText(string id, string personId, 
            string text, DateTime dateUtc)
        {
            return new Notify
            {
                Id = id,
                PersonId = personId,
                Text = text,
                DateUtc = dateUtc,
                HasIcon = false,
                IsQuestion = false,
                NotifyIcon = NotifyIcon.None
            };
        }

        public static Notify WithIcon(string id, string personId, string text,
                DateTime dateUtc, NotifyIcon notifyIcon) 
        {
            return new Notify
            {
                Id = id,
                PersonId = personId,
                Text = text,
                DateUtc = dateUtc,
                HasIcon = true,
                IsQuestion = false,
                NotifyIcon = notifyIcon
            };
        }

        public static Notify Question(string id, string personId,
            string text, DateTime dateUtc)
        {
            return new Notify
            {
                Id = id,
                PersonId = personId,
                Text = text,
                DateUtc = dateUtc,
                HasIcon = false,
                IsQuestion = true,
                NotifyIcon = NotifyIcon.None
            };
        }
    }
}
