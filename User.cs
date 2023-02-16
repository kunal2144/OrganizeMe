using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizeMe
{
    [Table("user")]
    internal class User : BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
