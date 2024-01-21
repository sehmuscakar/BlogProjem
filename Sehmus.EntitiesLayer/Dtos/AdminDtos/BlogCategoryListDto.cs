using Sehmus.EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.EntitiesLayer.Dtos.AdminDtos
{
    public class BlogCategoryListDto:AdminBaseDto
    {
        [Display(Name = "Ad")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Name { get; set; }
        [Display(Name = "Link")]
        [Url]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Link { get; set; }
      
    }
}
