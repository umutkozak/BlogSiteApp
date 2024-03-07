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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id=Guid.Parse("b04304e7-124a-4f5b-a472-07eb717d7a8c"),
                FileName="Example",
                FileType=".jpg",
                CreatedBy="John Doe",
                CreatedDate=DateTime.Now,
                IsDeleted=false,
            },
            new Image
            {
                Id=Guid.Parse("a72bd43f-6c8d-49c4-b62c-ea7a18f0a9a1"),
                FileName="Example2",
                FileType=".png",
                CreatedBy="Alice Johnson",
                CreatedDate=DateTime.Now,
                IsDeleted=false,
            }) ;
        }
    }
}
