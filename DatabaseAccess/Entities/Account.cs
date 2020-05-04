using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entities
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required, DataType(DataType.Text), MinLength(3), MaxLength(24)]
        public string FirstName { get; set; }

        [Required, DataType(DataType.Text), MinLength(3), MaxLength(24)]
        public string LastName { get; set; }

        public decimal Balance { get; set; }
    }
}
