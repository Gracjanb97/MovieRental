using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.EntitiesConfiguration
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("nvarchar")
                .HasColumnOrder(2)
                .HasMaxLength(128);

            Property(c => c.Category)
                .IsOptional()
                .HasColumnName("Category")
                .HasColumnType("nvarchar")
                .HasColumnOrder(3)
                .HasMaxLength(64);

            Property(c => c.ProductionYear)
                .IsOptional()
                .HasColumnName("ProductionYear")
                .HasColumnType("int")
                .HasColumnOrder(4);

            Property(c => c.Description)
                .IsOptional()
                .HasColumnName("Description")
                .HasColumnType("ntext")
                .HasColumnOrder(5);

            Property(c => c.PricePerDay)
                .IsRequired()
                .HasColumnName("PricePerDay")
                .HasColumnType("smallmoney")
                .HasPrecision(10, 2);
        }
    }
}
