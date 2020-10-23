namespace ACM.BL
{
    public class Address : EntityBase
    {
        public Address()
        {

        }
        public Address(int addressId)
        {
            AddressId = addressId;
        }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }
        public int AddressId { get; private set; }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(PostalCode)) isValid = false;

            return isValid;
        }
    }
}