using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entities
{
    public class Account
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Balance { get; set; }

        public virtual UserProfile User { get; set; }

        public ICollection<VideoRental> VideoRentals { get; set; }
    }
}
