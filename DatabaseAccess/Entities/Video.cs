using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entities
{
    public class Video
    {
        [Key]
        public int Id { get; set; }

        [Required, DataType(DataType.Text), MinLength(2), MaxLength(255)]
        public string Title { get; set; }

        [DataType(DataType.Text), MinLength(2), MaxLength(24)]
        public string Category { get; set; }

        public int ProductionYear { get; set; }

        [DataType(DataType.Text), MinLength(2), MaxLength(4092)]
        public string Description { get; set; }

        public decimal PricePerDay { get; set; }
    }
}
