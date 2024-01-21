using Sehmus.CoreLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace Sehmus.EntitiesLayer.Concrete
{
    public class BaseEntity:IEntity 
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Son Güncellenme Tarihi")]
        public DateTime? LastUpdatedAt { get; set; }
        [Display(Name = "Ekleyen kişi")]
        public int? AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
