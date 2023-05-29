using ACM.BL;

namespace ACM.BLTest;

[TestClass()]
public class ProductRepositoryTest
{
    [TestMethod()]
    public void RetrieveValid()
    {
        // Arrange
        var productRepository = new ProductRepository();
        var expected = new Product(2)
        {
            ProductName = "Laptop",
            ProductDescription = "Dell XPS 15 9500",
            CurrentPrice = 2495
        };

        // Act
        var actual = productRepository.Retrieve(2);

        // Assert
        Assert.AreEqual(expected.ProductName, actual.ProductName);
        Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
        Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
    }

}