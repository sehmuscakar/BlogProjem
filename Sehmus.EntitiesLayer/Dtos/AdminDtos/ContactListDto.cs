using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.EntitiesLayer.Dtos.AdminDtos
{
    public class ContactListDto:AdminBaseDto
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
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Mail { get; set; }
        [Display(Name = "Sosyal Medya 1")]
        [Url]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string SocialMedia1 { get; set; }
        [Display(Name = "Sosyal Medya 2")]
        [Url]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string SocialMedia2 { get; set; }
        [Display(Name = "Sosyal Medya 3")]
        [Url]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string SocialMedia3 { get; set; }
    }
}
