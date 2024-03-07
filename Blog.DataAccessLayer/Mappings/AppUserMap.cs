using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Mappings
{
    public class AppUserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            // Primary key
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNeAppUsers table
            builder.ToTable("AspNetAppUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
            var superAdmin = new AppUser
            {
                Id=Guid.Parse("face5fe3-2da2-408a-97a6-d5ca1fd7faf5"),
                UserName="superadmin@gmail.com",
                NormalizedEmail="SUPERADMIN@GMAIL.COM",
                Email="superadmin@gmail.com",
                PhoneNumber="+905436765432",
                PhoneNumberConfirmed=true,
                EmailConfirmed=true,
                SecurityStamp=Guid.NewGuid().ToString(),
                Name="Ali",
                LastName="Ay",
                ImageId=Guid.Parse("b04304e7-124a-4f5b-a472-07eb717d7a8c")



            };
            superAdmin.PasswordHash=CreatePasswordHash(superAdmin, "123456");
            var admin= new AppUser
                    {
                Id=Guid.Parse("051f3b3b-eb13-488b-a4bf-387761ea91b0"),
                        UserName="admin@gmail.com",
                        NormalizedEmail="ADMIN@GMAIL.COM",
                        Email="superadmin@gmail.com",
                        PhoneNumber="+905436765465",
                        PhoneNumberConfirmed=false,
                        EmailConfirmed=false,
                        SecurityStamp=Guid.NewGuid().ToString(),
                        Name="Ahmet",
                        LastName="Ak",
                        ImageId=Guid.Parse("a72bd43f-6c8d-49c4-b62c-ea7a18f0a9a1"),
                        

            };
            admin.PasswordHash =CreatePasswordHash(admin, "123456");
            builder.HasData(superAdmin, admin);
               
                 
            

        }
        private string CreatePasswordHash(AppUser user, string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
