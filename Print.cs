using System;

namespace FinalItemStore
{
    public class Print
    {
        public static void Write(string message)
        {
            Console.Write(message);
        }

        public static void Wait()
        {
            Console.ReadKey();
        }

        public static void PrintLine(string message = "")
        {
            Console.WriteLine(message);
        }

        public static void PrintLineAndWait(string message = "")
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        public static void PrintSpace()
        {
            PrintLine();
            PrintLine("-------------------------------");
            PrintLine();
        }

        public static void PrintIntro(Player player)
        {
            PrintLineAndWait("Bem vindo a nossa loja!");
            PrintLineAndWait($"Eu vejo que você tem muitos coins com você... Você tem {player.CoinsAmount} coins.");
            PrintLineAndWait("Hummm... você quer dar uma olhada no nosso estoque?");
        }

        public static void PrintPlayerInventory(Player player)
        {            
            PrintSpace();
            PrintLine("Que pena que acabou seu dinheiro... mas ta ai seu Inventário: ");
            PrintLine();
            PrintItems(player.Inventory);
            Wait();
        }

        public static void PrintStoreInventory(Inventory inventory)
        {            
            PrintSpace();
            PrintLine("Essas são as nossas opções:");
            PrintItems(inventory);
            Print.PrintLine();
        }

        public static void PrintItems(Inventory inventory)
        {
            for(int i = 0; i < inventory.Items.Count; i++)
            {
                Item item = inventory.Items[i];
                Print.PrintLine($"({i + 1}) - {item.Name} - {item.Price} Coin");
            }
        }

        public static void PrintItemUnavailable(){
            Print.PrintLine();
            Print.PrintLine("Não tenho esse produto... Não olhou o estoque?");
        }

        public static void PrintBuyedItem(Item item, int coinsAmount)
        {
            Print.PrintSpace();
            Print.PrintLine($"Você comprou: ({item.Name}) por: ({item.Price}) coins.");
            Print.PrintLine($"Você tem ({coinsAmount}) coins.");
        }

        public static void PrintNoCoins()
        {
            PrintSpace();
            PrintLine("Você nao tem coins suficientes para comprar esse produto... :("); 
        }        
    }
}