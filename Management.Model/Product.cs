using Management.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Model
{
    public class Product
    {

        public string Name
        {
            get;
            set;
        }


        public string Type
        {
            get;
            set;
        }

        public string UserEmail { get; set; }
        public string StoreNumber { get; set; }


    }
}
