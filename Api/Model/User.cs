using Api.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("USERS")]
    public class User : BaseEntity
    {
        [Column("USERNAME")]
        public string Username { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("PASSWORD")]
        public string Password { get; set; }

        [Column("DISPLAYNAME")]
        public string DisplayName { get; set; }

        [Column("CREATED")]
        public DateTime? CreatedDate { get; set; }

        [Column("REFRESH_TOKEN")]
        public string RefreshToken { get; set; }

        [Column("REFRESH_TOKEN_EXPIRY_TIME")]
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}
