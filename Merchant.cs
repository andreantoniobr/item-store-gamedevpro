using System.Collections.Generic;

namespace FinalItemStore
{
    public class Merchant: Store
    {
        private List<Item> items = new List<Item>()
        {
            new Item("Espada de madeira", 7),
            new Item("Armadura de Couro", 5),
            new Item("Poção de Cura Pequena", 3),
            new Item("Poção de Estamina Pequena", 3),
            new Item("Queijo", 4),
            new Item("Pão", 1)
        };

        public Merchant()
        {
            inventory.AddItems(items);
        }
    }
}