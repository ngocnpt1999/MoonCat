using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MoonCat.Model
{
    [Table("User")]
    public class User
    {
        [Column("username")]
        public string UserName { get; set; }
        [Column("password")]
        public string PassWord { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("avatar")]
        public string Avatar { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
    }
}
