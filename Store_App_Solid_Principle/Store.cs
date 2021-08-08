using System;
using System.Collections.Generic;

namespace Store_App_Solid_Principle
{
    public class Store
    {
        public string StoreNumber { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
       

    }


    public class StoreBusinessLogic
    {
        IStoreDataAccess _storeDataAccess;

        public StoreBusinessLogic()
        {
            _storeDataAccess = DataAccessFactory.GetStoreDataAccessObj();
        }

        public Store RegisterStore(Store store)
        {
            return _storeDataAccess.RegisterStore(store);
        }

        public Store DeleteStore(string storeNumber)
        {
            return _storeDataAccess.DeleteStore(storeNumber);
        }

        public List<Store> GetAllStores()
        {
            return _storeDataAccess.GetAllStores();
        }

        public List<Store> GetStoresByUsername(string username)
        {
            return _storeDataAccess.GetStoresByUsername(username);
        }

    }




    public interface IStoreDataAccess
    {
        Store RegisterStore(Store store);
        Store DeleteStore(string storeNumber);
        List<Store> GetStoresByUsername(string username);
        List<Store> GetAllStores();

    }

    public class StoreDataAccess : IStoreDataAccess
    {
        public StoreDataAccess()
        {

        }

        public Store RegisterStore(Store store)
        {
            throw new NotImplementedException();
        }

        public Store DeleteStore(string storeNumber)
        {
            throw new NotImplementedException();
        }

        public List<Store> GetStoresByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public List<Store> GetAllStores()
        {
            throw new NotImplementedException();
        }

    }
}
