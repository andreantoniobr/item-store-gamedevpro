using System.Collections.Generic;

namespace FinalItemStore
{
    public class Inventory
    {
        private List<Item> items;

        public List<Item> Items => items;
        public int ItemsAmount => items.Count;

        public Inventory()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void AddItems(List<Item> itemsList)
        {            
            for(int i = 0; i < itemsList.Count; i++)
            {
                Item item = itemsList[i];
                AddItem(item);
            }
        }
    }
}