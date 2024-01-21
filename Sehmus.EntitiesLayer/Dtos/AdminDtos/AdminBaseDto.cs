using System.ComponentModel.DataAnnotations;

namespace Sehmus.EntitiesLayer.Dtos.AdminDtos
{
    public class AdminBaseDto
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Son Güncellenme Tarihi")]
        public DateTime? LastUpdatedAt { get; set; }
        public string CreatedFullName { get; set; }

   
    }
}
