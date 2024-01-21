using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.PresentationLayer.ViewComponents
{
    public class ProfileViewComponent:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileViewComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name); 
            AppUserEditDto appUserEditDto = new AppUserEditDto();
            appUserEditDto.Name = values.Name;
            appUserEditDto.LastName = values.LastName;     
            appUserEditDto.About = values.About;
            appUserEditDto.ImageUrl = appUserEditDto.ImageUrl;     
            appUserEditDto.ImageUrl = values.ImageUrl;
            return View(appUserEditDto);
        }
    }
}
