namespace FinalItemStore
{
    public class InventoryManager
    {
        public bool CanBuy(ref Player player, Store store)
        {
            foreach(Item item in store.Inventory.Items)
            {
                if(item.Price <= player.CoinsAmount)
                {
                    return true;
                }
            }

            return false;
        }

        public void TryBuyItem(Item item, ref Player player)
        {
            if (BuyItem(item, ref player))
            {                    
                Print.PrintBuyedItem(item, player.CoinsAmount);  
            }
            else
            {
                Print.PrintNoCoins();
            }
        }

        private bool BuyItem(Item item, ref Player player)
        {
            if (player.TryCoinDegrease(item))
            {                               
                player.Inventory.AddItem(item);
                return true;      
            }
            else
            {            
                return false;
            }
        }      
    }
}