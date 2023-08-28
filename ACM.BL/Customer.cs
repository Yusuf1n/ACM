namespace ACM.BL
{
    public class Customer
    {
        public Customer() : this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }

        public int CustomerId { get; private set; }

        public int CustomerType { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName))
                {
                    return LastName;
                }

                if (string.IsNullOrWhiteSpace(LastName))
                {
                    return FirstName;
                }

                return $"{FirstName} {LastName}";
            }
        }

        public string EmailAddress { get; set; }

        public static int InstanceCount { get; set; }

        public bool Validate()
        {
            // Validates the customer data

            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}