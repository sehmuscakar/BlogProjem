using System.ComponentModel.DataAnnotations;

namespace Sehmus.EntitiesLayer.Concrete
{
    public class Menu1:BaseEntity //Menu1 ilişkisiz olan modelimizdir
    {
      
        [Display(Name = "Menü Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Name { get; set; }
        [Display(Name = "Bağlantı Adresi")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Link { get; set; }
    }
}
