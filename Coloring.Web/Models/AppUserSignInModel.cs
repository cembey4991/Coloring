using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Coloring.Web.Models
{
    public class AppUserSignInModel
    {
        [Required(ErrorMessage = "UserName boş geçilemez")]
        [Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Parola alanı boş geçilemez")]
        [Display(Name = "Parola :")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Beni Hatirla")]
        public bool RememberMe { get; set; }
    }
}
