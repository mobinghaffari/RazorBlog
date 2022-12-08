using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBlog.Models;

namespace RazorBlog.Pages
{
    public class CreateArticleModel : PageModel
    {
        public CreateArticle Command { get; set; }


        [TempData]
        public string ErrorMessage { get; set; }

     


        private readonly BlogContext _blogContext;

        public CreateArticleModel(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost(CreateArticle command)
        {

            if (ModelState.IsValid)
            {

                var article = new Article(command.Title, command.Picture, command.PictureAlt, command.PictureTitle,
                    command.ShortDescription, command.Body);
                _blogContext.Articles.Add(article);
                _blogContext.SaveChanges();
                return RedirectToPage("./Index");
            }
            else
            {
                ErrorMessage = "لطفا مقادیر خواسته شده را تکمیل نمایید";
                return Page();
            }
       
        }

    }
}
