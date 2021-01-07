using System;
using System.Collections.Generic;


namespace RestaurantMenu
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu jetsPizza = new Menu();

            jetsPizza.RestaurantName = "Jets Pizza";
            jetsPizza.Name = "Jets Hampton";
            jetsPizza.ItemList = new List<MenuItem>();
            jetsPizza.MenuId = 123;
            jetsPizza.LastUpdate = DateTime; //unsure how to use.


            MenuItem bbqpizza = new MenuItem();
            bbqpizza.ItemName = "BBQ Pizza";
            bbqpizza.Id = 432;
            bbqpizza.Price = 15.99;
            bbqpizza.Category = "Specialty Pizzas";
            bbqpizza.NewOld = true;
            bbqpizza.Updated = DateTime; //unsure how to use.



            
        }
    }
}
