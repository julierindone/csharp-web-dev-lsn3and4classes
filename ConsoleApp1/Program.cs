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
            jetsPizza.LastUpdate = DateTime.Now;


            MenuItem bbqpizza = new MenuItem(); //default constructor
            bbqpizza.ItemName = "BBQ Pizza";
            bbqpizza.Id = 432;
            bbqpizza.Price = 15.99;
            bbqpizza.Category = "Specialty Pizzas";
            bbqpizza.NewOld = true;
            bbqpizza.Updated = DateTime.Now;

            MenuItem vegetarian = new MenuItem("Vegetarian Pizza", 433, 14.99, "Specialty Pizzas");   //constructor #2

            MenuItem meatLovers = new MenuItem("Meat Lovers", 434, 16.99, "Specialty Pizzas"); //constructor #2

            Console.WriteLine("Jets Hampton Menu");
            Console.WriteLine($"({vegetarian.ItemName}: {vegetarian.Price}");
            Console.WriteLine($"{meatLovers.ItemName}: {meatLovers.Price}");


            Console.WriteLine($"{jetsPizza.RestaurantName} has a new item in its {bbqpizza.Category} category: a delicious {bbqpizza.ItemName}.");
            Console.WriteLine($"Check out our whole list of items here:");
            foreach (MenuItem line in jetsPizza.ItemList)                
            {
                Console.WriteLine(jetsPizza.ItemList);         //didn't work, ran out of time
            }

            /*got lost here... didn't finish 
              Menu columbus = new Menu(jetsPizza "Columbus", "Dinner", )
                columbus.AddItem(bbqpizza);
                columbus.AddItem(vegetarian);
                columbus.AddItem(meatLovers);

                Console.WriteLine(
            */



            



            
        }
    }
}
