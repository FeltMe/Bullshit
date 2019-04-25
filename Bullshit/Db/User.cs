using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullshit.Db
{
    class User
    {
        [Key]
        public int Id { get; set; }
        [Required] // provide Nut NULL
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool Right { get; set; } // 0-User, 1-Admin
    }
}
