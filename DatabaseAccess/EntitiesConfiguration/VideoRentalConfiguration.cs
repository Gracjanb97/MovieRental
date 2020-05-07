using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.EntitiesConfiguration
{
    public class VideoRentalConfiguration : EntityTypeConfiguration<VideoRental>
    {
        public VideoRentalConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.DateCreated)
                .IsRequired()
                .HasColumnName("DateCreated")
                .HasColumnOrder(2)
                .HasColumnType("smalldatetime");

            Property(c => c.DateStart)
                .IsRequired()
                .HasColumnName("DateStart")
                .HasColumnOrder(3)
                .HasColumnType("smalldatetime");

            Property(c => c.DateEnd)
                .IsRequired()
                .HasColumnName("DateEnd")
                .HasColumnOrder(4)
                .HasColumnType("smalldatetime");

            Property(c => c.Price)
                .IsRequired()
                .HasColumnName("Price")
                .HasColumnOrder(5)
                .HasColumnType("smallmoney")
                .HasPrecision(10, 2);
        }
    }
}
