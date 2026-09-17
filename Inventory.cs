using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Inventory
    {
        private List<Item> items = new List<Item>();
        public const int MaxInventorySlots = 20;
        public void AddItem(Item item, int number)
        {
            foreach(Item i in items)
            {
                if(i.Name == item.Name)
                {
                    i.AddQuantity(number);
                    return;
                }
               
            }
            item.AddQuantity(number);
            items.Add(item);
        }

        public void DisplayItem()
        {
            foreach (Item itm in items)
            {
                Console.WriteLine(itm.Name);
                Console.WriteLine(itm.Quantity);
            }
        }

        public bool RemoveItem(Item item, int num)
        {
            Item? itemtoremove = null;
            Item? itemF = FindItem(item.Name);
            if(itemF!= null)
            {
                if(itemF.RemoveQuantity(num))
                { 
                    if (itemF.Quantity <= 0)
                    {
                        itemtoremove = itemF;
                    }
                       
                }
                else
                {
                    Console.WriteLine("Not enough quantity to remove");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Item not found ");
                return false;
            }

            if (itemtoremove != null)
            {
                items.Remove(itemtoremove);
                
            }
            return true;
        }

        public bool HasItem(Item item)
        {
            Item itemF = FindItem(item.Name);
            if(itemF != null)
            {
                Console.WriteLine("Player has " + item.Name);
                return true;
            }
            Console.WriteLine("Player don' t have " + item.Name);
            return false;
        }

        public int GetItemQuantity(Item item)
        {
            Item? itemF = FindItem(item.Name);

            if (itemF != null)
            {
                return itemF.Quantity;
            }
                
            
            return 0;
        }

        private Item? FindItem(String ItemName)
        {
            foreach(Item a in items)
            {
                if (a.Name == ItemName)
                    return a;
            }
            return null;
        }

        public static int inventoryCount = 0;

       
    }
}
