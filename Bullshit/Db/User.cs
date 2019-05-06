using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bullshit.Db
{
    [DataContract]
    public class User
    {
        [DataMember]
        [Key]
        public int Id { get; set; }

        [DataMember]
        [Required] // provide Nut NULL
        public string Login { get; set; }

        [DataMember]
        [Required]
        public string Password { get; set; }

        [DataMember]
        [Required]
        public bool Right { get; set; } // 0-User, 1-Admin
    }
}
