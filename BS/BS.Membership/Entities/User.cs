using BS.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Membership.Entities
{
    public class User : IdentityUser<int>, IEntity<int>
    {
        public bool IsBlocked { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime JoinedDate { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public string Company { get; set; }
        public string Website { get; set; }

        public string ProfilePicture { get; set; }

        public User() : base()
        {
            this.JoinedDate = DateTime.UtcNow;
        }

        public User(string username) : base(username)
        {
            this.JoinedDate = DateTime.UtcNow;

        }

        public User(string username, string email) : base(username)
        {
            this.Email = email;
            this.JoinedDate = DateTime.UtcNow;
        }
    }

}
