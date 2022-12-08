using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBlog.Models;

namespace RazorBlog.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleViewModel Article { get; set; }

        private readonly BlogContext _blogContext;

        public ArticleDetailsModel(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public void OnGet(int id)
        {
            Article = _blogContext.Articles.Select(x => new ArticleViewModel
            {
                Id=x.Id,
                Body = x.Body,
                CreationDate = x.CreationDate.ToString(),
                Title = x.Title,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle
            }).FirstOrDefault(x => x.Id == id);
        }
    }
}
