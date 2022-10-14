using Coloring.Business.Interface;
using Coloring.Entity.Entities;
using Coloring.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Coloring.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericService<Color> _genericService;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(IGenericService<Color> genericService, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _genericService = genericService;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(AppUserSignInModel model)
        {
            if (ModelState.IsValid)
            {
              var user=await  _userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                   var result=await _signInManager.PasswordSignInAsync(model.UserName,model.Password,model.RememberMe,false);
                    if (result.Succeeded)
                    {
                      var roles= await _userManager.GetRolesAsync(user);
                        if (roles.Contains("Member"))
                        {
                            return RedirectToAction("Index", "Home", new { area = "Member" });
                        }
                       
                    }
                    
                }
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
            }
            return View("Index",model);
        }


        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(AppUserAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserName = model.UserName,
                    Name = model.Name,
                    Surname = model.Surname,
                    Email = model.Email
                };
              var result= await _userManager.CreateAsync(user,model.Password);
                if (result.Succeeded)
                {
                  var roleResult= await _userManager.AddToRoleAsync(user, "Member");
                    if (roleResult.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    foreach(var item in roleResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
          
            return View(model);
        }
        public async Task<IActionResult> SignOut()
        {
           await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }


    }
}