using System;

namespace SiliconApi.Data.Entities
{
    public class UserToken
    {
        public int Id { get; set; }

        public string AccessToken { get; set; }

        public DateTimeOffset AccessTokenExpiresDateTime { get; set; }

        public string RefreshToken { get; set; }

        public DateTimeOffset RefreshTokenExpiresDateTime { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}