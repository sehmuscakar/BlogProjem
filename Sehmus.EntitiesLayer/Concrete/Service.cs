using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.EntitiesLayer.Concrete
{
   public class Service:BaseEntity
    {
        [Display(Name = "İcon Sınıf İsmi")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string IconUrl { get; set; }

        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Title { get; set; }
        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Description { get; set; }

    }
}
