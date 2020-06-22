using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class Address
    {
        public Address()
        { 
        
        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }


        public int AddressId { get; private set; } 
        public int AddressType { get; set; } 
        public string City { get; set; }
        public string PostalCode { get; set; } 
        public string StreetLine { get; set; }
        public string Country { get; set; }


        public bool Validate()
        {
            var isValid = true;
            if (PostalCode == null) isValid = false;

            return isValid;
        }
    }
}
