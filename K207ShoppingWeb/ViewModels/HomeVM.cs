using K207ShoppingWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K207ShoppingWeb.ViewModels
{
    public class HomeVM
    {
        public List<Category>Categories { get; set; }
        public List<Product> Products{ get; set; }
        public List<Slider> Sliders { get; set; }
    }
}
