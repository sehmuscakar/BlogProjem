using System.ComponentModel.DataAnnotations;

namespace Sehmus.EntitiesLayer.Concrete
{
    public class Portfolio:BaseEntity
    {
        [Display(Name = "Resim")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string ImageUrl { get; set; }
        [Display(Name = "Kategori")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Category { get; set; }
        [Display(Name = "Müşteri")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Client { get; set; }
        [Display(Name = "Proje Url Yolu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string ProjectUrl { get; set; }
        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Description { get; set; }
    }
}
