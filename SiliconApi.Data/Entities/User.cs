using System;
using System.Collections.Generic;

namespace SiliconApi.Data.Entities
{
    public class User
    {
        public User()
        {
            UserTokens = new HashSet<UserToken>();
        }

        public int Id { get; set; }
        public string Identity { get; set; }
        public DateTime BirthDate { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTimeOffset? LastLoggedIn { get; set; }
        public virtual ICollection<UserToken> UserTokens { get; set; }
    }
}