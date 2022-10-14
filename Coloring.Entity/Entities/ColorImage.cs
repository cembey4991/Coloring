using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coloring.Entity.Entities
{
    public class ColorImage:BaseEntity
    {
        public string ImageAreaColor { get; set; }
        public int AppUserId { get; set; }
        public AppUser Appuser { get; set; }

    }
}
