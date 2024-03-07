using Blog.Entity.Entities;
using Blog.Entity.ViewModel.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.Services.Abstraction
{
    public interface IArticleService
    {
        Task<List<ArticleVM>> GetAllArticleWithCategoryNonDeletedAsycn();
        Task CreateArticleAddAsycn(ArticleAddVM articleVM);
        Task<ArticleVM> GetArticleWithCategoryNonDeletedAsycn(Guid articleId);
        Task<string> UpdateArticleAsycn(ArticleUpdateVM updateArticleVM);
        Task<string> SafeDeleteArticleAsycn(Guid Id);
    }
}
