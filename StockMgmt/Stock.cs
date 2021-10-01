using System;
using System.Collections.Generic;
using System.Text;

namespace StockMgmt
{
    class Stock
    {
        public List<TypesOfStocks> TypesOfStocks;
    }

    public class TypesOfStocks
    {
        public string name;
        public int shares;
        public int price;
    }
}
