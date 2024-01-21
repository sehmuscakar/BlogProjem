using Sehmus.CoreLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace Sehmus.EntitiesLayer.Concrete
{
    public class ContactPost:IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Ad")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Name { get; set; }
        [Display(Name = "E-posta")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Mail { get; set; }
        [Display(Name = "Konu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Subject { get; set; }
        [Display(Name = "Mesaj")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Message { get; set; }
    }
}
