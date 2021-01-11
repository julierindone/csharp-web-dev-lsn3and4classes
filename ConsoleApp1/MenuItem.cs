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

        public MenuItem()
        {
        }

        public MenuItem(string itemName, int id, double price, string category, bool newOld, DateTime updated)
        {
            this.ItemName = itemName;
            this.Id = id;
            this.Price = price;
            this.Category = category;
            this.NewOld = newOld;
            this.Updated = updated;
        }

        public MenuItem(string itemName, int id, double price, string category) 
        {
            this.ItemName = itemName;
            this.Id = id;
            this.Price = price;
            this.Category = category;

            this.NewOld = true;  //it's always true if we're just adding an item
            this.Updated = DateTime.Now;
        }
    }
}
