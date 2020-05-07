using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entities
{
    public class Video
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public int ProductionYear { get; set; }

        public string Description { get; set; }

        public decimal PricePerDay { get; set; }
    }
}
