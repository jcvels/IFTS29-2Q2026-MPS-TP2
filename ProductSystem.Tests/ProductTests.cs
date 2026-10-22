using NUnit.Framework;

namespace ProductSystem;

public sealed class ProductTests
{
    [Test]
    public void CreatesProduct__WithValidData()
    {
        var product = new Product(1, "Televisor", 1_000m, Product.CategoryElectronics);

        Assert.Multiple(() =>
        {
            Assert.That(product.Id, Is.EqualTo(1));
            Assert.That(product.Name, Is.EqualTo("Televisor"));
            Assert.That(product.Price, Is.EqualTo(1_000m));
            Assert.That(product.Category, Is.EqualTo(Product.CategoryElectronics));
        });
    }

    [Test]
    public void CreatesProduct__WithNegativePrice()
    {
        Assert.That(
            () => new Product(1, "Televisor", -1m, Product.CategoryElectronics),
            Throws.TypeOf<ArgumentOutOfRangeException>()
        );
    }

    [TestCase("Limpieza")]
    [TestCase("")]
    [TestCase("   ")]
    public void CreatesProduct__WithInvalidCategory(string category)
    {
        Assert.That(
            () => new Product(1, "Producto", 100m, category),
            Throws.TypeOf<ArgumentException>()
        );
    }
}
