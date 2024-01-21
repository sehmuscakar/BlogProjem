using System.ComponentModel.DataAnnotations;

namespace Sehmus.EntitiesLayer.Concrete
{
    public class Contact:BaseEntity
    {
        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Description { get; set; }
        [Display(Name = "Adres")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Address { get; set; }
        [Display(Name = "Telefon")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Phone { get; set; }
        [Display(Name = "E-Posta")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [EmailAddress]
        public string Mail { get; set; }
        [Display(Name = "Sosyal Medya 1")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string SocialMedia1 { get; set; }
        [Display(Name = "Sosyal Medya 2")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string SocialMedia2 { get; set; }
        [Display(Name = "Sosyal Medya 3")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string SocialMedia3 { get; set; }
    }
}
