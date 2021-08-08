using Management.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Model
{
    public class Store
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { Name = Validations.CleanName(value); }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { Type = Validations.CleanName(value); }
        }

        public string StoreNumber { get; set; }
        public string UserEmail { get; set; }

    }
}
