using Management.BL;
using Management.Common;
using Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.UI
{
    public class Dashboard
    {
        private static string firstName;
        private static string lastName;
        private static string emailAddress;
        private static string password;
        private static string storeName;
        private static string storeType;

        public static void DisplayDashBoard(CustomerActions actions,StoreActions storeActions)
        {
            bool shouldRun = true;
            Customer customer = new Customer();
            Store store = new Store();

            while (shouldRun)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Welcome to my My Store App.");

                Console.WriteLine("Enter: ");
                Console.WriteLine("1 for existing customer");
                Console.WriteLine("2 for new customer");
                Console.WriteLine("3 for display all users");
                if (customer.FirstName != null)
                {
                    Console.WriteLine("4 for display all store");
                    Console.WriteLine("5 for add new store");

                }
                //Console.WriteLine("4 to Remove Customer");
                //Console.WriteLine("5 to Display all customers accordingly");
                Console.WriteLine("0 to exit");

                var consoleInput = Validations.IsValidInput(Console.ReadLine());
                if (consoleInput == -1)
                {
                    Console.WriteLine("Please enter a valid input");
                    Console.Clear();
                }
                else
                {
                    switch (consoleInput)
                    {
                        case 1:
                            try
                            {
                                Console.WriteLine("Enter Email");
                                emailAddress = Console.ReadLine();
                                Console.WriteLine("Enter Password");
                                password = Console.ReadLine();                                
                                customer = actions.CustomerLogin(emailAddress, password);
                                Console.WriteLine($"Customer {customer.FullName} Logged In successfully");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine();
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (FormatException ex) //Catches all errors relating to argument formats operations
                            {

                                Console.WriteLine(ex.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case 2:
                            try
                            {
                                Console.WriteLine("Enter first name");
                                firstName = Console.ReadLine();
                                Console.WriteLine("Enter last name");
                                lastName = Console.ReadLine();
                                Console.WriteLine("Enter email address");
                                emailAddress = Console.ReadLine();
                                Console.WriteLine("Enter Password");
                                password = Console.ReadLine();
                                customer = actions.AddCustomer(firstName, lastName, emailAddress, password);
                                Console.WriteLine($"Customer {customer.FullName} added successfully");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine();
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (FormatException ex) //Catches all errors relating to argument formats operations
                            {

                                Console.WriteLine(ex.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                                               
                        case 3:
                            try
                            {
                                var customers = actions.DisplayCustomers();
                                Console.ForegroundColor = ConsoleColor.Green;
                                UIHelpers.DisplayHistoryTable(customers);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                         case 4:
                            try
                            {
                                var stores = storeActions.DisplayStores();
                                Console.ForegroundColor = ConsoleColor.Green;
                                UIHelpers.DisplayStoreTable(stores);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;

                        case 5:
                            try
                            {
                                Console.WriteLine("Enter Store name");
                                storeName = Console.ReadLine();
                                Console.WriteLine("Enter Store Type");
                                storeType = Console.ReadLine();
                                
                                store = storeActions.AddStore(storeName, storeType, customer.Email);
                                Console.WriteLine($"Store {store.Name} added successfully");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine();
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;

                        case 6:
                            try
                            {
                                var dequeuedCustomer = actions.DequeCustomer();
                                Console.WriteLine($"Customer {dequeuedCustomer.FullName} has been removed");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Top yocustomer dequeued");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;

                        case 7:
                            try
                            {
                                actions.SaveChanges();
                                Console.WriteLine("Changes saved");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine();
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case 0:
                            try
                            {
                                actions.SaveChanges();
                                Console.WriteLine("Bye.");
                                shouldRun = false;
                            }
                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
