using Coloring.Business.Interface;
using Coloring.Entity.Entities;
using Coloring.Web.Areas.Member.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace Coloring.Web.Areas.Member.Controllers
{
    [Authorize(Roles = "Member")]
    [Area("Member")]
    public class HomeController : Controller
    {
        private readonly IGenericService<ColorType> _genericService;
        private readonly IGenericService<ImageArea> _imageAreagenericService;
        private readonly IGenericService<ColorImage> _colorImageService;
        private readonly UserManager<AppUser> _userManager;
        public HomeController(IGenericService<ColorType> genericService, IGenericService<ImageArea> imageAreagenericService, UserManager<AppUser> userManager, IGenericService<ColorImage> colorImageService)
        {
            _genericService = genericService;
            _imageAreagenericService = imageAreagenericService;
            _userManager = userManager;
            _colorImageService = colorImageService;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Colors = new SelectList(await _genericService.GetAllAsync(), "Id", "Name");
            ViewBag.ImageAreas = await _imageAreagenericService.GetAllAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ColorImageSave(List<ColorImageModel> colorImages)
        {         
            if (colorImages != null && colorImages.Count > 0)
            {
                var userId = _userManager.GetUserId(User);
                var entity = new ColorImage();
                entity.AppUserId = int.Parse(userId);
                entity.ImageAreaColor = JsonConvert.SerializeObject(colorImages);
                await _colorImageService.AddAsync(entity);

                return Json("Success");
            }           
            return Json("Error");
        }

        //public async Task<IActionResult> Index()
        //{
        //    var colors = await _genericService.GetAllAsync();
        //    List<ColorListViewModel> model = new();
        //    foreach (var item in colors)
        //    {
        //        ColorListViewModel colorModel = new();
        //        colorModel.Id = item.Id;
        //        colorModel.ColorName = item.ColorName;
        //        colorModel.Description = item.Description;
        //        model.Add(colorModel);
        //    }
        //    return View(model);
        //}
        //public async Task<IActionResult> AddColor()
        //{
        //    return View(new ColorAddViewModel());
        //}
    }
}
