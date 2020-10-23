using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        //Retrieves one customer by id.
        //Collaboration relationship
        public Customer Retrieve(int customerId)
        {
            //Create the instance of the Customer class
            //Pass in the requested Id
            Customer customer = new Customer(customerId);

            //Code that retrieves the defined customer

            //Temp hard-coded values to return a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "hsmitty@gmail.com";
                customer.FirstName = "Hailey";
                customer.LastName = "Smith";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        //Saves the current customer.
        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.isValid)
                {
                    if (customer.IsNew)
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