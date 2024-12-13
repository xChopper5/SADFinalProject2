using SADFinalProject.Components.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SADFinalProject.Components.Managers
{
    public class DBManager
    {
        private static string CustomerFile = @"C:\Users\maxim\source\repos\SADFinalProject\Resources\Raw\Customers.csv";
        private CustomerManager customerManager;

        public static DBManager INSTANCE { get; private set; } = new DBManager();
        public List<Customer> CustomerList { get; private set; } = new List<Customer>();

        private DBManager()
        {
            customerManager = CustomerManager.INSTANCE;
        }

        public async Task InitializeAsync()
        {
            await LoadCustomers();
        }

        public async Task RefreshCustomerAsync()
        {
            await LoadCustomers();
        }

        public async Task LoadCustomers()
        {
            if (!File.Exists(CustomerFile))
                throw new FileNotFoundException($"The file '{CustomerFile}' was not found.");

            using var stream = new FileStream(CustomerFile, FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);

                
            string? line = reader.ReadLine();
            if (line == null) throw new Exception("File is empty.");

            CustomerList.Clear(); 
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');

                CustomerList.Add(new Customer(
                    int.Parse(values[0]),  
                    values[1],             
                    values[2],             
                    values[3],             
                    values[4],             
                    values[5]              
                ));
            }
            

        }

        
    }
}


