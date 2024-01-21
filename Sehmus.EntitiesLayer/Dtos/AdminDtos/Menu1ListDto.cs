using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.EntitiesLayer.Dtos.AdminDtos
{
    public class Menu1ListDto:AdminBaseDto
    {
        [Display(Name = "Menü Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Name { get; set; }
        [Display(Name = "Bağlantı Adresi")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Link { get; set; }
    }
}
