using AutoMapper;
using Blog.DataAccessLayer.UnitOfWork;
using Blog.Entity.Entities;
using Blog.Entity.ViewModel.Categories;
using Blog.Services.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.Services.Concrate
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;
        public CategoryService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<List<CategoryVM>> GetAllCategoriesNonDeleted()
        {
            var categories=await _unitOfWork.GetRepository<Category>().GetAllAsync(x=>x.IsDeleted==false);
            var map=mapper.Map<List<CategoryVM>>(categories);
            return map;
        }
    }
}
