using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.EntitiesLayer.Dtos.AdminDtos
{
    public class InformationListDto:AdminBaseDto
    {
        [Display(Name = "Resim")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string ImageUrl { get; set; }
        [Display(Name = "Eğitim")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string School { get; set; }
        [Display(Name = "Unvan")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Degree { get; set; }
        [Display(Name = "Hakkınızda")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string About { get; set; }
    }
}
