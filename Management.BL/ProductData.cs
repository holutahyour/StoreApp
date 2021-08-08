using Management.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BL
{
    public class ProductData
    {
        public Queue<Product> products = new Queue<Product>();
        public void WriteProductsDataToFile()
        {
            string filePath = @"../RegisterationDetails.txt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using FileStream fs = File.Create(filePath);
            fs.Dispose();
            var openedFile = File.AppendText(filePath);
            foreach (var product in products)
            {
                openedFile.WriteLine($"{product.Name},{product.Type}");
            }
            openedFile.Dispose();
        }

        public void ReadProductsDataFromFile()
        {
            string filePath = @"../RegisterationDetails.txt";
            if (!File.Exists(filePath))
            {
                using FileStream fs = File.Create(filePath);

            }
            var openedFile = File.ReadAllLines(filePath);

            foreach (var productDetail in openedFile)
            {
                var data = productDetail.Split(',');
                Product product = new Product
                {
                    Name = data[0],
                    Type = data[1],
                };

                products.Enqueue(product);
            }
            return;
        }
    }
}
