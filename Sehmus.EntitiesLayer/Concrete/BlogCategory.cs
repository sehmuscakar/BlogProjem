using System.ComponentModel.DataAnnotations;

namespace Sehmus.EntitiesLayer.Concrete
{
    public class BlogCategory:BaseEntity
    {
        [Display(Name = "Ad")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Name { get; set; }
        [Display(Name = "Link")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Link { get; set; }
        public List<Blog> Blogs { get; set; }   
    }
}
