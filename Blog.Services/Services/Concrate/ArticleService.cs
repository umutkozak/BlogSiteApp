using AutoMapper;
using Blog.DataAccessLayer.UnitOfWork;
using Blog.Entity.Entities;
using Blog.Entity.ViewModel.Articles;
using Blog.Services.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.Services.Concrate
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper=mapper;
        }

        public async Task CreateArticleAddAsycn(ArticleAddVM articleVM)
        {
            var userId = Guid.Parse("face5fe3-2da2-408a-97a6-d5ca1fd7faf5");
            var ımageId = Guid.Parse("a72bd43f-6c8d-49c4-b62c-ea7a18f0a9a1");
            var article = new Article(articleVM.Title, articleVM.Content, userId, articleVM.CategoryId,ımageId); 
           
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

        public async Task SafeDeleteArticleAsycn(Guid Id)
        {
            var article=await unitOfWork.GetRepository<Article>().GetByGuidAsycn(Id);

            article.IsDeleted = true;
            article.DeletedDate = DateTime.Now; 

            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsycn();
        }

        public async Task UpdateArticleAsycn(ArticleUpdateVM updateArticleVM)
        {
            var article = await unitOfWork.GetRepository<Article>().GetAsycn(x => x.IsDeleted==false && x.Id==updateArticleVM.Id, x => x.Category);
            
            article.Title=updateArticleVM.Title;
            article.Content=updateArticleVM.Content;
            article.CategoryId=updateArticleVM.CategoryId;

            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsycn();

        }
    }
}
