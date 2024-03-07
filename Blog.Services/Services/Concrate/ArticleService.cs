using AutoMapper;
using Blog.DataAccessLayer.UnitOfWork;
using Blog.Entity.Entities;
using Blog.Entity.ViewModel.Articles;
using Blog.Services.Extensions;
using Blog.Services.Services.Abstraction;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.Services.Concrate
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor accessor;
        private readonly ClaimsPrincipal _user;
        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper,IHttpContextAccessor accessor)
        {
            this.unitOfWork = unitOfWork;
            this.mapper=mapper;
            this.accessor=accessor;
            _user=accessor.HttpContext.User;
        }

        public async Task CreateArticleAddAsycn(ArticleAddVM articleVM)
        {
            var userId = _user.LoggedInId();
            var email=_user.LoggedInEmail();
            var ımageId = Guid.Parse("a72bd43f-6c8d-49c4-b62c-ea7a18f0a9a1");
            var article = new Article(articleVM.Title, articleVM.Content, userId, articleVM.CategoryId,ımageId,email); 
           
            await unitOfWork.GetRepository<Article>().AddAsync(article);
            await unitOfWork.SaveAsycn();
        }

        public async Task<List<ArticleVM>> GetAllArticleWithCategoryNonDeletedAsycn()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync( x => x.IsDeleted==false,x=>x.Category);
            var map = mapper.Map<List<ArticleVM>>(articles);

            return map;
        }



        public async Task<ArticleVM> GetArticleWithCategoryNonDeletedAsycn(Guid articleId)
        {
            var article = await unitOfWork.GetRepository<Article>().GetAsycn(x=>x.IsDeleted==false && x.Id==articleId,x=>x.Category);
            
            var map = mapper.Map<ArticleVM>(article);

            return map;
        }

        public async Task<string> SafeDeleteArticleAsycn(Guid Id)
        {
            var article=await unitOfWork.GetRepository<Article>().GetByGuidAsycn(Id);
            var email = _user.LoggedInEmail();
            article.IsDeleted = true;
            article.DeletedDate = DateTime.Now; 
            article.DeletedBy=email;
            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsycn();
            return article.Title;
        }

        public async Task<string> UpdateArticleAsycn(ArticleUpdateVM updateArticleVM)
        {
           
            var email = _user.LoggedInEmail();
            var article = await unitOfWork.GetRepository<Article>().GetAsycn(x => x.IsDeleted==false && x.Id==updateArticleVM.Id, x => x.Category);
            
            article.Title=updateArticleVM.Title;
            article.Content=updateArticleVM.Content;
            article.CategoryId=updateArticleVM.CategoryId;
            article.ModifiedDate=DateTime.Now;
            article.ModifiedBy=email;

            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsycn();
            return article.Title;

        }

       
    }
}
