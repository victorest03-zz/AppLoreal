using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLoreal.Pages;

namespace AppLoreal.Models
{

    public class HomePageMenuItem
    {
        public HomePageMenuItem()
        {
            TargetType = typeof(HomePageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string IconUrl { get; set; }

        public Type TargetType { get; set; }
    }
}