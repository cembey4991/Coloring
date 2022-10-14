using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Coloring.Web.Models
{
    public class AppUserAddViewModel
    {
        [Required(ErrorMessage="Adı boş geçilemez")]
        [Display(Name="İsim :")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyadı boş geçilemez")]
        [Display(Name = "Soyisim :")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "UserName boş geçilemez")]
        [Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; }
        [Display(Name = "Email :")]
        [EmailAddress(ErrorMessage ="Geçersiz Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Parola alanı boş geçilemez")]
        [Display(Name = "Parola :")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage = "Parola alanı boş geçilemez")]
        [Display(Name = "Tekrar Parola :")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
