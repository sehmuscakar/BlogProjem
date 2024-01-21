using System.ComponentModel.DataAnnotations;

namespace Sehmus.EntitiesLayer.Concrete
{
    public class Blog:BaseEntity
    {
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Title { get; set; }
        [Display(Name = "Resim")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string BlogImage { get; set; }
        [Display(Name = "Blog Kategori İd")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public int? BlogCategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }
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
