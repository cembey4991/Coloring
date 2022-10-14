using Coloring.Entity.Entities;
using System.ComponentModel.DataAnnotations;

namespace Coloring.Web.Areas.Member.Models
{
    public class ColorAddViewModel
    {
       
        public int Id { get; set; }
        public string ColorName { get; set; }
        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
