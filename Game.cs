using System.Collections.Generic;

namespace FinalItemStore
{
    public class Game
    {
        public void Play()
        {
            Player player = new Player(5);  
            Merchant merchant = new Merchant();
            InventoryManager inventoryManager = new InventoryManager();

            Print.PrintIntro(player);
            MerchantConversation(merchant, ref player, inventoryManager);
            Print.PrintPlayerInventory(player);
        }

        private void MerchantConversation(Merchant merchant, ref Player player, InventoryManager InventoryManager)
        {
            while (InventoryManager.CanBuy(ref player, merchant))
            {
                Print.PrintStoreInventory(merchant.Inventory);
                int itemIndex = GetUserInputAndPrint();

                while (itemIndex < 0 || itemIndex >= merchant.Inventory.ItemsAmount)
                {
                    Print.PrintItemUnavailable();
                    itemIndex = GetUserInputAndPrint();
                }
                
                InventoryManager.TryBuyItem(merchant.Inventory.Items[itemIndex], ref player);              
            }
        }

        private int GetUserInputAndPrint()
        {
            Print.Write("Digite o número do item que você quer comprar -> ");
            return InputController.GetUserInput();
        }
    }
}