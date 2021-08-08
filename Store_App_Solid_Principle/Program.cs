//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Store_App_Solid_Principle
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Customer customer = new Customer();
//            var _customerBusinessLogic = new CustomerBusinessLogic();
//            string selection;

//            Console.WriteLine("===========Welcome To Store App=============");
//            Console.WriteLine("Select 1 for existing customer \nSelect 2 for new customer");
//            selection = Console.ReadLine();

//            if (selection == "1")
//            {
//                Console.WriteLine("Enter your Username");
//                customer.Username = Console.ReadLine();
//                Console.WriteLine("Enter your Password");
//                customer.Username = Console.ReadLine();

//                customer = _customerBusinessLogic.Login(customer);

//                if (customer.UserId != null)
//                {

//                }


//            }

//            if (selection == "1")
//            {
                
//            }


//        }
//    }    
   
//}
