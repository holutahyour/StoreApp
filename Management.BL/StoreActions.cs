using Management.Common;
using Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BL
{
    public class StoreActions
    {
        private readonly StoreData store;
        public StoreActions()
        {
            store = new StoreData();
            store.ReadStoresDataFromFile();
        }

        public Store AddStore(string name, string type, string userEmail)
        {
            Random random = new Random();
            Store newStore = new Store
            {
                Name = name,
                Type = type,
                StoreNumber = random.Next(10000, 1000000000).ToString(),
                UserEmail = userEmail
            };
            store.stores.Enqueue(newStore);
            return newStore;
        }
       
        public void SaveChanges()
        {
            store.WriteStoresDataToFile();
        }
        public Store DequeStore()
        {
            return store.stores.Dequeue();
        }
        public Queue<Store> DisplayStores()
        {
            return store.stores;
        }
    }
}
