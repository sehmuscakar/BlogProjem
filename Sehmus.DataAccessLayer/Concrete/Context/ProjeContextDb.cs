using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sehmus.EntitiesLayer.Concrete;

namespace Sehmus.DataAccessLayer.Concrete.Context
{
    public class ProjeContextDb : IdentityDbContext<AppUser, AppRole, int> 
    {

        public ProjeContextDb(DbContextOptions<ProjeContextDb> options) : base(options)
        {

        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Menu1> Menus1 { get; set; }
        public DbSet<Menu2> Menus2 { get; set; }
        public DbSet<SubMenu> SubMenus { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogSlider> BlogSliders { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactPost> ContactPosts { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    optionsBuilder.UseSqlServer("Server=DESKTOP-PBFD0LU;Database=Sehmus.BlogDb;Integrated Security=true;TrustServerCertificate=true;");
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Hero>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.Heroes).HasForeignKey(x => x.AppUserId);
            });

            base.OnModelCreating(builder);
        }

    }
}
