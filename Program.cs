using InventorySystem;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Item {

        private string name = "";
        private int quantity;
        public static int TotalItemsCreated = 0;

        public Item()
        {
            TotalItemsCreated++;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Quantity
        {
            get { return quantity; }
           
        }

    public void AddQuantity(int amount)
    {
        if (amount > 0)
            quantity += amount;
        else
            return;
    }

    public bool RemoveQuantity(int amount)
    {
        if(amount <= quantity && amount > 0)
        {
            quantity -= amount;
            return true;
        }
        return false;

    }
}
    class Program
    {
        static void Main()
        {
            Item potion = new Item();

            potion.Name = "Health Potion";
            potion.AddQuantity(2);

            Item weapon = new Item();

            weapon.Name = "Sword";
            weapon.AddQuantity(3);
            Item Gun = new Item();

            Gun.Name = "gun";
            Gun.AddQuantity(4);

            Inventory inventory = new Inventory();
            inventory.AddItem(potion, 2);
            inventory.AddItem(weapon, 3);
            inventory.AddItem(potion, 1);
            inventory.DisplayItem();
           bool success =  inventory.RemoveItem(potion, 7);
           bool success1 = inventory.RemoveItem(Gun, 7);
            bool success3 = inventory.HasItem(potion);
            inventory.HasItem(Gun);
        inventory.DisplayItem();
        Console.WriteLine("Potion removed" + success);
        Console.WriteLine("Gun removed"+ success1);
        Console.WriteLine("found potion or not"+ success3);

        Console.WriteLine(Inventory.MaxInventorySlots);

        Console.Write("Enter quantity: ");
        string input = Console.ReadLine();

        try
        {
            int quantity = int.Parse(input);
            Console.WriteLine("Quantity: " + quantity);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
        Console.ReadLine();
        }
    }
    


