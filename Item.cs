
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace InventorySystem
{
   

    public class Item
    {
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
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
        }

        public void AddQuantity(int amount)
        {
            if (amount <= 0)
                return;

            quantity += amount;
        }

        public bool RemoveQuantity(int amount)
        {
            if (amount <= quantity && amount > 0)
            {
                quantity -= amount;
                return true;
            }

            return false;
        }
    }
}