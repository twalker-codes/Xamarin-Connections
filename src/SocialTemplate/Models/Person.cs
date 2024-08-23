using System;
using System.Collections.Generic;
using System.Text;

namespace SocialTemplate.Models
{
    /// <summary>
    /// Type represent person entities
    /// </summary>
    public class Person : Entity
    {
        public string Cover { get; set; }

        public string Photo { get; set; }

        public string FullName { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool Ticked { get; set; }

        public bool Follower { get; set; }

        public bool Following { get; set; }

        public DateTime MemberDate { get; set; }

        public DateTime? RecentContact { get; set; }

        public int PostCount { get; set; }

        public int FollowerCount { get; set; }

        public int FollowingCount { get; set; }
    }
}
