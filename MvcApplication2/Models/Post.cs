using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public class Post
    {
        [Required(ErrorMessage = "必填")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}