using System;
using System.Collections.Generic;

namespace Store_App_Solid_Principle
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Username { get; set; }
        public string StoreNumber { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
       
    }

    public class ProductBusinessLogic
    {
        IProductDataAccess _productDataAccess;

        public ProductBusinessLogic()
        {
            _productDataAccess = DataAccessFactory.GetProductDataAccessObj();
        }

        public Product RegisterStore(Product store)
        {
            return _productDataAccess.RegisterProduct(store);
        }

        public Product DeleteProduct(string productId)
        {
            return _productDataAccess.DeleteProduct(productId);
        }

        public List<Product> GetAllProducts()
        {
            return _productDataAccess.GetAllProducts();
        }

        public List<Product> GetProductsByStoreNumber(string storeNumber)
        {
            return _productDataAccess.GetProductsByStoreNumber(storeNumber);
        }

    }

    public interface IProductDataAccess
    {
        Product RegisterProduct(Product product);
        Product DeleteProduct(string productId);
        List<Product> GetProductsByStoreNumber(string storeNumber);
        List<Product> GetAllProducts();

    }

    public class ProductDataAccess : IProductDataAccess
    {
        public ProductDataAccess()
        {

        }

        public Product RegisterProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product DeleteProduct(string storeNumber)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByStoreNumber(string username)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

    }
}
