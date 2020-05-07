using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.EntitiesConfiguration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Username)
                .IsRequired()
                .HasColumnName("Username")
                .HasColumnOrder(2)
                .HasColumnType("nvarchar")
                .HasMaxLength(32);

            Property(c => c.Email)
                .IsRequired()
                .HasColumnName("Email")
                .HasColumnOrder(3)
                .HasColumnType("nvarchar")
                .HasMaxLength(64);

            Property(c => c.Password)
                .IsRequired()
                .HasColumnName("Password")
                .HasColumnOrder(4)
                .HasColumnType("nvarchar")
                .HasMaxLength(512);
        }
    }
}
