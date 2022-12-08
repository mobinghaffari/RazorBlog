using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace RazorBlog.Models
{
    public class CreateArticle
    {
        [DisplayName("عنوان")]
        [Required(ErrorMessage = "عنوان اجباری است")]
        public string? Title { get; set; }

        [DisplayName("عکس")]
        [Required(ErrorMessage = "عکس اجباری است")]
        public string Picture { get; set; }

        [DisplayName("عکس ALT")]
        [Required(ErrorMessage = "عکس alt  اجباری است")]
        public string PictureAlt { get; set; }

        [DisplayName("عنوان عکس")]
        [Required(ErrorMessage = "عنوان عکس اجباری است")]
        public string PictureTitle { get; set; }

        [DisplayName("توضیحات کوتاه")]
        [Required(ErrorMessage = "توضیحات  اجباری است")]
        public string ShortDescription { get; set; }

        [DisplayName("متن مقاله ")]
        public string Body { get; set; } 
       
    }
}
