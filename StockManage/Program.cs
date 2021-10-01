using System;

namespace StockManage
{
    class Program
    {
        static void Main(string[] args)
        {
            int stockReport = 0; int total = 0;
            StockFile stock = new StockFile();
            Stock data = stock.Read("D:/Stock.json");
            for (int i = 0; i < data.TypesOfStocks.Count; i++)
            {

                Console.WriteLine(data.TypesOfStocks[i].name);
                Console.WriteLine(data.TypesOfStocks[i].price);
                Console.WriteLine(data.TypesOfStocks[i].shares);
                total = data.TypesOfStocks[i].price * data.TypesOfStocks[i].shares;
                Console.WriteLine("total value of " + data.TypesOfStocks[i].name + " is " + total);
                stockReport += total;
                Console.WriteLine("------");
            }
            Console.WriteLine("Total stock report : " + stockReport);
        }
    }
}
