using Newtonsoft.Json;
using System;

namespace _1JsonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonFiles obj = new JsonFiles();
            var data = obj.Read("D:/rice.json");
            Console.WriteLine(JsonConvert.SerializeObject(data));
        }
    }
}
