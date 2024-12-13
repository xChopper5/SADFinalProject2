using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SADFinalProject.Managers;


namespace SADFinalProject.Components.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Notes { get; set; }

        public Customer(int id, string lastName, string firstName, string phone, string email, string notes)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Phone = phone;
            Email = email;
            Notes = notes;
        }

    }
  

}
