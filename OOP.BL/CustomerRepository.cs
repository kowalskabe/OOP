﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "kowalskab389@gmail.com";
                customer.FirstName = "Barbara";
                customer.LastName = "Kowalska";
            }
            return customer;
        }

        public bool Save()
        {
            return true;
        }
    }
}
