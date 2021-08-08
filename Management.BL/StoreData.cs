using Management.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BL
{
    public class StoreData
    {
        public Queue<Store> stores = new Queue<Store>();
        public void WriteStoresDataToFile()
        {
            string filePath = @"../RegisterationDetails.txt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using FileStream fs = File.Create(filePath);
            fs.Dispose();
            var openedFile = File.AppendText(filePath);
            foreach (var store in stores)
            {
                openedFile.WriteLine($"{store.Name},{store.Type}");
            }
            openedFile.Dispose();
        }

        public void ReadStoresDataFromFile()
        {
            string filePath = @"../RegisterationDetails.txt";
            if (!File.Exists(filePath))
            {
                using FileStream fs = File.Create(filePath);

            }
            var openedFile = File.ReadAllLines(filePath);

            foreach (var storeDetail in openedFile)
            {
                var data = storeDetail.Split(',');
                Store store = new Store
                {
                    Name = data[0],
                    Type = data[1],
                };

                stores.Enqueue(store);
            }
            return;
        }
    }
}
