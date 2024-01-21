using Microsoft.AspNetCore.Identity;

namespace Sehmus.EntitiesLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public string ImageUrl { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }


        public List<Hero> Heroes { get; set; }
        public List<Menu1> Menus1 { get; set; }
        public List<Menu2> Menus2 { get; set; }
        public List<SubMenu> SubMenus { get; set; }
        public List<Information> Informations { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Service> Services { get; set; }
        public List<Counter> Counters { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<BlogSlider> BlogSliders { get; set; }
        public List<Contact> Contacts { get; set; }      
    }
}
