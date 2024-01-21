using System.ComponentModel.DataAnnotations;

namespace Sehmus.EntitiesLayer.Concrete
{
    public class Hero:BaseEntity
    {
        [Display(Name = "Resim")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string ImageUrl { get; set; }
        [Display(Name = "Uzmanlık Öğe")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string ExpertItem { get; set; }
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Title { get; set; }
    }
}
