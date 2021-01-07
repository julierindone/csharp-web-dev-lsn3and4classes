using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public string ItemName { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public bool NewOld { get; set; }
        public DateTime Updated { get; set; }
    }
}
