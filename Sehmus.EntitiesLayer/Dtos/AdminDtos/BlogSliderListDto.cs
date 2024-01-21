using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.EntitiesLayer.Dtos.AdminDtos
{
   public class BlogSliderListDto:AdminBaseDto
    {
        [Display(Name = "Başlık 1")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Title1 { get; set; }
        [Display(Name = "Resim")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string ImageUrl { get; set; }
        [Display(Name = "Başlık 2")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Title2 { get; set; }
        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Description { get; set; }
    }
}
