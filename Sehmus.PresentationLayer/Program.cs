using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Sehmus.BusinessLayer.DependencyResolvers.Autofac;
using Sehmus.DataAccessLayer.Concrete.Context;
using Sehmus.EntitiesLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<ProjeContextDb>();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()); //gerekli kütüphaneleri kuur
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutofacBusinessModule()));//dependis enjekjýn  mantýðýný burayada entegre etik
builder.Services.AddDbContext<ProjeContextDb>(opt => //contextteki constractýr sýkýntý yaratýðý için diðer yöntemi kullandým.
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Local"));
});
builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<ProjeContextDb>()
    .AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider);//hangi tablolarý özeleþtirmiþsen onlarý buraya tanýman lazým ýdentitye ile sisteme önemli 
//þifre sýfýrlamada kullandýðýmýz için token buraya da ekiyoruz identityinin içine gerekli olaný 
builder.Services.AddMvc(config =>//bu tüm sistemi kilitliyor kimlik doðrulama oladan açýlmaz eriþilemez
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x => //otonatike olmayan kýsmý buraya yunlendirecek bunu yapmadan da  [AllowAnonymous] bu kodu controllera yazarak ta yapabilirsin 
{
    x.LoginPath = "/Admin/Login/SignÝn";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/Admin/Login/Error404", "?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
          name: "areas",
          pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
        );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Anasayfa}/{id?}");

app.Run();
