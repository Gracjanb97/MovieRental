using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entities
{
    public class VideoRental
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public decimal Price { get; set; }

        public int VideoId { get; set; }

        public virtual Video Video { get; set; }

        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}
