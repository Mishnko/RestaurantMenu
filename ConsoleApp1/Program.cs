using System;

namespace RestaurantMenu
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Our Menu Generator");

            Menu myMenu = new Menu()
            {
                RestaurantName = "The Nice Spot",
                LastUpdated = DateTime.Today
            };

            MenuItems myItem = new MenuItems("Toasted Ravioli", (decimal)14.99, "appetizer");
            MenuItems myItem1 = new MenuItems("Ice Cream", (decimal)4.99, "dessert");
            MenuItems myItem2 = new MenuItems("Nachos", (decimal)10.99, "appetizer");
            MenuItems myItem3 = new MenuItems("Hamburger", (decimal)11.99, "main course");
            myMenu.AddItem(myItem);
            myMenu.AddItem(myItem1);
            myMenu.AddItem(myItem2);
            myMenu.AddItem(myItem3);
            Console.WriteLine("Printing the full menu");
            myMenu.PrintMenu();
            Console.WriteLine("Printing an item that is on the menu");
            myItem3.PrintItem();
            Console.WriteLine("Deleting" + myItem3.Description + " from the Menu");
            myMenu.DeleteItem(myItem3.Description);
            Console.WriteLine("Printing the full menu after the delete");
            myMenu.PrintMenu();

        }




    }
}
