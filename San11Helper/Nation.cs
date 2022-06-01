using System.Collections.Generic;
using System.Drawing;


namespace San11Helper
{
    class Nation
    {
        public string Name { get; set; }
        public Image Icon { get; set; }

        public List<City> Cities { get; set; } = new List<City>();
        public List<General> Generals { get; set; } = new List<General>();


        public Nation (Image icon)
        {
            Icon = icon;
        }
    }
}
