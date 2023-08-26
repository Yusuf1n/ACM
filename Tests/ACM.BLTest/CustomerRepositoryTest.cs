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

    [TestMethod]
    public void RetrieveExistingWithAddress()
    {
        // Arrange
        var customerRepository = new CustomerRepository();

        var expected = new Customer(1)
        {
            EmailAddress = "yusufnaheem1@gmail.com",
            FirstName = "Yusuf",
            LastName = "Naheem",
            AddressList = new List<Address>
            {
                new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "2 Seaton Close",
                    StreetLine2 = "Lightwood",
                    City = "Stoke-on-Trent",
                    County = "Staffordshire",
                    Country = "United Kingdom",
                    PostCode = "ST3 7UP"
    },  
                new Address()
                {
                    AddressType = 2,
                    StreetLine1 = "Cambridge Road",
                    StreetLine2 = "",
                    City = "North Carlton",
                    County = "Lincolnshire",
                    Country = "United Kingdom",
                    PostCode = "LN1 9BG"
                }
            }
        };

        // Act 
        var actual = customerRepository.Retrieve(1);

        // Assert
        Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        Assert.AreEqual(expected.FirstName, actual.FirstName);
        Assert.AreEqual(expected.LastName, actual.LastName);

        for (int i = 0; i < 1; i++)
        {
            Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
            Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
            Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
            Assert.AreEqual(expected.AddressList[i].County, actual.AddressList[i].County);
            Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
            Assert.AreEqual(expected.AddressList[i].PostCode, actual.AddressList[i].PostCode);
        }
    }
}