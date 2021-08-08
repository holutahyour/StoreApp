using Management.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                CustomerActions actions = new CustomerActions();
                Dashboard.DisplayDashBoard(actions);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to start application");
            }
        }
    }
}
