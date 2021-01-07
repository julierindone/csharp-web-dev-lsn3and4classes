using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public string RestaurantName;
        public string Name;
        public List<MenuItem> ItemList;
        public int MenuId;
        public DateTime LastUpdate;


        public void AddItem(MenuItem item)
        {
            this.ItemList.Add(item);
        }

        public void RemoveItem(MenuItem item)
        {
            this.ItemList.Remove(item);
        }
    }
}
