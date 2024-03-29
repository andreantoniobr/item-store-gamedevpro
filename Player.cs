using System.Collections.Generic;

namespace FinalItemStore
{
    public struct Player
    {
        private int coinsAmount;
        private Inventory inventory;
        
        public int CoinsAmount => coinsAmount;        
        public Inventory Inventory => inventory;

        public Player(int coinsAmount)
        {
            this.coinsAmount = coinsAmount;            
            inventory = new Inventory();
        }

        public bool TryCoinDegrease(Item item)
        {
            if (coinsAmount >= item.Price)
            {
                coinsAmount -= item.Price;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}