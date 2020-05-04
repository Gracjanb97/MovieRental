using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }


        [Required, DataType(DataType.Text), MaxLength(128)]
        public string Token { get; set; }


        [Required, DataType(DataType.Text), MinLength(5), MaxLength(32)]
        public string Username { get; set; }


        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required, DataType(DataType.Text), MinLength(6), MaxLength(20)]
        public string Password { get; set; }


        public bool IsActive { get; set; }
    }
}
