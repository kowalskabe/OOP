using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            //tmp
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine = "23 marca 13/3";
                address.PostalCode = "81-820";
                address.City = "Sopot";
                address.Country = "Polska";
            }

            return address;
        }

        public IEnumerable<Address> RetriveByCustomerId(int custumerId)
        {
            //TMP
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine = "23 marca 13/3",
                PostalCode = "81-820",
                City = "Sopot",
                Country = "Polska"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine = "Leśna 1",
                PostalCode = "81-845",
                City = "Sopot",
                Country = "Polska"
            };
            addressList.Add(address);

            return addressList;
        }


        public bool Save()
        {
            return true;
        }
    }
}
