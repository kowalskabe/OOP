using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class Customer
    {
        public Customer()
        { 
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }


        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static int InstanceCount { get; set; }

        /*
        public Customer Retrieve(int customerId)
        {

            return 
        }

        public List<Customer> Retrieve()
        {
            return;
        }*/

        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
