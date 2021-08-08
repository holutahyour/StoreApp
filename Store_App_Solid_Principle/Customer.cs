using System;
using System.Collections.Generic;

namespace Store_App_Solid_Principle
{
    public class Customer
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }


    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _customerDataAccess;

        public CustomerBusinessLogic()
        {
            _customerDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
        }

        public Customer GetCustomerUsername(Customer customer)
        {
            return _customerDataAccess.GetCustomerByUsername(customer);
        }

        public List<Customer> GetAllCustomer()
        {
            return _customerDataAccess.GetAllCustomer();
        }

        public Customer Login(Customer customer)
        {
            return _customerDataAccess.Login(customer);
        }

        public string Logout()
        {
            return _customerDataAccess.Logout();
        }
    }


    public interface ICustomerDataAccess
    {
        Customer RegisterCustomer(Customer customer);
        Customer GetCustomerByUsername(Customer customer);
        List<Customer> GetAllCustomer();
        Customer Login(Customer customer);
        string Logout();
    }

    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {

        }

        public Customer RegisterCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerByUsername(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        public Customer Login(Customer customer)
        {
            throw new NotImplementedException();
        }

        public string Logout()
        {
            throw new NotImplementedException();
        }

    }
}
