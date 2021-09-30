using System;

namespace _2InventoryMgmt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Quantity:");
            int quantity = int.Parse(Console.ReadLine());
            JsonFile jfile = new JsonFile();
            Rice ricedata = jfile.Read("D:/Rice.json");

            for (int i = 0; i < ricedata.TypesOfPulses.Count; i++)
            {
                Console.WriteLine(ricedata.TypesOfPulses[i].name);
                Console.WriteLine(ricedata.TypesOfPulses[i].Price);
                Console.WriteLine(ricedata.TypesOfPulses[i].weight);
                int price = ricedata.TypesOfPulses[i].Price;
                int total = price * quantity;
                Console.WriteLine("total Price:"+total);

                Console.WriteLine("------");
            }

            for (int i = 0; i < ricedata.TypesOfRice.Count; i++)
            {
                Console.WriteLine(ricedata.TypesOfRice[i].name);
                Console.WriteLine(ricedata.TypesOfRice[i].Price);
                Console.WriteLine(ricedata.TypesOfRice[i].weight);
                int price = ricedata.TypesOfRice[i].Price;
                int total = price * quantity;
                Console.WriteLine("total Price:" + total);
                Console.WriteLine("------");
            }

        }
    }
}
