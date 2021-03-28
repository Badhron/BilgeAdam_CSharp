using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berkin.Models
{
    public static class Repository
    {
        private static List<Menu> menus = new List<Menu>();

        public static List<Menu> Menus
        {
            get
            {
                return menus;
            }
        }

        public static void AddMenu(Menu menu)
        {
            menus.Add(menu);
        }


    }
}
