using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.EntitiesLayer.Concrete
{
    public class SubMenu:BaseEntity
    {
        [Display(Name = "Alt Menü Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Name { get; set; }
        [Display(Name = "Bağlantı Adresi")]
     
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Link { get; set; }
        [Display(Name = "İlişkili Menü Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public int? Menu2Id { get; set; }
      
        public Menu2 Menu2 { get; set; }
    }
}
