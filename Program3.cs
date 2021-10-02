using System;

namespace Midterm_Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            string decide;
            string selectFlower;
            FlowerStore flowerStore = new FlowerStore();
            do
            {
                Console.WriteLine("Select number for buy flower :");
                foreach (string i in flowerStore.flowerList)
                {
                    Console.Write((flowerStore.flowerList.IndexOf(i) + 1) + " ");
                    Console.WriteLine(i);
                }
                selectFlower = Console.ReadLine();
                switch (selectFlower)
                {
                    case "1":
                        flowerStore.addToCart(flowerStore.flowerList[0]);
                        Console.WriteLine("Added " + flowerStore.flowerList[0]);
                        break;
                    case "2":
                        flowerStore.addToCart(flowerStore.flowerList[1]);
                        Console.WriteLine("Added " + flowerStore.flowerList[1]);
                        break;
                    default:
                        Console.WriteLine("No flower found");
                        break;
                }
                Console.WriteLine("Type 'exit' to stop the progress");
                Console.WriteLine("or press any key for continue");
                Console.WriteLine("");
                decide = Console.ReadLine();
                if (decide == "exit")
                {
                    flowerStore.showCart();
                }
            }
            while (decide != "exit");
        }
    }
    
}

