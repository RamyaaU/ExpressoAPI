using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressoAPI.Models
{
    public class Menu
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        //collection navigation property
        public ICollection<Submenu> Submenus { get; set; }
    }
}
