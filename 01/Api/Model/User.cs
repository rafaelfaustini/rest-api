using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model
{
    [Table("USER")]
    public class User
    {
        [Column("ID")]
        public long Id { get; set; }

        [Column("USERNAME")]
        public string Username { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("PASSWORD")]
        public string Password { get; set; }

        [Column("DISPLAYNAME")]
        public string DisplayName { get; set; }

        [Column("CREATED")]
        public DateTime CreatedDate { get; set; }
    }
}
