using Sehmus.EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.EntitiesLayer.Dtos
{
    public class BlogDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string BlogImage { get; set; }
        public string BlogCategoryName { get; set; }       
        public string Description { get; set; }
        public string DescriptionDetails { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
