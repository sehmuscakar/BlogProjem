using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.EntitiesLayer.Dtos.AdminDtos
{
    public class PortfolioListDto:AdminBaseDto
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
        [Url]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string ProjectUrl { get; set; }
        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Description { get; set; }
    }
}
