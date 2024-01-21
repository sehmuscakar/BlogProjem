using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.EntitiesLayer.Dtos.AdminDtos
{
    public class CounterListDto:AdminBaseDto
    {
        [Display(Name = "İcon Sınıf İsmi")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Icon { get; set; }
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Title { get; set; }
        [Display(Name = "Toplam")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [Range(1, 1000, ErrorMessage = "1 ile 1000  arasında bir sayı giriniz lütfen.")]
        public int? Number { get; set; }
    }
}
