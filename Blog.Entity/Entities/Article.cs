using Blog.Core.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    public class Article:BaseEntity 
    {
        public Article()
        {
            
        }
        public Article(string title,string content,Guid userId,Guid categoryId,Guid ImageId,string createdBy)
        {
            Title = title;
            Content = content;
            UserId = userId;
            CategoryId = categoryId;
            CreatedBy= createdBy;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; } = 0;
        public Guid CategoryId { get; set; }
        public Category  Category { get; set; }

        public Guid? ImageId { get; set; }
        public Image? Image { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get;set; }
    }
}
