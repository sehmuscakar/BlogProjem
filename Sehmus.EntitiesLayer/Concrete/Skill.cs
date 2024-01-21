using System.ComponentModel.DataAnnotations;

namespace Sehmus.EntitiesLayer.Concrete
{
    public class Skill:BaseEntity
    {
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Title { get; set; }
        [Display(Name = "Oran")]
       [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [Range(1, 99, ErrorMessage = "Oran 1 ile 99 arasında olmalıdır.")]
        public int? Number { get; set; }
    }
}
