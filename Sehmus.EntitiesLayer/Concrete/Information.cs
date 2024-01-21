using System.ComponentModel.DataAnnotations;

namespace Sehmus.EntitiesLayer.Concrete
{
    public class Information:BaseEntity
    {
        [Display(Name = "Resim")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string ImageUrl { get; set; }
        [Display(Name = "Unvan")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Degree { get; set; }
        [Display(Name = "Hakkınızda")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string About { get; set; }

    }
}
