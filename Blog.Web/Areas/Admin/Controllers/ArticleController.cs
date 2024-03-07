using AutoMapper;
using Blog.Entity.Entities;
using Blog.Entity.ViewModel.Articles;
using Blog.Services.Extensions;
using Blog.Services.Services.Abstraction;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        IArticleService articleService;
        ICategoryService categoryService;
        IMapper mapper;
        IValidator<Article> validator;
        IToastNotification notification;

        public ArticleController(IArticleService service, ICategoryService cService, IMapper _mapper, IValidator<Article> _validator,IToastNotification _toastNotification)
        {
            articleService = service;
            categoryService=cService;
            mapper = _mapper;
            validator = _validator;
            notification = _toastNotification;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticleWithCategoryNonDeletedAsycn();
            return View(articles);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            try
            {

                var categories = await categoryService.GetAllCategoriesNonDeleted();

                if (categories == null)
                {

                    return RedirectToAction("Error", "Home");
                }

                return View(new ArticleAddVM { Categories =categories });
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddVM articleAddVM)
        {
            var map = mapper.Map<Article>(articleAddVM);
            var result = await validator.ValidateAsync(map);
            if (result.IsValid)
            {
                await articleService.CreateArticleAddAsycn(articleAddVM);
                notification.AddSuccessToastMessage(ResultMessages.Messages.Add(articleAddVM.Title), new ToastrOptions { Title="Başarılı" });
                return RedirectToAction("/Admin/Article/Index");

            }
            else
            {
                result.AddToModelState(this.ModelState);//Giriş hatalıysa

            }
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleAddVM { Categories=categories });
        }

        [HttpGet]
        public async Task<ActionResult> Update(Guid Id)
        {
            var article = await articleService.GetArticleWithCategoryNonDeletedAsycn(Id);
            var categories = await categoryService.GetAllCategoriesNonDeleted();

            var articleUpdated = mapper.Map<ArticleUpdateVM>(article);
            articleUpdated.Categories = categories;

            return View(articleUpdated);
        }
        [HttpPost]
        public async Task<ActionResult> Update(ArticleUpdateVM vm)
        {
            var map = mapper.Map<Article>(vm);
            var result = await validator.ValidateAsync(map);
            if (result.IsValid)
            {
                await articleService.UpdateArticleAsycn(vm);
            }
            else
            {
                result.AddToModelState(this.ModelState);
            }

            var categories = await categoryService.GetAllCategoriesNonDeleted();
            vm.Categories = categories;
            return View(vm);
        }

        public async Task<ActionResult> Delete(Guid Id)
        {
            await articleService.SafeDeleteArticleAsycn(Id);

            return RedirectToAction("Index");


        }
    }
}
