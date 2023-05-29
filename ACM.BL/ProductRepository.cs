namespace ACM.BL;

public class ProductRepository
{
    /// <summary>
    /// Retrieve one product.
    /// </summary>
    /// <param name="productId"></param>
    /// <returns></returns>
    public Product Retrieve(int productId)
    {
        // Create the instance of the Product class
        // Pass in the requested Id
        Product product = new Product(productId);

        // Code that retrieves the defined product

        // Temporary hard-coded values to return a populated product
        if (productId == 2)
        {
            product.ProductName = "Laptop";
            product.ProductDescription = "Dell XPS 15 9500";
            product.CurrentPrice = 2495;
        }

        return product;
    }

    /// <summary>
    /// Saves the current product. 
    /// </summary>
    /// <param name="product"></param>
    /// <returns></returns>
    public bool Save(Product product)
    {
        // Code that saves the passed in product

        return true;
    }
}