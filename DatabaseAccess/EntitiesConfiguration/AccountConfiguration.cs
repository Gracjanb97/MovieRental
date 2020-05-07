using DatabaseAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.EntitiesConfiguration
{
    public class AccountConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasColumnType("varchar")
                .HasColumnOrder(2)
                .HasMaxLength(64);

            Property(c => c.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType("varchar")
                .HasColumnOrder(3)
                .HasMaxLength(64);

            Property(c => c.Balance)
                .IsOptional()
                .HasColumnName("Balance")
                .HasColumnType("smallmoney")
                .HasColumnOrder(4)
                .HasPrecision(10, 2);

            HasRequired(c => c.User)
                .WithRequiredPrincipal(c => c.Account);

            HasMany(c => c.VideoRentals)
                .WithRequired(c => c.Account)
                .HasForeignKey(c => c.AccountId);
        }
    }
}
