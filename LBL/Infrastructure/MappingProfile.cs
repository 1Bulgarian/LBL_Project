using AutoMapper;
using LBL.Data.Models;
using LBL.Models.Article;
using LBL.Services.Articles;
using LBL.Services.Teams;
using LBL.Services.Teams.Models;

namespace LBL.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Articles
            this.CreateMap<Category, ArticleCategoriesServiceModel>();

            this.CreateMap<ArticleDetailsServiceModel, AddArticleFormModel>();

            this.CreateMap<Article, ArticleServiceModel>()
                .ForMember(c=> c.CategoryName, cfg=> cfg.MapFrom(c => c.Category.Name));

            this.CreateMap<Article, ArticleDetailsServiceModel>()
                .ForMember(c => c.UserId, cfg => cfg.MapFrom(c => c.Author.UserId))
                .ForMember(c => c.CategoryName, cfg => cfg.MapFrom(c => c.Category.Name));

            this.CreateMap<Columnist, ArticleDetailsServiceModel>()
                .ForMember(c => c.AuthorId, cfg => cfg.MapFrom(r => r.Id));


            //Teams
            this.CreateMap<Region, TeamRegionServiceModel>();

            this.CreateMap<TeamDetailsServiceModel, TeamFormModel>();

            this.CreateMap<Team, TeamServiceModel>()
                .ForMember(c => c.RegionName, cfg => cfg.MapFrom(c => c.Region.ShortName));

            this.CreateMap<Team, TeamDetailsServiceModel>()
                .ForMember(c => c.RegionName, cfg => cfg.MapFrom(c => c.Region.ShortName));
        }
    }
}
