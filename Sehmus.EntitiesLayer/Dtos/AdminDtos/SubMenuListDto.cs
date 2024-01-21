using Sehmus.EntitiesLayer.Concrete;
using System.ComponentModel.DataAnnotations;

namespace Sehmus.EntitiesLayer.Dtos.AdminDtos
{
    public class SubMenuListDto:AdminBaseDto
    {
        [Display(Name = "Alt Menü Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Name { get; set; }
        [Display(Name = "Bağlantı Adresi")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Link { get; set; }
        [Display(Name = "İlişkili Menü Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Menu2Name { get; set; }    

    }
}
