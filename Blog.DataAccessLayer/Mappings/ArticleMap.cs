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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id=Guid.Parse("d478c1cb-8ae7-4b67-b7b7-98a476d5db53"),
                Title="Introduction to Machine Learning",
                Content="Machine learning is a subset of artificial intelligence that focuses on the development of computer programs that can learn from data and make predictions. It encompasses various techniques such as supervised learning, unsupervised learning, and reinforcement learning.",
                ViewCount=150,
                CategoryId=Guid.Parse("1e9bce48-0f9b-4f4f-a3f8-09d872750f67"),
                ImageId=Guid.Parse("a72bd43f-6c8d-49c4-b62c-ea7a18f0a9a1"),
                CreatedBy="John Doe",
                CreatedDate=DateTime.Now,
                IsDeleted=false,
                UserId=Guid.Parse("051f3b3b-eb13-488b-a4bf-387761ea91b0")

            },
            new Article
            {
                Id=Guid.Parse("b7f33d85-8e1b-4929-98a0-526d1c036b51"),
                Title="Python Basics Tutorial",
                Content="Python is a high-level programming language known for its simplicity and readability. This tutorial covers basic Python syntax, data types, control structures, and functions.",
                ViewCount=250,
                CategoryId=Guid.Parse("f9bc9a71-2dc1-48b5-ae97-237f4b23c754"),
                ImageId=Guid.Parse("a72bd43f-6c8d-49c4-b62c-ea7a18f0a9a1"),
                CreatedBy="Alice Johnson",
                CreatedDate=DateTime.Now,
                IsDeleted=false,
                UserId=Guid.Parse("face5fe3-2da2-408a-97a6-d5ca1fd7faf5")
            }) ;
        }
    }
}
