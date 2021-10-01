using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StockManage
{
    class StockFile
    {
        public Stock Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Stock>(json);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return null;
                }

            }
        }
    }
}
