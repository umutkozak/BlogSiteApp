using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category { 
            Id=Guid.Parse("1e9bce48-0f9b-4f4f-a3f8-09d872750f67"),
            Name="Sample",
            CreatedBy="John Doe",
            CreatedDate=DateTime.Now,
            IsDeleted=false,
            
            },
            new Category
            {
                Id=Guid.Parse("f9bc9a71-2dc1-48b5-ae97-237f4b23c754"),
                Name="Presentation",
                CreatedBy="John Doe",
                CreatedDate=DateTime.Now,
                IsDeleted=false,
            });
        }
    }
}
