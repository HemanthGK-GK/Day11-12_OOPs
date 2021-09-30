using System;
using System.Collections.Generic;
using System.Text;

namespace _2InventoryMgmt
{
   
        public class Rice
        {
            public List<TypesOfRice> TypesOfRice;
            public List<TypesOfPulses> TypesOfPulses;
        }

        public class TypesOfRice
        {
            public string name;
            public string weight;
            public int Price;
        }

        public class TypesOfPulses
        {
            public string name;
            public string weight;
            public int Price;
        }
    
}
