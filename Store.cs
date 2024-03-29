namespace FinalItemStore
{
    public class Store
    {
        protected Inventory inventory;
        public Inventory Inventory => inventory;        

        public Store()
        {
            inventory = new Inventory();
        }
    }
}