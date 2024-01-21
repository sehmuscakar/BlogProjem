using Sehmus.EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.EntitiesLayer.Dtos.AdminDtos
{
   public class BlogListDto:AdminBaseDto
    {
        public string Title { get; set; }
        [Display(Name = "Resim")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string BlogImage { get; set; }
        [Display(Name = "Blog Kategori Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string BlogCategoryName { get; set; }
        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Description { get; set; }
        [Display(Name = "Açıklama Detay")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string DescriptionDetails { get; set; }
        [Display(Name = "Oluşturulma Tarihi")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public DateTime CreatedDate { get; set; }
    }
}
