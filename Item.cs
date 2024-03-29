namespace FinalItemStore
{
    public struct Item
    {      
        private string name;
        private int price;        

        public string Name
        {
            get => name;
            private set => name = value;            
        }
        
        public int Price
        {
            get => price;
            private set => price = value;            
        }

        public Item(string name, int price)
        {
            this.name = name;
            this.price = price;
        }        
    }
}