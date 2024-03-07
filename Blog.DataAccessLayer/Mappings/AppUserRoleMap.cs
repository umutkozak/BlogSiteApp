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
    public class AppUserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");
            builder.HasData(new AppUserRole
            {
                UserId=Guid.Parse("face5fe3-2da2-408a-97a6-d5ca1fd7faf5"),
                RoleId=Guid.Parse("dd891e4b-016c-4e33-81df-cc4bb161c918")
            },
            new AppUserRole 
            {
                UserId=Guid.Parse("051f3b3b-eb13-488b-a4bf-387761ea91b0"),
                RoleId=Guid.Parse("2f8b18ee-5e24-4a12-8b55-d28ea244ac44")
            }
            );
        }
    }
}
