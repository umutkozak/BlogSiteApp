using AutoMapper;
using Blog.Entity.Entities;
using Blog.Entity.ViewModel.Articles;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.AutoMapper.Articles
{
    public class ArticleProfile:Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleVM,Article>().ReverseMap();
            CreateMap<ArticleUpdateVM,Article>().ReverseMap();
            CreateMap<ArticleUpdateVM,ArticleVM>().ReverseMap();
            CreateMap<ArticleAddVM,Article>().ReverseMap();
        }

    }
}
