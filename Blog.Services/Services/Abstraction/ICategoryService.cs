using Blog.Entity.ViewModel.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.Services.Abstraction
{
    public interface ICategoryService
    {
        public Task<List<CategoryVM>> GetAllCategoriesNonDeleted();
    }
}
