using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coloring.Entity.Entities
{
    public class AppUser: IdentityUser<int>
    {
        public string Name { get; set; }    
        public string Surname { get;set; }
        public ICollection<Color> Colors { get; set; }
    }
}
