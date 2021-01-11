using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public string RestaurantName { get; set; }
        public string Name { get; set; }
        public List<MenuItem> ItemList { get; set; }
        public int MenuId { get; set; }
        public DateTime LastUpdate { get; set; }

        public Menu()    // blank constructor
        {
        }

        public Menu(string restaurantName, string name, List<MenuItem> itemList, int menuId, DateTime lastUpdate)              
        {
            this.RestaurantName = restaurantName;
            this.Name = name;
            this.ItemList = itemList;
            this.MenuId = menuId;                
            this.LastUpdate = lastUpdate;
        }

        ///////VERY confused with the below "overloaded constructor" - look up.////////////////
        //Constructor(...args) : this(...args, extraValues) - calling a constructor, and depending on the arguments called, it'll call in the above constructor.
        //public Menu(string _restaurantName, string _itemList, int _menuId) : this (_restaurantName, _itemList, _menuId, new List<MenuItem>(), DateTime.Now)   //what's my mistake?! is it because they're out of order?
        //{
        //}

        public void AddItem(MenuItem item)
        {
            if (this.ItemList == null)
            {
                this.ItemList = new List<MenuItem>();
            }
            this.ItemList.Add(item);
            this.LastUpdate = DateTime.Now;   //this shows that the last update got updated.
        }

        public bool RemoveItem(MenuItem item)     //do as a boolean because ?????
        {
            if (this.ItemList == null)
            {
                this.ItemList = new List<MenuItem>();
                return false;
            }

            bool removed = this.ItemList.Remove(item);      
            if (removed)
            {
                this.LastUpdate = DateTime.Now;
            }
            return removed;            
        }
    }
}
