using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Mappings
{
    public class AppRoleMap : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            // Primary key
            builder.HasKey(r => r.Id);

            // Index for "normalized" role name to allow efficient lookups
            builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

            // Maps to the AspNetRoles table
            builder.ToTable("AspNetRoles");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(256);
            builder.Property(u => u.NormalizedName).HasMaxLength(256);

            // The relationships between Role and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each Role can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.HasData(new AppRole
            {
                Id=Guid.Parse("dd891e4b-016c-4e33-81df-cc4bb161c918"),
                Name="SuperAdmin",
                ConcurrencyStamp=Guid.NewGuid().ToString(),
                NormalizedName="SUPERADMIN"
                
            },
            new AppRole
            {
                Id=Guid.Parse("5d2bcef0-df30-432a-812c-576447066440"),
                Name="User",
                ConcurrencyStamp=Guid.NewGuid().ToString(),
                NormalizedName="USER"
            },
               new AppRole
               {
                   Id=Guid.Parse("2f8b18ee-5e24-4a12-8b55-d28ea244ac44"),
                   Name="Admin",
                   ConcurrencyStamp=Guid.NewGuid().ToString(),
                   NormalizedName="ADMIN"
               });
        }
    }
}
