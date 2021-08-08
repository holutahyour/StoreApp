using Management.Common;
using Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BL
{
    public class CustomerActions
    {
        private readonly CustomerData store;
        public CustomerActions()
        {
            store = new CustomerData();
            store.ReadCustomersDataFromFile();
        }

        public Customer AddCustomer(string lastName, string firstName, string email, string password)
        {
            if (!Validations.IsEmailValid(email))
                throw new FormatException("Email is not valid");
            Customer newCustomer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };
            store.customers.Enqueue(newCustomer);
            return newCustomer;
        }
        public Customer CustomerLogin(string email, string password)
        {
            store.ReadCustomersDataFromFile();

            if (!Validations.IsEmailValid(email))
                throw new FormatException("Email is not valid");
            Customer newCustomer = new Customer
            {
                Email = email,
                Password = password
            };
            newCustomer = GetUser(newCustomer);
            return newCustomer;
        }
        public void SaveChanges()
        {
            store.WriteCustomersDataToFile();
        }
        public Customer DequeCustomer()
        {
            return store.customers.Dequeue();
        }
        public Queue<Customer> DisplayCustomers()
        {
            return store.customers;
        }


        public Customer GetUser(Customer customer)
        {
            foreach (var storeCustomer in store.customers)
            {
                if (storeCustomer.Email == customer.Email && storeCustomer.Email == customer.Email)
                {
                    SaveChanges();
                    return storeCustomer;
                }
            }

            throw new FormatException("Email/Password is not valid");
        }
    }
}
