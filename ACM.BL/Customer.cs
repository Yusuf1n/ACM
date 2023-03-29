namespace ACM.BL
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

        public Customer Retrieve(int customerId)
        {
            // Retrieve a single customer

            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            // Retrieve all customers

            return new List<Customer>();
        }

        public bool Save()
        {
            // Saves the current customer

            return true;
        }

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