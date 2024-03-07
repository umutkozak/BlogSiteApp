using Blog.Entity.ViewModel.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.ViewModel.Articles
{
    public class ArticleAddVM
    {
        public  string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }
        public IList<CategoryVM>? Categories { get; set; }
    }
}
