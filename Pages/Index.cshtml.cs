using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBlog.Models;

namespace RazorBlog.Pages
{
    public class IndexModel : PageModel
    {
        public List<ArticleViewModel> Articles { get; set; }

        private readonly BlogContext _blogContext;

        public IndexModel(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public void OnGet()
        {
            Articles = _blogContext.Articles.Where(x=>x.IsDeleted==false).Select(x => new ArticleViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription,
                }).OrderByDescending(x=>x.Id).ToList();

        }

        public IActionResult OnGetDelete(int id)
        {
            var article = _blogContext.Articles.First(x=>x.Id==id);
            article.IsDeleted=true;
            _blogContext.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}