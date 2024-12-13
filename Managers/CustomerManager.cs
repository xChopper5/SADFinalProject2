using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SADFinalProject.Components.Models;


namespace SADFinalProject.Components.Managers
{
    public class CustomerManager
    {
        public static CustomerManager INSTANCE = new CustomerManager();
        public List<Customer> CustomerList = new List<Customer>();

        

        public CustomerManager() { }
        public void AddCustomer()
        { 
        }

        public void ModifyCustomer()
        { 
        }

        public void RemoveCustomer() 
        { 
        }

        public void ValidateCustomer()
        { 
        }

    }
}
