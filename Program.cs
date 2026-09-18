using System;

namespace InventorySystem
{
    class Program
    {
        static void Main()
        {
            Item potion = new Item();
            potion.Name = "Health Potion";

            Inventory inventory = new Inventory();

            inventory.AddItem(potion, 2);

            Console.WriteLine("=== Inventory ===");
            inventory.DisplayItem();

            Console.WriteLine("\n=== Item Check ===");
            Console.WriteLine("Has Potion: " + inventory.HasItem(potion));
            Console.WriteLine("Potion Quantity: " + inventory.GetItemQuantity(potion));

            Console.WriteLine("\n=== Remove Item ===");
            bool removed = inventory.RemoveItem(potion, 1);
            Console.WriteLine("Removed: " + removed);

            Console.WriteLine("\n=== Final Inventory ===");
            inventory.DisplayItem();

            Console.ReadLine();
        }
    }
}