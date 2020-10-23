using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        //Collaboration relationship
        public Address Retrieve(int addressId)
        {
            //Create the instance of the Address class
            //Pass in the requested Id
            Address address = new Address(addressId);

            //Code that retrieves the defined address

            //Temp hard-coded values to return a populated address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "10012 NE 34th ST";
                address.StreetLine2 = "APT 292";
                address.City = "Ocean Shores";
                address.State = "Washington";
                address.Country = "United States";
                address.PostalCode = "98002";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Code that retrieves the defined addresses for the customer

            // Temporary hard-coded values to return a set of addresses for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }

        //Saves the current customer.
        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges)
            {
                if (address.isValid)
                {
                    if (address.IsNew)
                    {
                        // Call an Insert Stroed Procedure
                    }
                    else
                    {
                        //Call an update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}