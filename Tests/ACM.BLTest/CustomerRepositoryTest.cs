using ACM.BL;

namespace ACM.BLTest;

[TestClass]
public class CustomerRepositoryTest
{

    [TestMethod]
    public void RetrieveValid()
    {
        // Arrange
        var customerRepository = new CustomerRepository();
        var expected = new Customer(1)
        {
            EmailAddress = "yusufnaheem1@gmail.com",
            FirstName = "Yusuf",
            LastName = "Naheem"
        };

        // Act
        var actual = customerRepository.Retrieve(1);

        // Assert
        Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        Assert.AreEqual(expected.FirstName, actual.FirstName);
        Assert.AreEqual(expected.LastName, actual.LastName);
    }

}