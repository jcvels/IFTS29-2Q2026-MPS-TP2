using NUnit.Framework;

namespace ProductSystem;

public class ProductManagerTests
{
    private ProductManager productManager = null!;

    [SetUp]
    public void SetUp()
    {
        productManager = new ProductManager();
    }

    [Test]
    public void AddProduct_WithValidProduct()
    {
        Product product = new Product(1, "Televisor", 1_000m, Product.CategoryElectronics);

        productManager.AddProduct(product);

        Assert.Multiple(() =>
        {
            Assert.That(productManager.ProductsList, Has.Count.EqualTo(1));
            Assert.That(productManager.ProductsList[0], Is.SameAs(product));
        });
    }

    [TestCase("Televisor", 1)]
    [TestCase("Pan", 2)]
    [TestCase("Auriculares", 3)]
    public void FindProductByName_WithExistingName(string searchedName, int expectedId)
    {
        productManager.AddProduct(new Product(1, "Televisor", 1_000m, Product.CategoryElectronics));
        productManager.AddProduct(new Product(2, "Pan", 500m, Product.CategoryFood));
        productManager.AddProduct(new Product(3, "Auriculares", 700m, Product.CategoryElectronics));

        Product? result = productManager.FindProductByName(searchedName);

        Assert.That(result, Is.Not.Null);
        Assert.That(result!.Id, Is.EqualTo(expectedId));
    }

    [Test]
    public void FindProductByName_WithUnknownName()
    {
        productManager.AddProduct(new Product(1, "Televisor", 1_000m, Product.CategoryElectronics));

        Product? result = productManager.FindProductByName("Heladera");

        Assert.That(result, Is.Null);
    }

    [Test]
    public void CalculateTotalPrice_ForElectronics()
    {
        var product = new Product(1, "Televisor", 1_000m, Product.CategoryElectronics);

        decimal result = productManager.CalculateTotalPrice(product);

        Assert.That(result, Is.EqualTo(1_100m));
    }

    [Test]
    public void CalculateTotalPrice_ForFood()
    {
        var product = new Product(2, "Pan", 1_000m, Product.CategoryFood);

        decimal result = productManager.CalculateTotalPrice(product);

        Assert.That(result, Is.EqualTo(1_050m));
    }
}
