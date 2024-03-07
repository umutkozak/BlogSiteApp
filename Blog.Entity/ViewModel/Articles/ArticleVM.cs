using Blog.Entity.ViewModel.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.ViewModel.Articles
{
    public class ArticleVM
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public  string Content { get; set; }
       
        public CategoryVM? Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
