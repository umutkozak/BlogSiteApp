using Blog.Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.FluentValidations
{
    public class ArticleValidator:AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.Title).NotEmpty()
                   .NotNull().WithMessage("Başlık boş olamaz.")
                   .MinimumLength(3)
                   .MaximumLength(100).WithMessage("Başlık en fazla 100 karakter olabilir.");
            
            
        }
    }
}
