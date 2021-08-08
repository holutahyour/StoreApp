using Management.Common;
using Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BL
{
    public class ProductActions
    {
        private readonly ProductData product;
        public ProductActions()
        {
            product = new ProductData();
            product.ReadProductsDataFromFile();
        }

        public Product AddProduct(string name, string type, string userEmail, string storeNumber)
        {           
            Product newProduct = new Product
            {
                Name = name,
                Type = type,
                UserEmail = userEmail,
                StoreNumber = storeNumber,
            };
            product.products.Enqueue(newProduct);
            return newProduct;
        }
       
        public void SaveChanges()
        {
            product.WriteProductsDataToFile();
        }
        public Product DequeProduct()
        {
            return product.products.Dequeue();
        }
        public Queue<Product> DisplayProducts()
        {
            return product.products;
        }
    }
}
