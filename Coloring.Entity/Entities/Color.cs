using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coloring.Entity.Entities
{
    public class Color : BaseEntity
    {
        public string ColorName {get;set;}
        public int? AppUserId { get;set;}
        public AppUser AppUser {get;set;}
    }
}
