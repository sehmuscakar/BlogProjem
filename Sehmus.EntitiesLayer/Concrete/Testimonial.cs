using System.ComponentModel.DataAnnotations;

namespace Sehmus.EntitiesLayer.Concrete
{
    public class Testimonial:BaseEntity
    {
        [Display(Name = "Resim")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string ImageUrl { get; set; }
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Title { get; set; }
        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Description { get; set; }
    }
}
