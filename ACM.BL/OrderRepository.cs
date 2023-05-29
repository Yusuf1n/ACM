namespace ACM.BL;

public class OrderRepository
{
    /// <summary>
    /// Retrieve one customer.
    /// </summary>
    /// <param name="customerId"></param>
    /// <returns></returns>
    public Customer Retrieve(int customerId)
    {
        // Create the instance of the Customer class
        // Pass in the required Id
        Customer customer = new Customer(customerId);

        // Code that retrieves the defined customer

        // Temporary hard-coded values to return a populated customer
        if (customerId == 1)
        {
            customer.EmailAddress = "yusufnaheem1@gmail.com";
            customer.FirstName = "Yusuf";
            customer.LastName = "Naheem";
        }

        return customer;
    }

    /// <summary>
    /// Saves the current customer. 
    /// </summary>
    /// <param name="customer"></param>
    /// <returns></returns>
    public bool Save(Customer customer)
    {
        // Code that saves the passed in customer

        return true;
    }
}